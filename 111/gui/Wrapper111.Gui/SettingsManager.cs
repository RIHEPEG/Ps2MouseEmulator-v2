using System;
using System.IO;

namespace Wrapper111.Gui
{
    static class SettingsManager
    {
        static readonly string DirPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Wrapper111");
        static readonly string FilePath = Path.Combine(DirPath, "settings.txt");

        public static bool LoadWatermarkEnabled()
        {
            try
            {
                if (!File.Exists(FilePath)) return false;
                var s = File.ReadAllText(FilePath).Trim();
                if (bool.TryParse(s, out bool v)) return v;
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static void SaveWatermarkEnabled(bool enabled)
        {
            try
            {
                Directory.CreateDirectory(DirPath);
                File.WriteAllText(FilePath, enabled.ToString());
            }
            catch
            {
                // best-effort
            }
        }
    }
}
