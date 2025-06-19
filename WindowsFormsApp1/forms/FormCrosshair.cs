using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCrosshair : Form
    {
        public FormCrosshair()
        {
            ShowInTaskbar = false;
            Opacity = 0.7;
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void FormCrosshair_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            TopMost = true;
            Size = new Size(7, 7);

            var screen = Screen.PrimaryScreen.Bounds;
            Location = new Point(
                screen.Left + (screen.Width - Width) / 2,
                screen.Top + (screen.Height - Height) / 2
            );

            BackColor = Color.White;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, Width, Height);
            Region = new Region(path);

            Hide();
            MakeClickThrough();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x80;
                return cp;
            }
        }

        private void MakeClickThrough()
        {
            int exStyle = GetWindowLong(this.Handle, GWL_EXSTYLE);
            exStyle |= WS_EX_LAYERED | WS_EX_TRANSPARENT;
            SetWindowLong(this.Handle, GWL_EXSTYLE, exStyle);
        }

        private const int GWL_EXSTYLE = -20;
        private const int WS_EX_LAYERED = 0x80000;
        private const int WS_EX_TRANSPARENT = 0x20;

        [DllImport("user32.dll")]
        private static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        private static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        private void FormCrosshair_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int thickness = 2;
            int diameter = Width;

            using (Pen pen = new Pen(Color.Black, thickness))
            {
                g.DrawEllipse(pen, 0, 0, diameter, diameter);
            }

            using (Brush brush = new SolidBrush(Color.White))
            {
                g.FillEllipse(brush, thickness, thickness, diameter - 2 * thickness, diameter - 2 * thickness);
            }
        }
    }
}
