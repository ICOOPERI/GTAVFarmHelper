using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WindowsFormsApp1;

namespace GamesOverlay
{
    internal class ProcessFreezer
    {
        [DllImport("kernel32.dll")]
        private static extern IntPtr OpenThread(int dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

        [DllImport("kernel32.dll")]
        private static extern uint SuspendThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern int ResumeThread(IntPtr hThread);

        [DllImport("kernel32.dll")]
        private static extern bool CloseHandle(IntPtr hHandle);

        private const int THREAD_SUSPEND_RESUME = 0x0002;

        public static async Task FreezeProcess(string processName, int durationSeconds)
        {
            var processes = Process.GetProcessesByName(processName);
            if (processes.Length == 0)
            {
                Methods.Message($"Процесс {processName} не найден");
                return;
            }

            var process = processes[0];
            Methods.Message($"Замораживаем {process.ProcessName} ({process.Id})");

            foreach (ProcessThread thread in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(THREAD_SUSPEND_RESUME, false, (uint)thread.Id);
                if (pOpenThread == IntPtr.Zero)
                    continue;

                SuspendThread(pOpenThread);
                CloseHandle(pOpenThread);
            }

            Methods.Message($"Процесс {process.ProcessName} заморожен на {durationSeconds} секунд");

            await Task.Delay(durationSeconds * 1000);

            foreach (ProcessThread thread in process.Threads)
            {
                IntPtr pOpenThread = OpenThread(THREAD_SUSPEND_RESUME, false, (uint)thread.Id);
                if (pOpenThread == IntPtr.Zero)
                    continue;

                ResumeThread(pOpenThread);
                CloseHandle(pOpenThread);
            }

            Methods.Message($"Процесс {process.ProcessName} разморожен");
        }

    }
}
