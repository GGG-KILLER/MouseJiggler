using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Versioning;
using Windows.Win32;
using Windows.Win32.UI.Input.KeyboardAndMouse;


namespace MouseJiggler
{
    [SupportedOSPlatform("windows5.0")]
    public partial class Main : Form
    {
        const int circleRadius = 50;

        private static int _shouldRun = 0;
        private static Thread _worker;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;

            lblHowToCancel.Visible = false;

            //jiggle
            chkJiggleConstant.Enabled = false;
            chkJiggleEveryX.Enabled = false;
            chkJiggleRandom.Enabled = false;
            chkJiggleUntil.Enabled = false;


            //click
            chkClickEvery.Enabled = false;
            chkClickRandom.Enabled = false;

            cboJiggleEveryOptions.SelectedIndex = 1;
            cboJiggleEveryOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJiggleEveryOptions.Enabled = false;

            dtpJiggleUntil.Enabled = false;
            dtpJiggleUntil.Value = DateTime.Today.AddDays(1);
        }

        public static void MouseEventCircle(int radius)
        {
            var scrWidth = PInvoke.GetSystemMetrics(SYSTEM_METRICS_INDEX.SM_CXSCREEN);
            var scrHeight = PInvoke.GetSystemMetrics(SYSTEM_METRICS_INDEX.SM_CYSCREEN);

            int x = scrWidth / 2, y = scrHeight / 2;
            Helpers.MoveMouseTo(x, y, true);

            for (int i = 0; i < 720; i++)
            {
                var (sin, cos) = Math.SinCos(i * (Math.PI / 360.0));
                var targetX = (scrWidth / 2) + Convert.ToInt32(radius * sin);
                var targetY = (scrHeight / 2) + Convert.ToInt32(radius * cos);

                Helpers.MoveMouseTo(targetX - x, targetY - y, false);

                x = targetX;
                y = targetY;

                if (i % 20 == 0)
                {
                    Thread.Sleep(1);
                }
            }
        }

        public enum JiggleType
        {
            CONSTANT,
            EVERYX,
            RANDOM,
            UNTIL
        }

