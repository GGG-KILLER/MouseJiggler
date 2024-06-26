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
	namespace UI.Input.KeyboardAndMouse
	{
		/// <summary>Used by SendInput to store information for synthesizing input events such as keystrokes, mouse movement, and mouse clicks.</summary>
		/// <remarks><b> INPUT_KEYBOARD</b> supports nonkeyboard input methods, such as handwriting recognition or voice recognition, as if it were text input by using the <b>KEYEVENTF_UNICODE</b> flag. For more information, see the remarks section of <a href="https://docs.microsoft.com/windows/desktop/api/winuser/ns-winuser-keybdinput">KEYBDINPUT</a>.</remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.49-beta+91f5c15987")]
		internal partial struct INPUT
		{
			/// <summary>Type: <b>DWORD</b></summary>
			internal winmdroot.UI.Input.KeyboardAndMouse.INPUT_TYPE type;

			internal _Anonymous_e__Union Anonymous;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.49-beta+91f5c15987")]
			internal partial struct _Anonymous_e__Union
			{
				[FieldOffset(0)]
				internal winmdroot.UI.Input.KeyboardAndMouse.MOUSEINPUT mi;

				[FieldOffset(0)]
				internal winmdroot.UI.Input.KeyboardAndMouse.KEYBDINPUT ki;

				[FieldOffset(0)]
				internal winmdroot.UI.Input.KeyboardAndMouse.HARDWAREINPUT hi;
			}
		}
	}
}
