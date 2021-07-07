using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMHelper
{
    static class AppConfig
    {
        public static string FontFamily
        {
            get { return ConfigurationManager.AppSettings["FontFamily"]; }
            set { updateAppSetting("FontFamily", value); }
        }

        public static float FontSize
        {
            get { return float.Parse(ConfigurationManager.AppSettings["FontSize"]); }
            set { updateAppSetting("FontSize", value.ToString()); }
        }

        public static int FontStyle
        {
            get { return int.Parse(ConfigurationManager.AppSettings["FontStyle"]); }
            set { updateAppSetting("FontStyle", value.ToString()); }
        }

        public static string FontColor
        {
            get { return ConfigurationManager.AppSettings["FontColor"]; }
            set { updateAppSetting("FontColor", value); }
        }

        public static string FontOutlineColor
        {
            get { return ConfigurationManager.AppSettings["FontOutlineColor"]; }
            set { updateAppSetting("FontOutlineColor", value); }
        }

        public static float FontOutlineWidth
        {
            get { return float.Parse(ConfigurationManager.AppSettings["FontOutlineWidth"]); }
            set { updateAppSetting("FontOutlineWidth", value.ToString()); }
        }

        private static void updateAppSetting(string key, string value)
        {
            var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = configFile.AppSettings.Settings;
            settings[key].Value = value;
            configFile.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);
        }
    }
}
