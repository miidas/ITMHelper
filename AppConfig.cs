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
            set { ConfigurationManager.AppSettings.Set("FontFamily", value); }
        }

        public static float FontSize
        {
            get { return float.Parse(ConfigurationManager.AppSettings["FontSize"]); }
            set { ConfigurationManager.AppSettings.Set("FontSize", value.ToString()); }
        }

        public static int FontStyle
        {
            get { return int.Parse(ConfigurationManager.AppSettings["FontStyle"]); }
            set { ConfigurationManager.AppSettings.Set("FontStyle", value.ToString()); }
        }

        public static string FontColor
        {
            get { return ConfigurationManager.AppSettings["FontColor"]; }
            set { ConfigurationManager.AppSettings.Set("FontColor", value); }
        }

        public static string FontOutlineColor
        {
            get { return ConfigurationManager.AppSettings["FontOutlineColor"]; }
            set { ConfigurationManager.AppSettings.Set("FontOutlineColor", value); }
        }

        public static float FontOutlineWidth
        {
            get { return float.Parse(ConfigurationManager.AppSettings["FontOutlineWidth"]); }
            set { ConfigurationManager.AppSettings.Set("FontOutlineWidth", value.ToString()); }
        }
    }
}
