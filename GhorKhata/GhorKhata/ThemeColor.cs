using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GhorKhata
{
    internal class ThemeColor
    {
        //Background
        public static Color Primary = Color.FromArgb(45, 45, 48);
        public static Color InputBg = Color.FromArgb(62, 62, 66);
        public static Color InputBorder = Color.FromArgb(90, 90, 95);

        //Text
        public static Color TextMain = Color.FromArgb(255, 255, 255);
        public static Color TextSec = Color.FromArgb(200, 200, 200);

        //Button
        public static Color BtnPrimary = Color.FromArgb(0, 122, 204);
        public static Color BtnSuccess = Color.FromArgb(40, 167, 69);
        public static Color BtnDanger = Color.FromArgb(220, 53, 69);
        public static Color BtnNav = Color.FromArgb(255, 193, 7);
    }
}
