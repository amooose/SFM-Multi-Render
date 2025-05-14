using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
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
            public IntPtr QtBase { get; set; }
            public bool started { get; set; }
            public activeLayoffSession(int n, int p, string arg)
            {
                number = n;
                PID = p;
                layoffArg = arg;
                QtBase = IntPtr.Zero;
                started = false;
            }
        }
        private static int PROCESS_ENDED = -2;

        public static List<activeLayoffSession> activeLayoffsList = new List<activeLayoffSession>();
        public static MemoryEditor memoryEditor = new MemoryEditor();
        static async Task<Int32> getProgressFromPID(activeLayoffSession session)
        {
            MemorySearch _ms = new MemorySearch();
            IntPtr result = session.QtBase;
            try
            {
                if (result == IntPtr.Zero)
                {
                    result = await memoryEditor.getBaseAddressOfDLL("QtGui4.dll", session.PID);
                    if (result != IntPtr.Zero)
                    {
                        session.QtBase = result;
                    }
                }
                
                if (result == IntPtr.Zero)
                {
                    Console.WriteLine("still 0");
                    return -1;
                }

                
                _ms.openProcess(session.PID);
                int[] progressPointerOffsets = new int[] { 0, 0x14, 0x18, 0x4, 0x134 };
                result += 0x008b8d70;
                byte[] percent = _ms.readMemoryPointerInt(result, progressPointerOffsets).Skip(-4).ToArray();
                int finalPercent = BitConverter.ToInt32(percent, 0);
                if (finalPercent > 0 && session.started == false)
                {
                    session.started = true;
                }

                return finalPercent;
            } catch (Exception ex)
            {
                if (ex.HResult == -0x7FECEB00)
                {
                    //either we cant access sfm's memory, or it was a session
                    //with very little frames and it completed before we even got memory access, mark it as done.
                    Console.WriteLine($"DONE: Error: {ex.Message}");
                    session.started = true;
                }
                return -2;
            }
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
                    SFM_MultiRender.ActiveForm.Controls["debugtxt"].Text += Environment.NewLine+"Started process. PID:" + proc.Id;
                    //Console.WriteLine($"Started process. PID: {proc.Id}");
                    return proc.Id;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error starting process: {ex.Message} hr: {ex.HResult}");
            }


            return -1;
        }


        static SFM_MultiRender mainForm = Application.OpenForms["SFM_MultiRender"] as SFM_MultiRender;
        static async Task<bool> sessionWatcher(Control.ControlCollection sessions)
        {
            windowHider hider = new windowHider();
            while (activeLayoffsList.Count > 0)
            {
                for (int i = activeLayoffsList.Count - 1; i >= 0; i--) {
                    activeLayoffSession session = activeLayoffsList[i];
                    int progress = await getProgressFromPID(session);
                    SessionCtrlGroup sessionTemp = (SessionCtrlGroup)sessions[session.number];
                    if (session.started && progress == -2)
                    {
                        progress = 100;
                        activeLayoffsList.RemoveAt(i);
                    }
                    if (progress > -1 && progress <= 100)
                    {
                        sessionTemp.layoffProgressBar.Value = progress;
                        sessionTemp.layoffProgressBar.Text = progress + "%";
                    }
                }
                await Task.Delay(1000);
                
                if (mainForm.autoHideCheckbox.Checked)
                {
                    hider.FakeMinimizeAllWindowsByPartialTitle(".dmx - Source Filmmaker");
                    hider.FakeMinimizeAllWindowsByPartialTitle("Movie Layoff Progress");
                }
            }
            return true;
        }

        public async Task<bool> launchSessions(Control.ControlCollection sessions)
        {
            int i = 0;
            foreach (SessionCtrlGroup session in sessions)
            {
                string project = session.projectFileValue.Replace("\"", "");
                string output = session.outputDirValue.Replace("\"", "");
                string arg = " -sfm_loadsession \"" + project +
                    "\" -sfm_layoffframerange " + session.startFrameValue + "," + session.endFrameValue +
                    " -sfm_autolayoff \"" + output + "\"";
                activeLayoffSession temp = new activeLayoffSession(i, -1, arg);
                temp.PID = launchLogPID(temp);
                activeLayoffsList.Add(temp);
                i++;
            }
            
            return await sessionWatcher(sessions);
        }
    }
}
