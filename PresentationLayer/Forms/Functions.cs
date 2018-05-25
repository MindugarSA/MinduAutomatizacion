using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    public static class Functions
    {
        public static void ConfigurarMaterialSkinManager()
        {
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.ROBOTO_MEDIUM_10 = new Font("Segoe UI Light", 10);
            skinManager.ROBOTO_MEDIUM_11 = new Font("Segoe UI Light", 11);
            skinManager.ROBOTO_MEDIUM_12 = new Font("Segoe UI Light", 12);
            skinManager.ROBOTO_REGULAR_11 = new Font("Segoe UI Light", 11);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Orange500, MaterialSkin.Primary.LightBlue500, MaterialSkin.Primary.Blue500, MaterialSkin.Accent.LightBlue400, MaterialSkin.TextShade.WHITE);
        }
    }
}
