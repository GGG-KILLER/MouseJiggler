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
		[DebuggerDisplay("{Value}")]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.49-beta+91f5c15987")]
		internal readonly partial struct HHOOK
			: IEquatable<HHOOK>
		{
			internal readonly IntPtr Value;

			internal HHOOK(IntPtr value) => this.Value = value;

			internal static HHOOK Null => default;

			internal bool IsNull => Value == default;

			public static implicit operator IntPtr(HHOOK value) => value.Value;

			public static explicit operator HHOOK(IntPtr value) => new HHOOK(value);

			public static bool operator ==(HHOOK left, HHOOK right) => left.Value == right.Value;

			public static bool operator !=(HHOOK left, HHOOK right) => !(left == right);

			public bool Equals(HHOOK other) => this.Value == other.Value;

			public override bool Equals(object obj) => obj is HHOOK other && this.Equals(other);

			public override int GetHashCode() => this.Value.GetHashCode();

			public override string ToString() => $"0x{this.Value:x}";
		}
	}
}