        public static void ThreadProc(JiggleType type, object control)
        {
            try
            {
                if (type == JiggleType.CONSTANT)
                {
                    control = (int)control;
                    while (Volatile.Read(ref _shouldRun) == 1)
                    {
                        MouseEventCircle((int)control);
                    }
                }
                else if (type == JiggleType.EVERYX)
                {
                    List<string> arr = (List<string>)control;

                    int duration = Convert.ToInt32(arr[0]);
                    string timeset = arr[1];
                    int radius = Convert.ToInt32(arr[2]);

                    if (timeset == "seconds")
                    {
                        duration *= 1000;
                    }
                    else if (timeset == "minutes")
                    {
                        duration = duration * 60 * 1000;
                    }
                    else if (timeset == "hours")
                    {
                        duration = duration * 60 * 60 * 1000;
                    }
                    else if (timeset == "days")
                    {
                        duration = duration * 24 * 60 * 60 * 1000;
                    }

                    while (Volatile.Read(ref _shouldRun) == 1)
                    {
                        MouseEventCircle(radius);

                        var wake = DateTime.Now.AddMilliseconds(duration);
                        while (Volatile.Read(ref _shouldRun) == 1 && DateTime.Now < wake)
                            Thread.Sleep(500);
                    }
                }
                else if (type == JiggleType.RANDOM)
                {
                    int radius = (int)control;
                    while (Volatile.Read(ref _shouldRun) == 1)
                    {
                        var duration = Random.Shared.Next(60) * 1000;
                        MouseEventCircle(radius);
                        Thread.Sleep(duration);
                    }
                }
                else if (type == JiggleType.UNTIL)
                {
                    List<string> arr = (List<string>)control;

                    int day, month, year;
                    int radius = Convert.ToInt32(arr[3]);
                    day = Convert.ToInt32(arr[0]);
                    month = Convert.ToInt32(arr[1]);
                    year = Convert.ToInt32(arr[2]);
                    var target = new DateTime(year, month, day);

                    while (target < DateTime.Now && Volatile.Read(ref _shouldRun) == 1)
                    {
                        MouseEventCircle(radius);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

            Volatile.Write(ref _shouldRun, 0);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (Interlocked.CompareExchange(ref _shouldRun, 1, 0) != 0)
                return;

            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            lblHowToCancel.Visible = true;
            object control;
            if (chkJiggle.Checked)
            {
                JiggleType curType = JiggleType.CONSTANT;

                if (chkJiggleConstant.Checked)
                {
                    curType = JiggleType.CONSTANT;
                    control = circleRadius;
                }
                else if (chkJiggleEveryX.Checked)
                {
                    curType = JiggleType.EVERYX;
                    control = new List<string> { mskEveryXMinutes.Text, cboJiggleEveryOptions.SelectedItem.ToString(), circleRadius.ToString() };
                }
                else if (chkJiggleRandom.Checked)
                {
                    curType = JiggleType.RANDOM;
                    control = circleRadius;
                }
                else if (chkJiggleUntil.Checked)
                {
                    curType = JiggleType.UNTIL;
                    DateTime date = dtpJiggleUntil.Value;
                    control = new List<string> { date.Day.ToString(), date.Month.ToString(), date.Year.ToString(), circleRadius.ToString() };
                }
                else
                {
                    curType = JiggleType.CONSTANT;
                    control = circleRadius;
                }

                Interlocked.Exchange(ref _shouldRun, 1);
                _worker = new Thread(() => ThreadProc(curType, control));
                _worker.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Volatile.Read(ref _shouldRun) == 1)
            {
                btnStart.Enabled = false;
                btnCancel.Enabled = true;
            }
            else
            {
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
                lblHowToCancel.Visible = false;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (Interlocked.CompareExchange(ref _shouldRun, 0, 1) == 1)
            {
                btnStart.Enabled = true;
                btnCancel.Enabled = false;

                lblHowToCancel.Visible = false;

                try
                {
                    _worker.Join(TimeSpan.FromSeconds(10));
                }
                catch (Exception o)
                {
                    MessageBox.Show(o.ToString());
                }
                _worker = null;
            }
        }

        private void chkJiggle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggle.CheckState == CheckState.Checked)
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
            else
            {
                chkJiggleConstant.Checked = false;
                chkJiggleEveryX.Checked = false;
                chkJiggleRandom.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleEveryX.Enabled = false;
                chkJiggleRandom.Enabled = false;
                chkJiggleUntil.Enabled = false;
            }
        }

        private void chkClick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClick.CheckState == CheckState.Checked)
            {
                chkClickEvery.Enabled = true;
                chkClickRandom.Enabled = true;
            }
            else
            {
                chkClickEvery.Checked = false;
                chkClickRandom.Checked = false;

                chkClickEvery.Enabled = false;
                chkClickRandom.Enabled = false;
            }
        }

        private void chkJiggleConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleConstant.Checked)
            {
                chkJiggleEveryX.Checked = false;
                chkJiggleRandom.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleEveryX.Enabled = false;
                chkJiggleRandom.Enabled = false;
                chkJiggleUntil.Enabled = false;
            }
            else
            {
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
        }

        private void chkJiggleEveryX_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleEveryX.Checked)
            {
                chkJiggleConstant.Checked = false;
                chkJiggleRandom.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleRandom.Enabled = false;
                chkJiggleUntil.Enabled = false;

                mskEveryXMinutes.Enabled = true;
                cboJiggleEveryOptions.Enabled = true;

            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;

                mskEveryXMinutes.Enabled = false;
                cboJiggleEveryOptions.Enabled = false;
            }
        }

        private void chkJiggleRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleRandom.Checked)
            {
                chkJiggleConstant.Checked = false;
                chkJiggleEveryX.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleEveryX.Enabled = false;
                chkJiggleUntil.Enabled = false;
            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
        }

        private void chkJiggleUntil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleUntil.Checked)
            {
                chkJiggleConstant.Checked = false;
                chkJiggleEveryX.Checked = false;
                chkJiggleRandom.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleEveryX.Enabled = false;
                chkJiggleRandom.Enabled = false;

                dtpJiggleUntil.Enabled = true;
            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;

                dtpJiggleUntil.Enabled = false;
            }
        }

        private void dtpJiggleUntil_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJiggleUntil.Value <= DateTime.Today)
            {
                dtpJiggleUntil.Value = DateTime.Today.AddDays(1);
            }
        }

        private void mskEveryXMinutes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void chkClickEvery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClickEvery.Checked)
            {
                chkClickRandom.Checked = false;

                chkClickRandom.Enabled = false;
            }
            else
            {
                chkClickRandom.Enabled = true;
            }
        }

        private void chkClickRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClickRandom.Checked)
            {
                chkClickEvery.Checked = false;

                chkClickEvery.Enabled = false;
            }
            else
            {
                chkClickEvery.Enabled = true;
            }
        }
    }
}
