using System;
using System.Diagnostics;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace GamesOverlay
{
    internal class KeyboardChecker
    {
        public GlobalKeyboardHook MenuHook;
        public GlobalKeyboardHook OverlayHook;
        public bool isBindingKey = false;

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            OverlayHook.Dispose();
        }

        public void DisposeHotKeyHook()
        {
            MenuHook?.Dispose();
        }
        public void DisposeOverlayHook()
        {
            OverlayHook?.Dispose();
        }

        public void OnGlobalKeyDown(Keys key)
        {
            if (isBindingKey) return;

            if (key == Settings.overlayKey)
            {
                if (Settings.gameVersion.Contains("Legacy") || Settings.gameVersion.Contains("Enhanced"))
                {
                    Program.form1.ToggleOverlay();
                }
                else
                {
                    MessageBox.Show("Выберите версию игры", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
            }
        }

        public void SetHotKeyDown(Keys key)
        {                
            string keyName = key.ToString();

            Program.welcomeForm.Invoke(new Action(() =>
            {
                Program.welcomeForm.HotKeyTextBox.Text = keyName;
                Program.welcomeForm.label1.Focus();
            }));
        }


        public void SetOverlayHook()
        {
            OverlayHook = new GlobalKeyboardHook();
            OverlayHook.KeyDownEvent += OnGlobalKeyDown;
        }

        public void SetHotKeyHook()
        {
            MenuHook = new GlobalKeyboardHook();
            MenuHook.KeyDownEvent += SetHotKeyDown;
        }
    }
}
