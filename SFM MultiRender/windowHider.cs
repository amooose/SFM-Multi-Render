using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SFM_MultiRender
{
    internal class windowHider
    {
        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        [DllImport("user32.dll")]
        private static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool GetWindowRect(IntPtr hWnd, out RECT lpRect);

        [DllImport("user32.dll")]
        private static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [StructLayout(LayoutKind.Sequential)]
        public struct RECT
        {
            public int Left, Top, Right, Bottom;
        }


        //Backup layout position of SFM on first run
        string windowKeyPath = @"SOFTWARE\Valve\SourceFilmmaker\Layouts_9\1";
        string keyValueName = "WindowPercentageGeometry"; // name of the value
        public string stockInstallBackup = "@Rect(100 100 800 800)";
        public void firstRunBackupKey()
        {
            bool gotKey = false;
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(windowKeyPath))
            {
                if (key != null)
                {
                    object value = key.GetValue(keyValueName);
                    if (value != null)
                    {
                        Properties.Settings.Default.sfmGoodWindowPos = value.ToString();
                        Properties.Settings.Default.Save();
                        gotKey = true;
                    }
                }
            }

            if (gotKey)
            {
                try{
                    using (RegistryKey key = Registry.CurrentUser.CreateSubKey(windowKeyPath))
                    {
                        if (key != null)
                        {
                            key.SetValue("SMR_" + keyValueName,
                                Properties.Settings.Default.sfmGoodWindowPos,
                                RegistryValueKind.String);
                        }
                    }
                }catch{}
            }
        }

        //Restore layout1's position.
        public void restoreSFMWindowPostion(string forceVal) {
            string posVal = Properties.Settings.Default.sfmGoodWindowPos;
            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey(windowKeyPath, writable: true))
                {
                    if (key != null && (!posVal.Equals("") || !forceVal.Equals("")))
                    {
                        if (!forceVal.Equals("")) { posVal = forceVal; }
                        key.SetValue(keyValueName, posVal, RegistryValueKind.String);
                    }
                }
            }catch{}
        }


        public void fakeMinimize(string partialTitle)
        {
            EnumWindows((hWnd, lParam) =>
            {
                if (!IsWindowVisible(hWnd)) { return true; };

                int length = GetWindowTextLength(hWnd);
                if (length == 0) { return true; };

                StringBuilder sb = new StringBuilder(length + 1);
                GetWindowText(hWnd, sb, sb.Capacity);

                string title = sb.ToString();

                if (title.IndexOf(partialTitle, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    if (GetWindowRect(hWnd, out RECT rect))
                    {
                        int width = rect.Right - rect.Left;
                        int height = rect.Bottom - rect.Top;
                        int offscreenY = Screen.PrimaryScreen.WorkingArea.Bottom + 100;
                        MoveWindow(hWnd, rect.Left, offscreenY, width, height, true);
                    }
                }
                return true;
            }, IntPtr.Zero);
        }
    }
}
