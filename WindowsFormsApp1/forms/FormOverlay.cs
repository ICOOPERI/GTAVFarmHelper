using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormOverlay : Form
    {
        NotifyIcon trayIcon;

        public FormOverlay()
        {
            if (Properties.Settings.Default.LastX >= 0 && Properties.Settings.Default.LastY >= 0)
                StartPosition = FormStartPosition.Manual;

            Location = new Point(Properties.Settings.Default.LastX, Properties.Settings.Default.LastY);

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            ShowInTaskbar = true;
            BackColor = Color.Black;
            TransparencyKey = Color.Black;

            tray();
            Program.form_bg = new FormBG(this);

            Text = "Gta V helper by COOPER";
            Hide();

            Settings.keyboardChecker.SetOverlayHook();
            UpdateInternetLabel(Methods.checkInternetStatus());
        }

        void tray()
        {
            trayIcon = new NotifyIcon();
            trayIcon.Icon = this.Icon;
            trayIcon.Text = "Gta V helper by COOPER";
            trayIcon.Visible = true;

            trayIcon.ContextMenuStrip = new ContextMenuStrip();
            trayIcon.ContextMenuStrip.Items.Add("Показать", null, (s, e) => ShowForm());
            trayIcon.ContextMenuStrip.Items.Add("Выход", null, (s, e) => Application.Exit());

            trayIcon.DoubleClick += (s, e) => ShowForm();
        }

        private CancellationTokenSource internetCheckCts;

        public async void CheckInternetWithDelayAndAnimation()
        {
            internetCheckCts?.Cancel();
            internetCheckCts = new CancellationTokenSource();
            var token = internetCheckCts.Token;

            bool initialStatus = Methods.checkInternetStatus();
            string[] dots = { ".", "..", "..." };
            int dotIndex = 0;

            var startTime = DateTime.Now;
            InternetStatus.ForeColor = Color.LightSeaGreen;
            while ((DateTime.Now - startTime).TotalSeconds < 5)
            {
                if (token.IsCancellationRequested) return;

                InternetStatus.Text = $"{dots[dotIndex]}";
                dotIndex = (dotIndex + 1) % dots.Length;

                await Task.Delay(500, token);

                bool currentStatus = Methods.checkInternetStatus();
                if (currentStatus != initialStatus)
                {
                    UpdateInternetLabel(currentStatus);
                    return;
                }
            }

            UpdateInternetLabel(initialStatus);
        }

        private void UpdateInternetLabel(bool isAvailable)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(UpdateInternetLabel), isAvailable);
                return;
            }

            if (isAvailable)
            {
                InternetStatus.Text = "Доступна";
                InternetStatus.ForeColor = Color.Green;
            }
            else
            {
                InternetStatus.Text = "Без доступа";
                InternetStatus.ForeColor = Color.Red;
            }
        }

        public void ToggleOverlay()
        {

            if (Program.form1.Visible)
            {
                Program.form1.Hide();
                Program.form_bg.Hide();
                Cursor.Hide();
            }
            else
            {
                Program.form_bg.Show();
                Program.form1.Show();                
                Cursor.Show();
                UpdateInternetLabel(Methods.checkInternetStatus());
                Activate();
                Focus();
                BringToFront();
                dragPanel.PerformClick();
            }
        }

        public void ShowForm()
        {
            Program.form1.Show();
            Program.form_bg.Show();
            Cursor.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Methods.FreezeProcess(Settings.getGameProcessName(), 10);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (!Methods.checkInternetStatus())
            {
                Methods.EnableInternet();
                CheckInternetWithDelayAndAnimation();
            } else
            {
                Methods.Message("Сеть уже включена");
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (Methods.checkInternetStatus())
            {
                Methods.DisableInternet();
                CheckInternetWithDelayAndAnimation();
            } else
            {
                Methods.Message("Сеть уже отключена");
            }                
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            toggleAntiAfk();
        }

        void toggleAntiAfk()
        {
            if (!Methods.AntiAfkEnabled)
            {
                Methods.AntiAfkStart();
                Methods.Message("Запуск АнтиАфк");
                AntiAfkButton.FillColor = Color.OliveDrab;

            }
            else
            {
                Methods.AntiAfkStop();
                Methods.Message("АнтиАфк остановлен");
                AntiAfkButton.FillColor = Color.IndianRed;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings.keyboardChecker?.DisposeOverlayHook();
        }

        private void MessageBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Color bgColor = (e.Index % 2 == 0) ? Color.FromArgb(64, 64, 64) : Color.FromArgb(54, 54, 54);
            using (SolidBrush brush = new SolidBrush(bgColor))
            {
                e.Graphics.FillRectangle(brush, e.Bounds);
            }

            string text = ((ListBox)sender).Items[e.Index].ToString();
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds.Location, Color.White);

            e.DrawFocusRectangle();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                Properties.Settings.Default.LastX = Location.X;
                Properties.Settings.Default.LastY = Location.Y;
                Properties.Settings.Default.Save();
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            if (Program.crosshair.Visible)
            {
                Program.crosshair.Hide();
            }
            else
            {
                Program.crosshair.Show();
            }
        }
    }
}
