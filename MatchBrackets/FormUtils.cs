using System.Drawing;
using System.Windows.Forms;

namespace MatchBrackets
{
    public static class FormUtils
    {
        public static void IncreaseFontSize(this Control control)
        {
            
            control.Font = new Font(control.Font.Name, control.Font.SizeInPoints + 3f);
        }

        public static void DecreaseFontSize(this Control control)
        {
            var currentSize = control.Font.SizeInPoints;
            if (currentSize < 8) return;
            control.Font = new Font(control.Font.Name, control.Font.SizeInPoints - 3f);
        }

        public static void SetFontSize(this Control control, float fontSize)
        {
            control.Font = new Font(control.Font.Name, fontSize);
        }
    }
}
