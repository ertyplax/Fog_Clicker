using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace Fog_Clicker
{
    internal class Program
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);

        [DllImport("user32.dll")]
        static extern int SetWindowText(IntPtr hWnd, string text);

        public static void Main(string[] args)
        {
            Console.WriteLine("checking Version...");
            WebClient info = new WebClient();
            string clicker_info = info.DownloadString("https://raw.githubusercontent.com/ertyplax/Fog_Auth/main/Fog_info");
            if (!clicker_info.Contains("Version: 1."))
            {
                Console.WriteLine("This version of fog is outdated");
                Console.WriteLine("Please download the latest version in the discord");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            Console.WriteLine("up to date :)");
            Console.WriteLine(clicker_info);
            Console.Title = "Fog clickrr " + clicker_info;
            Thread.Sleep(1800);
            Console.Clear();
            Process[] McInstance = Process.GetProcessesByName("javaw");
            
            
            if (McInstance.Length == 0)
            {
                Console.WriteLine("Mc instance not found :(");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }
            else
            {
                foreach (Process process in McInstance)
                {
                    string mc = process.MainWindowTitle;
                    
                    Console.WriteLine("MC Instance found");
                    Console.WriteLine(mc);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            Console.SetWindowSize(40, 10);
            Console.Clear();
            Console.WriteLine("Checking HWID...");
            WebClient client = new WebClient();

            string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            if (HWID.Length != 0)
            {
                Console.Clear();
                Console.WriteLine("Authenticated :)");
                Thread.Sleep(2000);
                Console.Clear();
                Console.SetWindowSize(40, 10);
                Console.WriteLine("currently logged as: " + "[guest]");

                foreach (Process process in McInstance)
                {
                    string mc = process.MainWindowTitle;

                    Console.WriteLine("Current MC instance:");
                    Console.WriteLine(mc);

                    string pid = mc.ToString();
                    string newname = "Fog_Clickrr LMAO | Made by erty | ertyplax.github.io/fogwebsite | Skidding ass clickers since 2022 :)";
                    Process[] proc = Process.GetProcessesByName(pid);
                    SetWindowText(process.MainWindowHandle, newname);
                    SetWindowText(process.Handle, "Fog_Clickrr on top!!!");
                }



                Console.WriteLine();
                Console.WriteLine("Do Not close this window");

                Application.EnableVisualStyles(); 
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
        }
    }       
}
