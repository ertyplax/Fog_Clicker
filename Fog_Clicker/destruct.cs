using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.ServiceProcess;

namespace Fog_Clicker
{
    public class Destruct
    {
        [DllImport("Kernel32.dll", SetLastError = true)]
        public static extern IntPtr OpenProcess(
            int dwDesitedAccess,
            bool bInheritHandle,
            int dwProcessID);

        [DllImport("kernel32.dll")]
        static extern int VirtualQueryEx(
            IntPtr hProcess,
            IntPtr lpAddress,
            out MEMORY_BASIC_INFORMATION lpBuffer,
            uint dwLength);

        [DllImport("kernel32.dll")]
        public static extern bool ReadProcessMemory(
            IntPtr hProcess,
            IntPtr lpBaseAddress,
            byte[] lpBuffer,
            IntPtr dwSize,
            ref int lpNumberOfBytesRead);

        [StructLayout(LayoutKind.Sequential)]
        public struct MEMORY_BASIC_INFORMATION
        {
            public IntPtr BaseAddress;
            public IntPtr AllocationBase;
            public uint AllocationProtect;
            public IntPtr RegionSize;
            public uint State;
            public uint Protect;
            public uint Type;
        }

            public static void Destruction()
            {
                Console.Clear();
                Console.WriteLine("Destructing...");
                paladinbypass();
            }

        public static void paladinbypass()
        {


            ServiceController serviceController = new ServiceController("DPS");
            if ((serviceController.Status.Equals(ServiceControllerStatus.Running)) || (serviceController.Status.Equals(ServiceControllerStatus.StartPending)))
            {
                serviceController.Stop();
            }
            serviceController.WaitForStatus(ServiceControllerStatus.Stopped);
            serviceController.Start();
            serviceController.WaitForStatus(ServiceControllerStatus.Running);

            string program = AppDomain.CurrentDomain.FriendlyName;

            DirectoryInfo directory = new DirectoryInfo(path: @"C:\Windows\Prefetch");

            FileInfo[] file_s = directory.GetFiles(searchPattern: program + "*");
            foreach (FileInfo file_sInfo in file_s)
            {
                File.Delete(file_sInfo.FullName);
            }


            DirectoryInfo lo = new DirectoryInfo(@"C:\windows\prefetch");
            new List<string>(Directory.GetFiles(@"C:\windows\prefetch")).ForEach(file =>
            {
                if (file.IndexOf("cmd", StringComparison.OrdinalIgnoreCase) >= 0)
                    File.Delete(file);
            });
            Application.Exit();
        }
    }
}
