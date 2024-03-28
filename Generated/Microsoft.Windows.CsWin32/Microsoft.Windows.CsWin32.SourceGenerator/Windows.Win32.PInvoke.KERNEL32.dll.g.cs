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

	/// <content>
	/// Contains extern methods from "KERNEL32.dll".
	/// </content>
	internal static partial class PInvoke
	{
		/// <summary>Frees the loaded dynamic-link library (DLL) module and, if necessary, decrements its reference count.</summary>
		/// <param name="hLibModule">
		/// <para>A handle to the loaded library module. The <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a>, <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibraryexa">LoadLibraryEx</a>, <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandlea">GetModuleHandle</a>, or <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandleexa">GetModuleHandleEx</a> function returns this handle.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary#parameters">Read more on docs.microsoft.com</see>.</para>
		/// </param>
		/// <returns>
		/// <para>If the function succeeds, the return value is nonzero. If the function fails, the return value is zero. To get extended error information, call the <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a> function.</para>
		/// </returns>
		/// <remarks>
		/// <para>The system maintains a per-process reference count for each loaded module. A  module that was loaded at process initialization due to load-time dynamic linking has a reference count of one. The reference count for a module is incremented each time the  module is loaded by a call to <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibrarya">LoadLibrary</a>. The reference count is also incremented by a call to <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibraryexa">LoadLibraryEx</a> unless the  module  is being loaded for the first time and is being loaded as   a data or image file. The reference count is decremented each time the <b>FreeLibrary</b> or <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibraryandexitthread">FreeLibraryAndExitThread</a> function is called for the module. When a  module's reference count reaches zero or the process terminates, the system unloads the module from the address space of the  process. Before unloading a library module, the system enables the module to detach from the process by calling the module's <a href="https://docs.microsoft.com/windows/desktop/Dlls/dllmain">DllMain</a> function, if it has one, with the DLL_PROCESS_DETACH value. Doing so gives the library module an opportunity to clean up resources allocated on behalf of the current process. After the entry-point function returns, the library module is removed from the address space of the current process. It is not safe to call <b>FreeLibrary</b> from <a href="https://docs.microsoft.com/windows/desktop/Dlls/dllmain">DllMain</a>. For more information, see the Remarks section in <a href="https://docs.microsoft.com/windows/desktop/Dlls/dllmain">DllMain</a>. Calling <b>FreeLibrary</b> does not affect other processes that are using the same module. Use caution when calling <b>FreeLibrary</b> with a handle returned by <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandlea">GetModuleHandle</a>. The <b>GetModuleHandle</b> function does not increment a module's reference count, so passing this handle to <b>FreeLibrary</b> can cause a module to be unloaded prematurely. A thread that must unload the DLL in which it is executing and then terminate itself should call <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibraryandexitthread">FreeLibraryAndExitThread</a> instead of calling <b>FreeLibrary</b> and <b>ExitThread</b> separately. Otherwise, a race condition can occur. For details, see the Remarks section of <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibraryandexitthread">FreeLibraryAndExitThread</a>.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-freelibrary#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[DllImport("KERNEL32.dll", ExactSpelling = true, SetLastError = true)]
		[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
		[SupportedOSPlatform("windows5.1.2600")]
		internal static extern winmdroot.Foundation.BOOL FreeLibrary(winmdroot.Foundation.HMODULE hLibModule);

		/// <inheritdoc cref="GetModuleHandle(winmdroot.Foundation.PCWSTR)"/>
		[SupportedOSPlatform("windows5.1.2600")]
		internal static unsafe FreeLibrarySafeHandle GetModuleHandle(string lpModuleName)
		{
			fixed (char* lpModuleNameLocal = lpModuleName)
			{
				winmdroot.Foundation.HMODULE __result = PInvoke.GetModuleHandle(lpModuleNameLocal);
				return new FreeLibrarySafeHandle(__result, ownsHandle: false);
			}
		}

		/// <summary>Retrieves a module handle for the specified module. The module must have been loaded by the calling process. (Unicode)</summary>
		/// <param name="lpModuleName">
		/// <para>The name of the loaded module (either a .dll or .exe file). If the file name extension is omitted, the default library extension .dll is appended. The file name string can include a trailing point character (.) to indicate that the module name has no extension. The string does not have to specify a path. When specifying a path, be sure to use backslashes (\\), not forward slashes (/). The name is compared (case independently) to the names of modules currently mapped into the address space of the calling process.</para>
		/// <para>If this parameter is NULL, <b>GetModuleHandle</b> returns a handle to the file used to create the calling process (.exe file). The <b>GetModuleHandle</b> function does not retrieve handles for modules that were loaded using the <b>LOAD_LIBRARY_AS_DATAFILE</b> flag. For more information, see <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-loadlibraryexa">LoadLibraryEx</a>.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew#parameters">Read more on docs.microsoft.com</see>.</para>
		/// </param>
		/// <returns>
		/// <para>If the function succeeds, the return value is a handle to the specified module. If the function fails, the return value is NULL. To get extended error information, call <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-getlasterror">GetLastError</a>.</para>
		/// </returns>
		/// <remarks>
		/// <para>The returned handle is not global or inheritable. It cannot be duplicated or used by another process. If <i>lpModuleName</i> does not include a path and there is more than one loaded module with the same base name and extension, you cannot predict which module handle will be returned. To work around this problem, you could specify a path, use <a href="https://docs.microsoft.com/windows/desktop/Msi/side-by-side-assemblies">side-by-side assemblies</a>, or use <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-getmodulehandleexa">GetModuleHandleEx</a> to specify a memory location rather than a DLL name. The <b>GetModuleHandle</b> function returns a handle to a mapped module without incrementing its reference count. However, if this handle is passed to the <a href="https://docs.microsoft.com/windows/desktop/api/libloaderapi/nf-libloaderapi-freelibrary">FreeLibrary</a> function, the reference count of the mapped module will be decremented. Therefore, do not pass a handle returned by <b>GetModuleHandle</b> to the <b>FreeLibrary</b> function. Doing so can cause a DLL module to be unmapped prematurely. This function must be used carefully in a multithreaded application. There is no guarantee that the module handle remains valid between the time this function returns the handle and the time it is used. For example, suppose that a thread retrieves a module handle, but before it uses the handle, a second thread frees the module. If the system loads another module, it could reuse the module handle that was recently freed. Therefore, the first thread would have a handle to a different module  than the one intended.</para>
		/// <para><see href="https://learn.microsoft.com/windows/win32/api/libloaderapi/nf-libloaderapi-getmodulehandlew#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[DllImport("KERNEL32.dll", ExactSpelling = true, EntryPoint = "GetModuleHandleW", SetLastError = true)]
		[DefaultDllImportSearchPaths(DllImportSearchPath.System32)]
		[SupportedOSPlatform("windows5.1.2600")]
		internal static extern winmdroot.Foundation.HMODULE GetModuleHandle(winmdroot.Foundation.PCWSTR lpModuleName);
	}
}
