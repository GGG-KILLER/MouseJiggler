using System.Runtime.Versioning;
using Windows.Win32;
using Windows.Win32.UI.WindowsAndMessaging;
using Windows.Win32.UI.Input.KeyboardAndMouse;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace MouseJiggler;

internal static class Helpers
{
    [SupportedOSPlatform("windows5.0")]
    public static int CalculateAbsoluteCoordinateX(int x) =>
        x * 65536 / PInvoke.GetSystemMetrics(SYSTEM_METRICS_INDEX.SM_CXSCREEN);

    [SupportedOSPlatform("windows5.0")]
    public static int CalculateAbsoluteCoordinateY(int y) =>
        y * 65536 / PInvoke.GetSystemMetrics(SYSTEM_METRICS_INDEX.SM_CYSCREEN);

    [SupportedOSPlatform("windows5.0")]
    public static bool MoveMouseTo(int x, int y, bool isAbsolute)
    {
        if (isAbsolute)
        {
            x = CalculateAbsoluteCoordinateX(x);
            y = CalculateAbsoluteCoordinateY(y);
        }

        var ret = PInvoke.SendInput([
            new INPUT
            {
                type = INPUT_TYPE.INPUT_MOUSE,
                Anonymous = new INPUT._Anonymous_e__Union
                {
                    mi = new MOUSEINPUT
                    {
                        dx = x,
                        dy = y,
                        dwFlags = isAbsolute ? MOUSE_EVENT_FLAGS.MOUSEEVENTF_ABSOLUTE | MOUSE_EVENT_FLAGS.MOUSEEVENTF_MOVE : MOUSE_EVENT_FLAGS.MOUSEEVENTF_MOVE,
                    }
                }
            }
        ], Marshal.SizeOf<INPUT>());

        if (ret != 1)
        {
            var ecode = Marshal.GetLastWin32Error();
            Trace.WriteLine($"SendInput failed. return = {ret}, errorcode = 0x{ecode:X8} ({Marshal.GetPInvokeErrorMessage(ecode)})");
            return false;
        }
        return true;
    }
}