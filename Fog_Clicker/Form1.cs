using menucheck;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fog_Clicker
{
    public partial class Form1 : Form
    {
        #region dlls
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("User32.Dll", EntryPoint = "PostMessageA")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("User32.dll")]
        public static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey); // Keys enumeration
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void cpstb_Scroll(object sender, EventArgs e)
        {
            cpsvalue.Text = "CPS:" + cpstb.Value;
        }

        //clicker toggle
        #region clicker
        private void clickertoggle_Click(object sender, EventArgs e)
        {
            if (clickertoggle.Text == "Disabled")
            {
                clickertoggle.Text = "Enabled";
            }
            else
            {
                clickertoggle.Text = "Disabled";
            }
        }

        private void clickertoggle_TextChanged(object sender, EventArgs e)
        {
            if (clickertoggle.Text == "Enabled")
            {
                clickertoggle.BackColor = Color.Crimson;
                clickertoggle.ForeColor = Color.FromArgb(10, 10, 10);
                clicker.Start();
            }
            else if (clickertoggle.Text == "Disabled")
            {
                clickertoggle.ForeColor = Color.Crimson;
                clickertoggle.BackColor = Color.FromArgb(10, 10, 10);
                clicker.Stop();
            }
        }
        #endregion
        #region a clicker

        private void actoggle_Click(object sender, EventArgs e)
        {
            if (actoggle.Text == "Disabled")
            {
                actoggle.Text = "Enabled";
                a_clicker.Start();
            }
            else
            {
                actoggle.Text = "Disabled";
                a_clicker.Stop();
            }
        }

        private void actoggle_TextChanged(object sender, EventArgs e)
        {
            if (actoggle.Text == "Enabled")
            {
                actoggle.BackColor = Color.Crimson;
                actoggle.ForeColor = Color.FromArgb(10, 10, 10);
            }
            else if (clickertoggle.Text == "Disabled")
            {
                actoggle.ForeColor = Color.Crimson;
                actoggle.BackColor = Color.FromArgb(10, 10, 10);
;           }
        }
        #endregion

        //actual clicker
        #region clicking
        private async void clicker_Tick(object sender, EventArgs e)
        {
            clicker.Interval = 1000 / RandomisedCPS;
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (clickertoggle.Text == "Enabled")
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            if (!menucheck.ClickerExtensionHandle.InMenu())
                            {
                                SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                                await Task.Delay(20);
                                SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                            }
                        }
                    }
                }
            }
        }
        #endregion
        #region randomization

        int RandomisedCPS = 10;
        private void randomizer_Tick(object sender, EventArgs e)
        {
            RandomisedCPS = new Random().Next(cpstb.Value - 2, cpstb.Value + 3);
        }
        #endregion
        #region binds
       
        #endregion

        #region block hit

        #endregion
        #region ac_controller
        public static Random rnd = new Random();
        private void ac_controller_Tick(object sender, EventArgs e)
        {

            if (ac_options.Text == "Basic")
            {
                int delay = 1000 / rnd.Next(12 -3, 12 +3);
                a_clicker.Interval = delay;
            }
            else if (ac_options.Text == "Dope old")
            {
                int delay = (int)(1000 / (rnd.Next() % (14 - 12) + 12) * 0.8);
                int dope = (delay * (rnd.Next(11, 14) / 10));
                a_clicker.Interval = delay;
            }
            else if (ac_options.Text == "Night clicker")
            {
                int delay = 1000 / (rnd.Next(11, 15));
                a_clicker.Interval = delay;

            }
            else if (ac_options.Text == "Mango")
            {
                int delay = 1000 / rnd.Next(11, 15);
                a_clicker.Interval = delay;

            }
            else if (ac_options.Text == "Zoom")
            {
                int delay = 800 / 12;
                a_clicker.Interval = delay;
            }
            else if (ac_options.Text == "No randomizer")
            {
                int delay = 1000 / 12;
                a_clicker.Interval = delay;
            }
            else if (ac_options.Text == "Axenta")
            {
                int minval;
                int maxval;
                minval = (1000 / 14 + 11 * (int)0.2);
                maxval = (1000 / 14 + 11 * (int)0.48);


                int minval2;
                int maxval2;
                minval2 = minval + 15;
                maxval2 = maxval + 15;
                a_clicker.Interval = rnd.Next(minval2, maxval2);
            }
            else
            {
                a_clicker.Interval = rnd.Next(12 -3, 12 +3);
            }
        }
        #endregion
        #region advanced clicker
        public void a_clicker_Tick(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("javaw");
            foreach (Process process in processes)
            {
                if (GetForegroundWindow() == FindWindow(null, process.MainWindowTitle))
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        if (!menucheck.ClickerExtensionHandle.InMenu())
                        {
                            SendMessage(GetForegroundWindow(), 0x201, 0, 0);
                            Thread.Sleep(rnd.Next(10, 30));
                            SendMessage(GetForegroundWindow(), 0x202, 0, 0);
                        }
                    }
                }
            }
        }
        #endregion
        #region a binds
        private void aclickerbind_Click(object sender, EventArgs e)
        {
            aclickerbind.Text = "...";
            aclickerbind.BackColor = Color.Crimson;
            aclickerbind.ForeColor = Color.FromArgb(10, 10, 10);
        }

        KeysConverter aKey = new KeysConverter();
        private void aclickerbind_KeyUp(object sender, KeyEventArgs e)
        {
            string akeydata = e.KeyData.ToString();
            if (!akeydata.Contains("Alt"))
            {
                if (clickerbind.BackColor == Color.Crimson)
                {
                    if (GetAsyncKeyState(Keys.Escape) < 0)
                    {
                        aclickerbind.Text = "none";
                        aclickerbind.ForeColor = Color.Crimson;
                        aclickerbind.BackColor = Color.FromArgb(10, 10, 10);
                    }
                    else
                    {
                        aclickerbind.Text = akeydata;
                        Thread.Sleep(20);
                        aclickerbind.ForeColor = Color.Crimson;
                        aclickerbind.BackColor = Color.FromArgb(10, 10, 10);
                    }
                }
            }
        }

        private void aclickerbind_KeyDown(object sender, KeyEventArgs e)
        {
            if (aclickerbind.BackColor == Color.Crimson)
            {
                if (GetAsyncKeyState(Keys.Escape) < 0)
                {
                    aclickerbind.Text = "none";
                    aclickerbind.ForeColor = Color.Crimson;
                    aclickerbind.BackColor = Color.FromArgb(10, 10, 10);
                }
            }
        }
        #endregion


        //destruct
        #region destruct
        private void des_Click(object sender, EventArgs e)
        {
            Destruct.Destruction();
        }

        #endregion

    }
}
