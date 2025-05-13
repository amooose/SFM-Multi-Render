using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFM_MultiRender
{


    internal class SessionManager : SFM_MultiRender
    {
        public class activeLayoffSession
        {
            public int number { get; set; }
            public int PID { get; set; }
            public string layoffArg { get; set; }
            public activeLayoffSession(int n, int p, string arg)
            {
                number = n;
                PID = p;
                layoffArg = arg;
            }
        }

        public static List<activeLayoffSession> activeLayoffsList = new List<activeLayoffSession>();
        public static MemoryEditor memoryEditor = new MemoryEditor();
        static async Task<Int32> getProgressFromPID(int PID)
        {
            IntPtr result = await memoryEditor.getBaseAddressOfDLL("QtGui4.dll", PID);
            MemorySearch _ms = new MemorySearch();
            _ms.openProcess(PID);
            _ms.readMemory(result, 8);
            int[] progressPointerOffsets = new int[] { 0, 0x14, 0x18, 0x4, 0x134 };
            result += 0x008b8d70;
            byte[] percent = _ms.readMemoryPointerInt(result, progressPointerOffsets).Skip(-4).ToArray();
            return BitConverter.ToInt32(percent, 0);
        }

        public int launchLogPID(activeLayoffSession session)
        {

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.sfmExe,
                Arguments = Properties.Settings.Default.launchArgs+ session.layoffArg,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            try
            {
                Process proc = Process.Start(startInfo);
                if (proc != null)
                {
                    SFM_MultiRender.ActiveForm.Controls["debugtxt"].Text += "\nStarted process. PID:" + proc.Id;
                    //Console.WriteLine($"Started process. PID: {proc.Id}");
                    return proc.Id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting process: {ex.Message}");
            }
            return -1;
        }

        public void launchSessions(Control.ControlCollection sessions)
        {
            int i = 0;
            foreach (SessionCtrlGroup session in sessions)
            {
                string arg = " -sfm_loadsession \"" + session.projectFileValue +
                    "\" -sfm_layoffframerange " + session.startFrameValue + "," + session.endFrameValue +
                    " -sfm_autolayoff \"" + session.outputDirValue + "\"";
                activeLayoffSession temp = new activeLayoffSession(i, -1, arg);
                temp.PID = launchLogPID(temp);
                activeLayoffsList.Add(temp);



                i++;
            }
        }
    }
}
