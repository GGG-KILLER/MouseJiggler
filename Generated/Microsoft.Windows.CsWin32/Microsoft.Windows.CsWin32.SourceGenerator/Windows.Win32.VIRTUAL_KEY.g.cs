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
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.3.49-beta+91f5c15987")]
		internal enum VIRTUAL_KEY : ushort
		{
			VK_0 = 48,
			VK_1 = 49,
			VK_2 = 50,
			VK_3 = 51,
			VK_4 = 52,
			VK_5 = 53,
			VK_6 = 54,
			VK_7 = 55,
			VK_8 = 56,
			VK_9 = 57,
			VK_A = 65,
			VK_B = 66,
			VK_C = 67,
			VK_D = 68,
			VK_E = 69,
			VK_F = 70,
			VK_G = 71,
			VK_H = 72,
			VK_I = 73,
			VK_J = 74,
			VK_K = 75,
			VK_L = 76,
			VK_M = 77,
			VK_N = 78,
			VK_O = 79,
			VK_P = 80,
			VK_Q = 81,
			VK_R = 82,
			VK_S = 83,
			VK_T = 84,
			VK_U = 85,
			VK_V = 86,
			VK_W = 87,
			VK_X = 88,
			VK_Y = 89,
			VK_Z = 90,
			VK_ABNT_C1 = 193,
			VK_ABNT_C2 = 194,
			VK_DBE_ALPHANUMERIC = 240,
			VK_DBE_CODEINPUT = 250,
			VK_DBE_DBCSCHAR = 244,
			VK_DBE_DETERMINESTRING = 252,
			VK_DBE_ENTERDLGCONVERSIONMODE = 253,
			VK_DBE_ENTERIMECONFIGMODE = 248,
			VK_DBE_ENTERWORDREGISTERMODE = 247,
			VK_DBE_FLUSHSTRING = 249,
			VK_DBE_HIRAGANA = 242,
			VK_DBE_KATAKANA = 241,
			VK_DBE_NOCODEINPUT = 251,
			VK_DBE_NOROMAN = 246,
			VK_DBE_ROMAN = 245,
			VK_DBE_SBCSCHAR = 243,
			VK__none_ = 255,
			VK_LBUTTON = 1,
			VK_RBUTTON = 2,
			VK_CANCEL = 3,
			VK_MBUTTON = 4,
			VK_XBUTTON1 = 5,
			VK_XBUTTON2 = 6,
			VK_BACK = 8,
			VK_TAB = 9,
			VK_CLEAR = 12,
			VK_RETURN = 13,
			VK_SHIFT = 16,
			VK_CONTROL = 17,
			VK_MENU = 18,
			VK_PAUSE = 19,
			VK_CAPITAL = 20,
			VK_KANA = 21,
			VK_HANGEUL = 21,
			VK_HANGUL = 21,
			VK_IME_ON = 22,
			VK_JUNJA = 23,
			VK_FINAL = 24,
			VK_HANJA = 25,
			VK_KANJI = 25,
			VK_IME_OFF = 26,
			VK_ESCAPE = 27,
			VK_CONVERT = 28,
			VK_NONCONVERT = 29,
			VK_ACCEPT = 30,
			VK_MODECHANGE = 31,
			VK_SPACE = 32,
			VK_PRIOR = 33,
			VK_NEXT = 34,
			VK_END = 35,
			VK_HOME = 36,
			VK_LEFT = 37,
			VK_UP = 38,
			VK_RIGHT = 39,
			VK_DOWN = 40,
			VK_SELECT = 41,
			VK_PRINT = 42,
			VK_EXECUTE = 43,
			VK_SNAPSHOT = 44,
			VK_INSERT = 45,
			VK_DELETE = 46,
			VK_HELP = 47,
			VK_LWIN = 91,
			VK_RWIN = 92,
			VK_APPS = 93,
			VK_SLEEP = 95,
			VK_NUMPAD0 = 96,
			VK_NUMPAD1 = 97,
			VK_NUMPAD2 = 98,
			VK_NUMPAD3 = 99,
			VK_NUMPAD4 = 100,
			VK_NUMPAD5 = 101,
			VK_NUMPAD6 = 102,
			VK_NUMPAD7 = 103,
			VK_NUMPAD8 = 104,
			VK_NUMPAD9 = 105,
			VK_MULTIPLY = 106,
			VK_ADD = 107,
			VK_SEPARATOR = 108,
			VK_SUBTRACT = 109,
			VK_DECIMAL = 110,
			VK_DIVIDE = 111,
			VK_F1 = 112,
			VK_F2 = 113,
			VK_F3 = 114,
			VK_F4 = 115,
			VK_F5 = 116,
			VK_F6 = 117,
			VK_F7 = 118,
			VK_F8 = 119,
			VK_F9 = 120,
			VK_F10 = 121,
			VK_F11 = 122,
			VK_F12 = 123,
			VK_F13 = 124,
			VK_F14 = 125,
			VK_F15 = 126,
			VK_F16 = 127,
			VK_F17 = 128,
			VK_F18 = 129,
			VK_F19 = 130,
			VK_F20 = 131,
			VK_F21 = 132,
			VK_F22 = 133,
			VK_F23 = 134,
			VK_F24 = 135,
			VK_NAVIGATION_VIEW = 136,
			VK_NAVIGATION_MENU = 137,
			VK_NAVIGATION_UP = 138,
			VK_NAVIGATION_DOWN = 139,
			VK_NAVIGATION_LEFT = 140,
			VK_NAVIGATION_RIGHT = 141,
			VK_NAVIGATION_ACCEPT = 142,
			VK_NAVIGATION_CANCEL = 143,
			VK_NUMLOCK = 144,
			VK_SCROLL = 145,
			VK_OEM_NEC_EQUAL = 146,
			VK_OEM_FJ_JISHO = 146,
			VK_OEM_FJ_MASSHOU = 147,
			VK_OEM_FJ_TOUROKU = 148,
			VK_OEM_FJ_LOYA = 149,
			VK_OEM_FJ_ROYA = 150,
			VK_LSHIFT = 160,
			VK_RSHIFT = 161,
			VK_LCONTROL = 162,
			VK_RCONTROL = 163,
			VK_LMENU = 164,
			VK_RMENU = 165,
			VK_BROWSER_BACK = 166,
			VK_BROWSER_FORWARD = 167,
			VK_BROWSER_REFRESH = 168,
			VK_BROWSER_STOP = 169,
			VK_BROWSER_SEARCH = 170,
			VK_BROWSER_FAVORITES = 171,
			VK_BROWSER_HOME = 172,
			VK_VOLUME_MUTE = 173,
			VK_VOLUME_DOWN = 174,
			VK_VOLUME_UP = 175,
			VK_MEDIA_NEXT_TRACK = 176,
			VK_MEDIA_PREV_TRACK = 177,
			VK_MEDIA_STOP = 178,
			VK_MEDIA_PLAY_PAUSE = 179,
			VK_LAUNCH_MAIL = 180,
			VK_LAUNCH_MEDIA_SELECT = 181,
			VK_LAUNCH_APP1 = 182,
			VK_LAUNCH_APP2 = 183,
			VK_OEM_1 = 186,
			VK_OEM_PLUS = 187,
			VK_OEM_COMMA = 188,
			VK_OEM_MINUS = 189,
			VK_OEM_PERIOD = 190,
			VK_OEM_2 = 191,
			VK_OEM_3 = 192,
			VK_GAMEPAD_A = 195,
			VK_GAMEPAD_B = 196,
			VK_GAMEPAD_X = 197,
			VK_GAMEPAD_Y = 198,
			VK_GAMEPAD_RIGHT_SHOULDER = 199,
			VK_GAMEPAD_LEFT_SHOULDER = 200,
			VK_GAMEPAD_LEFT_TRIGGER = 201,
			VK_GAMEPAD_RIGHT_TRIGGER = 202,
			VK_GAMEPAD_DPAD_UP = 203,
			VK_GAMEPAD_DPAD_DOWN = 204,
			VK_GAMEPAD_DPAD_LEFT = 205,
			VK_GAMEPAD_DPAD_RIGHT = 206,
			VK_GAMEPAD_MENU = 207,
			VK_GAMEPAD_VIEW = 208,
			VK_GAMEPAD_LEFT_THUMBSTICK_BUTTON = 209,
			VK_GAMEPAD_RIGHT_THUMBSTICK_BUTTON = 210,
			VK_GAMEPAD_LEFT_THUMBSTICK_UP = 211,
			VK_GAMEPAD_LEFT_THUMBSTICK_DOWN = 212,
			VK_GAMEPAD_LEFT_THUMBSTICK_RIGHT = 213,
			VK_GAMEPAD_LEFT_THUMBSTICK_LEFT = 214,
			VK_GAMEPAD_RIGHT_THUMBSTICK_UP = 215,
			VK_GAMEPAD_RIGHT_THUMBSTICK_DOWN = 216,
			VK_GAMEPAD_RIGHT_THUMBSTICK_RIGHT = 217,
			VK_GAMEPAD_RIGHT_THUMBSTICK_LEFT = 218,
			VK_OEM_4 = 219,
			VK_OEM_5 = 220,
			VK_OEM_6 = 221,
			VK_OEM_7 = 222,
			VK_OEM_8 = 223,
			VK_OEM_AX = 225,
			VK_OEM_102 = 226,
			VK_ICO_HELP = 227,
			VK_ICO_00 = 228,
			VK_PROCESSKEY = 229,
			VK_ICO_CLEAR = 230,
			VK_PACKET = 231,
			VK_OEM_RESET = 233,
			VK_OEM_JUMP = 234,
			VK_OEM_PA1 = 235,
			VK_OEM_PA2 = 236,
			VK_OEM_PA3 = 237,
			VK_OEM_WSCTRL = 238,
			VK_OEM_CUSEL = 239,
			VK_OEM_ATTN = 240,
			VK_OEM_FINISH = 241,
			VK_OEM_COPY = 242,
			VK_OEM_AUTO = 243,
			VK_OEM_ENLW = 244,
			VK_OEM_BACKTAB = 245,
			VK_ATTN = 246,
			VK_CRSEL = 247,
			VK_EXSEL = 248,
			VK_EREOF = 249,
			VK_PLAY = 250,
			VK_ZOOM = 251,
			VK_NONAME = 252,
			VK_PA1 = 253,
			VK_OEM_CLEAR = 254,
		}
	}
}