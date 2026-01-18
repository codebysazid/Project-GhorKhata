using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GhorKhata
{
    public static class ThemeColor
    {
        //Surface
        public static Color SurfacePanel = Color.FromArgb(60, 63, 65); //Background for the main panels (Your current color)
        public static Color SurfaceDark = Color.FromArgb(45, 45, 48);//Darker background for form depth
        public static Color SurfaceLight = Color.FromArgb(80, 83, 85);//Lighter background for highlights

        //Components
        public static Color InputBg = Color.FromArgb(75, 75, 80); //Background for TextBoxes/Inputs
        public static Color BorderDefault = Color.FromArgb(90, 90, 95); //Default border color
        public static Color BorderActive = Color.FromArgb(0, 122, 204);//Border color when a field is focused

        //Validation
        public static Color InputError = Color.FromArgb(100, 30, 30); //Red background for input errors
        public static Color InputSuccess = Color.FromArgb(30, 100, 30);//Green background for input success

        //Text
        public static Color TextMain = Color.FromArgb(255, 255, 255);//Primary white text
        public static Color TextDim = Color.FromArgb(180, 180, 180);//Dimmed secondary text for hints/labels

        //Actions
        public static Color ActionPrimary = Color.FromArgb(0, 122, 204);//Main blue for buttons
        public static Color StatusSuccess = Color.FromArgb(40, 167, 69);//Success green (Save/Register)
        public static Color StatusError = Color.FromArgb(220, 53, 69);//Error red (Delete/Cancel)
        public static Color StatusWarning = Color.FromArgb(255, 193, 7);//Warning yellow/amber
        //Font
        public static Font InputFont = new Font("Arial Rounded MT", 12F, FontStyle.Bold);
    }

}
