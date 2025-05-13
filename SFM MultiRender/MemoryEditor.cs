using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SFM_MultiRender
{
    internal class MemoryEditor
    {
        // Import OpenProcess from kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

        // Import ReadProcessMemory from kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);

        // Import CloseHandle
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool CloseHandle(IntPtr hObject);
        const int PROCESS_VM_READ = 0x0010;
        const int PROCESS_QUERY_INFORMATION = 0x0400;

        public async Task<IntPtr> getBaseAddressOfDLL(string dllName, int PID)
        {
            
            IntPtr dllAddress = IntPtr.Zero;
            while (dllAddress == IntPtr.Zero)
            {
                Process sessionProcess = Process.GetProcessById(PID);
                try
                {
                    foreach (ProcessModule module in sessionProcess.Modules)
                    {
                        if (module.ModuleName.Equals(dllName, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"DLL: {module.ModuleName}");
                            Console.WriteLine($"Base Address: 0x{module.BaseAddress.ToInt64():X}");
                            dllAddress = module.BaseAddress;
                            
                        }
                    }
                    await Task.Delay(2000);
                  }
                catch (Exception ex)
                {
                    Console.WriteLine($"Could not access modules for process {sessionProcess.ProcessName}: {ex.Message}");
                }
            }
            return dllAddress;
        }

    
    }
}
