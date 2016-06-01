using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerbRecon.Properties;

namespace HerbRecon
{
    public static class FontContainer
    {
        private static readonly PrivateFontCollection fonts = new PrivateFontCollection();
        private const string HelveticaLightPath = "hel_light.ttf";
        private const string HelveticaMediumPath = "hel_medium.ttf";
        private static bool _loaded;

        public static void Load()
        {
            File.WriteAllBytes(HelveticaLightPath, Resources.HelveticaNeue_Light);
            File.WriteAllBytes(HelveticaMediumPath, Resources.HelveticaNeue_Medium);
            fonts.AddFontFile(HelveticaLightPath);
            fonts.AddFontFile(HelveticaMediumPath);
            _loaded = true;
        }

        private static void CheckLoaded()
        {
            if (!_loaded) throw new NullReferenceException("Fonts have not been loaded yet. Use FontaContainer.Load");
        }

        public static FontFamily Helvetica
        {
            get
            {
                CheckLoaded();
                return fonts.Families[0];
            }
        }
    }
}
