using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        public static FormOverlay form1;
        public static FormCrosshair crosshair;
        public static FormBG form_bg;
        public static WelcomeForm welcomeForm;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            welcomeForm = new WelcomeForm();
            form1 = new FormOverlay();
            crosshair = new FormCrosshair();
            Application.Run(welcomeForm);
        }
    }
}
