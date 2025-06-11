using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormBG : Form
    {
        public FormBG()
        {
            InitializeComponent();
        }

        public FormBG(Form _foregroundForm)
        {
            InitializeComponent();
            StartPosition = _foregroundForm.StartPosition;
            Location = _foregroundForm.Location;
            Size = _foregroundForm.Size;
            _foregroundForm.Resize += _foregroundForm_Resize;
            FormBorderStyle = FormBorderStyle.None;
            _foregroundForm.LocationChanged += _foregroundForm_LocationChanged;
            ShowInTaskbar = false;
            BackColor = Color.Black;
            Opacity = 0.5;
            TopMost = true;
            Hide();
        }

        void _foregroundForm_LocationChanged(object sender, EventArgs e)
        {
            Location = (sender as Form).Location;
        }

        void _foregroundForm_Resize(object sender, EventArgs e)
        {
            WindowState = (sender as Form).WindowState;
            Size = (sender as Form).Size;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ExStyle |= 0x80020;
                return cp;
            }
        }
    }
}
