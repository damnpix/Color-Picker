using System.Drawing;

namespace Color_Picker.Scripts.UI
{
    public class ColorPalette
    {
        public static Color accentColor() => ColorTranslator.FromHtml("#014D96");
        public static Color backgroundColor() => ColorTranslator.FromHtml("#272727");
        public static Color foregroundColor() => ColorTranslator.FromHtml("#f9f8f8");
        public static Color headerBackgroundColor() => ColorTranslator.FromHtml("#202020");
        public static Color headerForegroundColor() => ColorTranslator.FromHtml("#7f7e7f");
        public static Color messageBackgroundColor() => ColorTranslator.FromHtml("#2e2e2e");
        public static Color messageButtonBackgroundColor() => ColorTranslator.FromHtml("#393939");
    }
}