using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SFM_MultiRender
{
    //Should really just incorporate this into MemSearch class.
    internal class baseAddressFinder
    {
        // Import OpenProcess from kernel32.dll
        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

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
                            Console.WriteLine("DLL: "+module.ModuleName);
                            dllAddress = module.BaseAddress;
                        }
                    }
                    await Task.Delay(1000);
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
