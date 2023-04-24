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

        static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        
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

                    Console.WriteLine("MC instance found");
                    Console.WriteLine(mc);
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

            Console.SetWindowSize(40, 10);
            Console.WriteLine("Enter UserID");
            string user = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Checking HWID...");
            WebClient client = new WebClient();

            string HWID = System.Security.Principal.WindowsIdentity.GetCurrent().User.Value;

            string appHWID = client.DownloadString("https://raw.githubusercontent.com/ertyplax/Fog_Auth/main/Fog");
            if (appHWID.Contains(ComputeSha256Hash(HWID + "qOYL6ikQ4axxIyiwi5z82yChFBvhfT" + user)))
            {
                Console.Clear();
                Console.WriteLine("Authenticated :)");
                Thread.Sleep(2000);
                Console.Clear();
                Console.SetWindowSize(40, 10);
                Console.WriteLine("currently logged as: " + user);
                Console.WriteLine("Do Not close this window");
                Application.EnableVisualStyles(); 
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Error while contacting server :(");
                Console.WriteLine("try again later");
                Thread.Sleep(4000);
                Console.Clear();
                Environment.Exit(0);
            }
        }
    }       
}
