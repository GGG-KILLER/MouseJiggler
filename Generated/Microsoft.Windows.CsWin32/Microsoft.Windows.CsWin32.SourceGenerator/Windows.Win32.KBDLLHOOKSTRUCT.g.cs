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
	namespace UI.WindowsAndMessaging
	{
		/// <summary>Contains information about a low-level keyboard input event.</summary>
		/// <remarks>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.49-beta+91f5c15987")]
		internal partial struct KBDLLHOOKSTRUCT
		{
			/// <summary>
			/// <para>Type: <b>DWORD</b> A <a href="https://docs.microsoft.com/windows/desktop/inputdev/virtual-key-codes">virtual-key code</a>. The code must be a value in the range 1 to 254.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint vkCode;

			/// <summary>
			/// <para>Type: <b>DWORD</b> A hardware scan code for the key.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint scanCode;

			/// <summary>
			/// <para>Type: <b>DWORD</b> The extended-key flag, event-injected flags, context code, and transition-state flag. This member is specified as follows. An application can use the following values to test the keystroke flags. Testing LLKHF_INJECTED (bit 4) will tell you whether the event was injected. If it was, then testing LLKHF_LOWER_IL_INJECTED (bit 1) will tell you whether or not the event was injected from a process running at lower integrity level. </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.UI.WindowsAndMessaging.KBDLLHOOKSTRUCT_FLAGS flags;

			/// <summary>
			/// <para>Type: <b>DWORD</b> The time stamp for this message, equivalent to what <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-getmessagetime">GetMessageTime</a> would return for this message.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint time;

			/// <summary>
			/// <para>Type: <b>ULONG_PTR</b> Additional information associated with the message.</para>
			/// <para><see href="https://learn.microsoft.com/windows/win32/api/winuser/ns-winuser-kbdllhookstruct#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal nuint dwExtraInfo;
		}
	}
}