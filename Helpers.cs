using System.Runtime.Versioning;
using Windows.Win32;
using Windows.Win32.UI.WindowsAndMessaging;
using Windows.Win32.UI.Input.KeyboardAndMouse;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;
using System;

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

    [SupportedOSPlatform("windows5.1.2600")]
    public static KeyboardHookHandle SetKeyboardHook(HOOKPROC handler)
    {
        using var currentProcess = Process.GetCurrentProcess();
        using var currentModule = currentProcess.MainModule;
        var moduleHandle = PInvoke.GetModuleHandle(currentModule.ModuleName);
        var hookHandle = PInvoke.SetWindowsHookEx(WINDOWS_HOOK_ID.WH_KEYBOARD_LL, handler, moduleHandle, 0);
        return new KeyboardHookHandle(hookHandle, moduleHandle);
    }
}

internal sealed class KeyboardHookHandle(UnhookWindowsHookExSafeHandle hookHandle, FreeLibrarySafeHandle libraryHandle) : IDisposable
{
    private bool disposedValue;

    public UnhookWindowsHookExSafeHandle HookHandle => hookHandle;

    private void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                HookHandle.Dispose();
                libraryHandle.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

public class BindingFunctions
{
    [DllImport("user32.dll")]
    static extern short GetKeyState(int nVirtKey);

    public static bool IsKeyDown(Keys keys)
    {
        return (GetKeyState((int)keys) & 0x8000) == 0x8000;
    }
}
