using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace MouseJiggler
{
    [SupportedOSPlatform("windows5.0")]
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
