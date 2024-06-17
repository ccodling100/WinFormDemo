using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Tile;

namespace DGSProfileManager
{
    public static class Styles
    {
        // Primary Colors
        public static Color PrimaryWhite = ColorTranslator.FromHtml("#F5F5F5");
        public static Color PrimaryBlack = Color.Black;
        public static Color PrimaryGreen = ColorTranslator.FromHtml("#086045");
        public static Color PrimaryBlue = ColorTranslator.FromHtml("#082B60");
        public static Color PrimaryGold = ColorTranslator.FromHtml("#BFB800");
        public static Color PrimaryGray = Color.Gray;
        public static Color PrimaryRed = ColorTranslator.FromHtml("#600818");
        
        public static void SetGlobalMaxStyle(LabelControl ctrl, bool enabled)
        {
            // ctrl.Enabled = enabled;
            if (enabled)
            {
                ctrl.BackColor = PrimaryGold;
                ctrl.ForeColor = PrimaryWhite;
            }
            else
            {
                ctrl.BackColor = PrimaryWhite;
                ctrl.ForeColor = PrimaryGray;
            }
        }

        public static void SetDayWeekStyle(LabelControl ctrl, bool enabled)
        {
            // ctrl.Enabled = enabled;   
            
            if (enabled)
            {
                ctrl.BackColor = PrimaryGreen;
                ctrl.ForeColor = PrimaryWhite;
            }
            else
            {
                ctrl.BackColor = PrimaryGreen;
                ctrl.ForeColor = PrimaryGray;
            }
        }

        public static void SetOnOffButtonAppearance(LabelControl ctrl, bool enabled)
        {
            if (enabled)
            {
                ctrl.BackColor = PrimaryBlack;
                ctrl.ForeColor = PrimaryWhite;
            }
            else
            {
                ctrl.BackColor = PrimaryWhite;
                ctrl.ForeColor = PrimaryGray;
            }
        }

        public static void SetOnOffGridViewLabelAppearance(TileViewItemElement ctrl, bool enabled)
        {
            ctrl.Appearance.Normal.ForeColor = enabled ? PrimaryWhite : PrimaryGray;
            ctrl.Appearance.Normal.BackColor = enabled ? PrimaryGold : PrimaryWhite;
        }

        public static void SetSimpleLabelStyle(AppearanceObject ctrl, bool enabled)
        {
            ctrl.ForeColor = enabled ? PrimaryGold : PrimaryBlack;
        }

        public static readonly int TrackGridSharedWidth = 295;
        public static readonly int TrackGridFullWidth = 600;
        public static readonly int ModifiedGridWidth = 295;
        public static readonly int TrackGridHeight = 350;
        public static readonly int LabelXLocation = 2;
        public static readonly int LabelYLocation = 28;
        public static readonly int GeneralLimitsSplitHorizonalStart = 305;
    }
}
