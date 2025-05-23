﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace SFM_MultiRender
{
    internal class SessionManager
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
        public static baseAddressFinder memoryEditor = new baseAddressFinder();
        static async Task<Int32> getProgressFromPID(activeLayoffSession session)
        {
            MemorySearch _ms = new MemorySearch();
            IntPtr result = session.QtBase;
            try
            {
                //store the base address of qtgui and avoid having to re-get it for the same session
                if (result == IntPtr.Zero)
                {
                    result = await memoryEditor.getBaseAddressOfDLL("QtGui4.dll", session.PID);
                    if (result != IntPtr.Zero)
                    {
                        session.QtBase = result;
                    }
                }

                //get progress % from process
                _ms.openProcess(session.PID);
                int[] progressPointerOffsets = new int[] { 0, 0x14, 0x18, 0x4, 0x134 };
                result += 0x008b8d70;
                byte[] percent = _ms.readMemoryPointerInt(result, progressPointerOffsets).Skip(-4).ToArray();
                int finalPercent = BitConverter.ToInt32(percent, 0);

                //flag to start displaying progress %
                if (finalPercent > 0 && session.started == false)
                {
                    session.started = true;
                }

                return finalPercent;
            }
            catch (Exception ex)
            {
                if (ex.HResult == -0x7FECEB00)
                {
                    //either we cant access sfm's memory, or it was a session
                    //with very little frames and it completed before we even got memory access, mark it as done.
                    session.started = true;
                }
                return PROCESS_ENDED;
            }
        }

        public static void sendDebugTxt(string txt)
        {
            mainForm.debugtxt.Invoke((MethodInvoker)(() => {
                mainForm.debugtxt.AppendText(txt + Environment.NewLine);
            }));
        }

        public void abortAllNow()
        {
            aborted = true;
            for (int i = activeLayoffsList.Count - 1; i >= 0; i--)
            {
                activeLayoffSession session = activeLayoffsList[i];
                try
                {
                    Process proc = Process.GetProcessById(session.PID);
                    proc.Kill();
                    sendDebugTxt("Session "+session.number+" killed.");
                }
                catch (ArgumentException)
                {
                    sendDebugTxt("Session " + session.number + "already killed.");
                }
                catch (Exception)
                {
                    sendDebugTxt("Session " + session.number + " ERROR, cannot kill.");
                }
            }
        }

        private static int nextCore = 0;
        IntPtr GetAffinityMask(int coreIndex)
        {
            return (IntPtr)(1 << coreIndex);
        }

        public int getPhysCoreCount()
        {
            int physicalCoreCount = 0;

            var searcher = new ManagementObjectSearcher("select NumberOfCores from Win32_Processor");
            foreach (var item in searcher.Get())
            {
                physicalCoreCount += Convert.ToInt32(item["NumberOfCores"]);
            }
            return physicalCoreCount;
        }


    public async Task<int> launchAndGetPID(activeLayoffSession session)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = Properties.Settings.Default.sfmExe.Replace("\"", ""),
                Arguments = Properties.Settings.Default.launchArgs + session.layoffArg,
                UseShellExecute = false,
                CreateNoWindow = true
            };
            try
            {
                Process proc = Process.Start(startInfo);
                if (proc != null){
                    sendDebugTxt("[Started] Session "+(session.number+1)+". PID:" + proc.Id);
                    //manually sequence cores instead of letting windows
                    if (Properties.Settings.Default.sequenceCores)
                    {
                        await Task.Delay(100); //give it time to start
                        try{
                            proc.ProcessorAffinity = GetAffinityMask(nextCore);
                            sendDebugTxt("Set Session "+(session.number+1)+" core:" + nextCore);
                        }
                        catch{
                            sendDebugTxt("Couldnt set Session " + (session.number + 1) + " core.");
                        }
                        nextCore = (session.number + 1) > getPhysCoreCount() ? 0 : (session.number + 1);
                    }
                    return proc.Id;
                }         
            }
            catch{
                sendDebugTxt("Couldn't start Session #" + session.number + "!");
            }
            return -1;
        }
        
        private static bool aborted = false;
        //hacky way to access the main form but oh well makes my life easier
        static SFM_MultiRenderForm mainForm = Application.OpenForms["SFM_MultiRenderForm"] as SFM_MultiRenderForm;
        static async Task<bool> sessionWatcher(Control.ControlCollection sessions)
        {
            windowHider hider = new windowHider();
            bool releasedTopMost = false;
            while (activeLayoffsList.Count > 0 && !aborted)
            {
                for (int i = activeLayoffsList.Count - 1; i >= 0; i--)
                {
                    int progCount = 0;
                    activeLayoffSession session = activeLayoffsList[i];
                    int progress = await Task.Run(() => getProgressFromPID(session));
                    SessionCtrlGroup sessionTemp = (SessionCtrlGroup)sessions[session.number];
                    if (session.started && progress == PROCESS_ENDED)
                    {
                        sendDebugTxt("[Session "+(session.number+1)+"] Complete");
                        progress = 100;
                        activeLayoffsList.RemoveAt(i);
                    }
                    if (progress > -1 && progress <= 100)
                    {
                        progCount++;
                        sessionTemp.layoffProgressBar.Invoke((MethodInvoker)(() =>
                        {
                            sessionTemp.layoffProgressBar.Value = progress;
                            sessionTemp.layoffProgressBar.Text = progress + "%";
                        }));
                    }
                    //auto disable topmost when everything has been minimized.
                    if (!releasedTopMost && mainForm.autoHideCheckbox.Checked){
                        if(activeLayoffsList.Count(x => x.started) == activeLayoffsList.Count){
                            releasedTopMost = true;
                            mainForm.Invoke((MethodInvoker)(() => {
                                mainForm.TopMost = false;
                            }));
                        }
                    }
                }
                await Task.Delay(1000);
                
                if (mainForm.autoHideCheckbox.Checked)
                {
                    hider.fakeMinimize(".dmx - Source Filmmaker");
                    hider.fakeMinimize("Movie Layoff Progress");
                }
            }
            nextCore = 0;
            aborted = false;
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
                temp.PID = await launchAndGetPID(temp);
                activeLayoffsList.Add(temp);
                i++;
            }

            return await Task.Run(() => sessionWatcher(sessions));
        }
    }

}
