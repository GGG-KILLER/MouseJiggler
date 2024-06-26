﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436,CS8981
using global::System;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System.Runtime.Versioning;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{
	internal static partial class PInvoke
	{
		/// <summary>Posted to the window with the keyboard focus when a nonsystem key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed.</summary>
		/// <returns>An application should return zero if it processes this message.</returns>
		/// <remarks>
		/// <para>If the F10 key is pressed, the [**DefWindowProc**](/windows/desktop/api/winuser/nf-winuser-defwindowproca) function sets an internal flag. When **DefWindowProc** receives the [**WM\_KEYUP**](wm-keyup.md) message, the function checks whether the internal flag is set and, if so, sends a [**WM\_SYSCOMMAND**](/windows/desktop/menurc/wm-syscommand) message to the top-level window. The **WM\_SYSCOMMAND** parameter of the message is set to SC\_KEYMENU. Because of the autorepeat feature, more than one **WM\_KEYDOWN** message may be posted before a [**WM\_KEYUP**](wm-keyup.md) message is posted. The previous key state (bit 30) can be used to determine whether the **WM\_KEYDOWN** message indicates the first down transition or a repeated down transition. For enhanced 101- and 102-key keyboards, extended keys are the right ALT and CTRL keys on the main section of the keyboard; the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and ENTER keys in the numeric keypad. Other keyboards may support the extended-key bit in the *lParam* parameter. Applications must pass *wParam* to [**TranslateMessage**](/windows/desktop/api/winuser/nf-winuser-translatemessage) without altering it at all.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/inputdev/wm-keydown#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		internal const uint WM_KEYDOWN = 256U;

		/// <summary>Posted to the window with the keyboard focus when a nonsystem key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed, or a keyboard key that is pressed when a window has the keyboard focus.</summary>
		/// <returns>An application should return zero if it processes this message.</returns>
		/// <remarks>
		/// <para>The [**DefWindowProc**](/windows/desktop/api/winuser/nf-winuser-defwindowproca) function sends a [**WM\_SYSCOMMAND**](/windows/desktop/menurc/wm-syscommand) message to the top-level window if the F10 key or the ALT key was released. The *wParam* parameter of the message is set to SC\_KEYMENU. For enhanced 101- and 102-key keyboards, extended keys are the right ALT and CTRL keys on the main section of the keyboard; the INS, DEL, HOME, END, PAGE UP, PAGE DOWN, and arrow keys in the clusters to the left of the numeric keypad; and the divide (/) and ENTER keys in the numeric keypad. Other keyboards may support the extended-key bit in the *lParam* parameter. Applications must pass *wParam* to [**TranslateMessage**](/windows/desktop/api/winuser/nf-winuser-translatemessage) without altering it at all.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/inputdev/wm-keyup#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		internal const uint WM_KEYUP = 257U;
	}
}
