using GamesOverlay;
using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Text;
using WindowsInput;

namespace WindowsFormsApp1
{
    internal class Methods
    {
        public static string GetNetworkInterfaceName()
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = "interface show interface",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardOutputEncoding = Encoding.GetEncoding(65001)
            };

            using (Process process = Process.Start(psi))
            {
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();
                
                var lines = output.Split(new[] { '\r', '\n', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                
                return lines[lines.Length - 1];
            }
        }

        public static void DisableInternet()
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = $"interface set interface \"{Settings.networkType}\" admin=disable",
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true
            };

            Process.Start(psi);

            Message("Выключаем сеть");
        }

        public static void EnableInternet()
        {
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "netsh",
                Arguments = $"interface set interface \"{Settings.networkType}\" admin=enable",
                Verb = "runas",
                UseShellExecute = true,
                CreateNoWindow = true
            };

            Process.Start(psi);
            Message("Включаем сеть");
        }

        public static async void FreezeProcess(string processName, int durationSeconds)
        {
            await ProcessFreezer.FreezeProcess(processName, durationSeconds);
        }

        public static bool checkInternetStatus()
        {
            return NetworkInterface.GetIsNetworkAvailable();
        }

        public static void Message(string message)
        {
            string timestamp = DateTime.Now.ToString("[HH:mm:ss.ff] ");
            Program.form1.MessageBox.Items.Insert(0, timestamp + message);
            if (Program.form1.MessageBox.Items.Count > 30)
                Program.form1.MessageBox.Items.RemoveAt(Program.form1.MessageBox.Items.Count - 1);
        }
        
        static int time = 5;
        public static bool AntiAfkEnabled = false;
        static readonly VirtualKeyCode[] keys = new[] { VirtualKeyCode.VK_W, VirtualKeyCode.VK_A, VirtualKeyCode.VK_S, VirtualKeyCode.VK_D };
        static int currentIndex = 0;
        static System.Timers.Timer timer;

        public static void AntiAfkStart()
        {            
            if (timer != null)
            {
                return;
            }

            timer = new System.Timers.Timer(time * 1000);
            timer.Elapsed += (s, e) => SimulateNextKey();
            timer.AutoReset = true;
            timer.Start();
            
            AntiAfkEnabled = true;
        }

        public static void AntiAfkStop()
        {
            
            if (timer == null) return;

            timer.Stop();
            timer.Dispose();
            timer = null;
            
            AntiAfkEnabled = false;
        }

        private static void SimulateNextKey()
        {
            VirtualKeyCode key = keys[currentIndex];            

            new InputSimulator().Keyboard
                .KeyPress(key)
                .Sleep(50);

            currentIndex = (currentIndex + 1) % keys.Length;

            Program.form1.Invoke(new Action(() =>
            {
                Message($"Эмуляция кнопки {key.ToString().Substring(3)}");
            }));
        }
    }
}