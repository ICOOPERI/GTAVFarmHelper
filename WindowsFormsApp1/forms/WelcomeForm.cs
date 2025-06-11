using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            Show();
        }

        private void TestForm_Load(object sender, EventArgs e)
        {
            string iface = Methods.GetNetworkInterfaceName();
            label2.Text = iface;
            if (Properties.Settings.Default.Version != null && Properties.Settings.Default.Version != "")
                Settings.gameVersion = Properties.Settings.Default.Version;

            if (Properties.Settings.Default.OverlayKey != null && Properties.Settings.Default.OverlayKey != "")
                Settings.setKey(Properties.Settings.Default.OverlayKey);

            Settings.networkType = iface;
            GameVersionComboBox.SelectedItem = Settings.gameVersion;
            Settings.gameVersion = Properties.Settings.Default.Version;
            HotKeyTextBox.Text = Settings.overlayKey.ToString();
            Settings.setKeyboardChecker();
        }

        private void guna2TextBox1_Enter(object sender, EventArgs e)
        {
            Settings.keyboardChecker.SetHotKeyHook();
            HotKeyTextBox.Clear();
            Settings.keyboardChecker.DisposeOverlayHook();
        }

        public void guna2TextBox1_Leave(object sender, EventArgs e)
        {
            Settings.keyboardChecker.DisposeHotKeyHook();
            Settings.setKey(HotKeyTextBox.Text);
            Settings.keyboardChecker.SetOverlayHook();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Version = GameVersionComboBox.Items[GameVersionComboBox.SelectedIndex].ToString();
            Properties.Settings.Default.Save();
            Settings.gameVersion = Properties.Settings.Default.Version;
        }
    }
}
