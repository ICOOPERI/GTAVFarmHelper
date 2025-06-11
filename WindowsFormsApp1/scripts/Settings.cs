using GamesOverlay;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Settings
    {
        public static string networkType;
        public static string gameVersion;
        public static Keys overlayKey;
        public static KeyboardChecker keyboardChecker;

        public static void setKey(string keyName)
        {
           
            if (Enum.TryParse(keyName, out Keys key))
            {
                overlayKey = key;
                Properties.Settings.Default.OverlayKey = keyName;
                Properties.Settings.Default.Save();
            }
            else
            {
                overlayKey = Keys.None;
            }
        }

        public static void setKeyboardChecker()
        {
            if (keyboardChecker == null)
                keyboardChecker = new KeyboardChecker();
        }

        public static string getGameProcessName()
        {
            switch (gameVersion)
            {
                case "Legacy":
                    return "GTA5";
                case "Enhanced":
                case null:
                    return "GTA5_Enhanced";
            }
            return "null";
        }
    }
}
