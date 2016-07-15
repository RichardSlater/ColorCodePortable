using System.Linq;
using Xunit;

namespace ColorCode.Styling
{
    public class ColorFacts
    {
        [Fact]
        public void Empty_And_Empty_Are_Equal()
        {
            var lhs = Color.Empty;
            var rhs = Color.Empty;
            Assert.True(rhs == lhs);
        }

        [Fact]
        public void Empty_And_Null_Are_Equal()
        {
            var lhs = (Color) null;
            var rhs = Color.Empty;
            Assert.True(rhs == lhs);
        }

        [Fact]
        public void GetHashCode_Blue_Matches_Equal_Objects()
        {
            var lhs = Color.Blue;
            var rhs = new Color(0, 0, 255);
            Assert.Equal(lhs.GetHashCode(), rhs.GetHashCode());
        }

        [Fact]
        public void GetHashCode_Green_Matches_Equal_Objects()
        {
            var lhs = Color.DarkGreen;
            var rhs = new Color(0, 100, 0);
            Assert.Equal(lhs.GetHashCode(), rhs.GetHashCode());
        }

        [Fact]
        public void GetHashCode_Red_Matches_Equal_Objects()
        {
            var lhs = Color.Red;
            var rhs = new Color(255, 0, 0);
            Assert.Equal(lhs.GetHashCode(), rhs.GetHashCode());
        }

        [Fact]
        public void New_Color_Is_Opaque()
        {
            var color = new Color(127, 244, 133);
            Assert.Equal(255, color.Alpha);
        }

        [Fact]
        public void Null_And_Empty_Are_Equal()
        {
            var lhs = (Color) null;
            var rhs = Color.Empty;
            Assert.True(rhs == lhs);
        }

        [Fact]
        public void Two_Null_Colors_Are_Equal()
        {
            var lhs = (Color) null;
            var rhs = (Color) null;
            Assert.True(rhs == lhs);
        }

        [Fact]
        public void Will_Create_AliceBlue_HtmlColor()
        {
            var color = Color.AliceBlue;
            Assert.Equal(240, color.R);
            Assert.Equal(248, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_AntiqueWhite_HtmlColor()
        {
            var color = Color.AntiqueWhite;
            Assert.Equal(250, color.R);
            Assert.Equal(235, color.G);
            Assert.Equal(215, color.B);
        }

        [Fact]
        public void Will_Create_Aqua_HtmlColor()
        {
            var color = Color.Aqua;
            Assert.Equal(0, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_Aquamarine_HtmlColor()
        {
            var color = Color.Aquamarine;
            Assert.Equal(127, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(212, color.B);
        }

        [Fact]
        public void Will_Create_Azure_HtmlColor()
        {
            var color = Color.Azure;
            Assert.Equal(240, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_Beige_HtmlColor()
        {
            var color = Color.Beige;
            Assert.Equal(245, color.R);
            Assert.Equal(245, color.G);
            Assert.Equal(220, color.B);
        }

        [Fact]
        public void Will_Create_Bisque_HtmlColor()
        {
            var color = Color.Bisque;
            Assert.Equal(255, color.R);
            Assert.Equal(228, color.G);
            Assert.Equal(196, color.B);
        }

        [Fact]
        public void Will_Create_Black_HtmlColor()
        {
            var color = Color.Black;
            Assert.Equal(0, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_BlanchedAlmond_HtmlColor()
        {
            var color = Color.BlanchedAlmond;
            Assert.Equal(255, color.R);
            Assert.Equal(235, color.G);
            Assert.Equal(205, color.B);
        }

        [Fact]
        public void Will_Create_Blue_HtmlColor()
        {
            var color = Color.Blue;
            Assert.Equal(0, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_BlueViolet_HtmlColor()
        {
            var color = Color.BlueViolet;
            Assert.Equal(138, color.R);
            Assert.Equal(43, color.G);
            Assert.Equal(226, color.B);
        }

        [Fact]
        public void Will_Create_Brown_HtmlColor()
        {
            var color = Color.Brown;
            Assert.Equal(165, color.R);
            Assert.Equal(42, color.G);
            Assert.Equal(42, color.B);
        }

        [Fact]
        public void Will_Create_BurlyWood_HtmlColor()
        {
            var color = Color.BurlyWood;
            Assert.Equal(222, color.R);
            Assert.Equal(184, color.G);
            Assert.Equal(135, color.B);
        }

        [Fact]
        public void Will_Create_CadetBlue_HtmlColor()
        {
            var color = Color.CadetBlue;
            Assert.Equal(95, color.R);
            Assert.Equal(158, color.G);
            Assert.Equal(160, color.B);
        }

        [Fact]
        public void Will_Create_Chartreuse_HtmlColor()
        {
            var color = Color.Chartreuse;
            Assert.Equal(127, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_Chocolate_HtmlColor()
        {
            var color = Color.Chocolate;
            Assert.Equal(210, color.R);
            Assert.Equal(105, color.G);
            Assert.Equal(30, color.B);
        }

        [Fact]
        public void Will_Create_Coral_HtmlColor()
        {
            var color = Color.Coral;
            Assert.Equal(255, color.R);
            Assert.Equal(127, color.G);
            Assert.Equal(80, color.B);
        }

        [Fact]
        public void Will_Create_CornflowerBlue_HtmlColor()
        {
            var color = Color.CornflowerBlue;
            Assert.Equal(100, color.R);
            Assert.Equal(149, color.G);
            Assert.Equal(237, color.B);
        }

        [Fact]
        public void Will_Create_Cornsilk_HtmlColor()
        {
            var color = Color.Cornsilk;
            Assert.Equal(255, color.R);
            Assert.Equal(248, color.G);
            Assert.Equal(220, color.B);
        }

        [Fact]
        public void Will_Create_Crimson_HtmlColor()
        {
            var color = Color.Crimson;
            Assert.Equal(220, color.R);
            Assert.Equal(20, color.G);
            Assert.Equal(60, color.B);
        }

        [Fact]
        public void Will_Create_Cyan_HtmlColor()
        {
            var color = Color.Cyan;
            Assert.Equal(0, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_DarkBlue_HtmlColor()
        {
            var color = Color.DarkBlue;
            Assert.Equal(0, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(139, color.B);
        }

        [Fact]
        public void Will_Create_DarkCyan_HtmlColor()
        {
            var color = Color.DarkCyan;
            Assert.Equal(0, color.R);
            Assert.Equal(139, color.G);
            Assert.Equal(139, color.B);
        }

        [Fact]
        public void Will_Create_DarkGoldenrod_HtmlColor()
        {
            var color = Color.DarkGoldenrod;
            Assert.Equal(184, color.R);
            Assert.Equal(134, color.G);
            Assert.Equal(11, color.B);
        }

        [Fact]
        public void Will_Create_DarkGray_HtmlColor()
        {
            var color = Color.DarkGray;
            Assert.Equal(169, color.R);
            Assert.Equal(169, color.G);
            Assert.Equal(169, color.B);
        }

        [Fact]
        public void Will_Create_DarkGreen_HtmlColor()
        {
            var color = Color.DarkGreen;
            Assert.Equal(0, color.R);
            Assert.Equal(100, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_DarkGrey_HtmlColor()
        {
            var color = Color.DarkGrey;
            Assert.Equal(169, color.R);
            Assert.Equal(169, color.G);
            Assert.Equal(169, color.B);
        }

        [Fact]
        public void Will_Create_DarkKhaki_HtmlColor()
        {
            var color = Color.DarkKhaki;
            Assert.Equal(189, color.R);
            Assert.Equal(183, color.G);
            Assert.Equal(107, color.B);
        }

        [Fact]
        public void Will_Create_DarkMagenta_HtmlColor()
        {
            var color = Color.DarkMagenta;
            Assert.Equal(139, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(139, color.B);
        }

        [Fact]
        public void Will_Create_DarkOliveGreen_HtmlColor()
        {
            var color = Color.DarkOliveGreen;
            Assert.Equal(85, color.R);
            Assert.Equal(107, color.G);
            Assert.Equal(47, color.B);
        }

        [Fact]
        public void Will_Create_DarkOrange_HtmlColor()
        {
            var color = Color.DarkOrange;
            Assert.Equal(255, color.R);
            Assert.Equal(140, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_DarkOrchid_HtmlColor()
        {
            var color = Color.DarkOrchid;
            Assert.Equal(153, color.R);
            Assert.Equal(50, color.G);
            Assert.Equal(204, color.B);
        }

        [Fact]
        public void Will_Create_DarkRed_HtmlColor()
        {
            var color = Color.DarkRed;
            Assert.Equal(139, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_DarkSalmon_HtmlColor()
        {
            var color = Color.DarkSalmon;
            Assert.Equal(233, color.R);
            Assert.Equal(150, color.G);
            Assert.Equal(122, color.B);
        }

        [Fact]
        public void Will_Create_DarkSeaGreen_HtmlColor()
        {
            var color = Color.DarkSeaGreen;
            Assert.Equal(143, color.R);
            Assert.Equal(188, color.G);
            Assert.Equal(143, color.B);
        }

        [Fact]
        public void Will_Create_DarkSlateBlue_HtmlColor()
        {
            var color = Color.DarkSlateBlue;
            Assert.Equal(72, color.R);
            Assert.Equal(61, color.G);
            Assert.Equal(139, color.B);
        }

        [Fact]
        public void Will_Create_DarkSlateGray_HtmlColor()
        {
            var color = Color.DarkSlateGray;
            Assert.Equal(47, color.R);
            Assert.Equal(79, color.G);
            Assert.Equal(79, color.B);
        }

        [Fact]
        public void Will_Create_DarkSlateGrey_HtmlColor()
        {
            var color = Color.DarkSlateGrey;
            Assert.Equal(47, color.R);
            Assert.Equal(79, color.G);
            Assert.Equal(79, color.B);
        }

        [Fact]
        public void Will_Create_DarkTurquoise_HtmlColor()
        {
            var color = Color.DarkTurquoise;
            Assert.Equal(0, color.R);
            Assert.Equal(206, color.G);
            Assert.Equal(209, color.B);
        }

        [Fact]
        public void Will_Create_DarkViolet_HtmlColor()
        {
            var color = Color.DarkViolet;
            Assert.Equal(148, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(211, color.B);
        }

        [Fact]
        public void Will_Create_DeepPink_HtmlColor()
        {
            var color = Color.DeepPink;
            Assert.Equal(255, color.R);
            Assert.Equal(20, color.G);
            Assert.Equal(147, color.B);
        }

        [Fact]
        public void Will_Create_DeepSkyBlue_HtmlColor()
        {
            var color = Color.DeepSkyBlue;
            Assert.Equal(0, color.R);
            Assert.Equal(191, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_DimGray_HtmlColor()
        {
            var color = Color.DimGray;
            Assert.Equal(105, color.R);
            Assert.Equal(105, color.G);
            Assert.Equal(105, color.B);
        }

        [Fact]
        public void Will_Create_DimGrey_HtmlColor()
        {
            var color = Color.DimGrey;
            Assert.Equal(105, color.R);
            Assert.Equal(105, color.G);
            Assert.Equal(105, color.B);
        }

        [Fact]
        public void Will_Create_DodgerBlue_HtmlColor()
        {
            var color = Color.DodgerBlue;
            Assert.Equal(30, color.R);
            Assert.Equal(144, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_Empty_Color()
        {
            var color = Color.Empty;
            Assert.True(color == Color.Empty);
        }

        [Fact]
        public void Will_Create_Firebrick_HtmlColor()
        {
            var color = Color.Firebrick;
            Assert.Equal(178, color.R);
            Assert.Equal(34, color.G);
            Assert.Equal(34, color.B);
        }

        [Fact]
        public void Will_Create_FloralWhite_HtmlColor()
        {
            var color = Color.FloralWhite;
            Assert.Equal(255, color.R);
            Assert.Equal(250, color.G);
            Assert.Equal(240, color.B);
        }

        [Fact]
        public void Will_Create_ForestGreen_HtmlColor()
        {
            var color = Color.ForestGreen;
            Assert.Equal(34, color.R);
            Assert.Equal(139, color.G);
            Assert.Equal(34, color.B);
        }

        [Fact]
        public void Will_Create_Fuchsia_HtmlColor()
        {
            var color = Color.Fuchsia;
            Assert.Equal(255, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_Gainsboro_HtmlColor()
        {
            var color = Color.Gainsboro;
            Assert.Equal(220, color.R);
            Assert.Equal(220, color.G);
            Assert.Equal(220, color.B);
        }

        [Fact]
        public void Will_Create_GhostWhite_HtmlColor()
        {
            var color = Color.GhostWhite;
            Assert.Equal(248, color.R);
            Assert.Equal(248, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_Gold_HtmlColor()
        {
            var color = Color.Gold;
            Assert.Equal(255, color.R);
            Assert.Equal(215, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_Goldenrod_HtmlColor()
        {
            var color = Color.Goldenrod;
            Assert.Equal(218, color.R);
            Assert.Equal(165, color.G);
            Assert.Equal(32, color.B);
        }

        [Fact]
        public void Will_Create_Gray_HtmlColor()
        {
            var color = Color.Gray;
            Assert.Equal(128, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(128, color.B);
        }

        [Fact]
        public void Will_Create_Green_HtmlColor()
        {
            var color = Color.Green;
            Assert.Equal(0, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_GreenYellow_HtmlColor()
        {
            var color = Color.GreenYellow;
            Assert.Equal(173, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(47, color.B);
        }

        [Fact]
        public void Will_Create_Grey_HtmlColor()
        {
            var color = Color.Grey;
            Assert.Equal(128, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(128, color.B);
        }

        [Fact]
        public void Will_Create_Honeydew_HtmlColor()
        {
            var color = Color.Honeydew;
            Assert.Equal(240, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(240, color.B);
        }

        [Fact]
        public void Will_Create_HotPink_HtmlColor()
        {
            var color = Color.HotPink;
            Assert.Equal(255, color.R);
            Assert.Equal(105, color.G);
            Assert.Equal(180, color.B);
        }

        [Fact]
        public void Will_Create_IndianRed_HtmlColor()
        {
            var color = Color.IndianRed;
            Assert.Equal(205, color.R);
            Assert.Equal(92, color.G);
            Assert.Equal(92, color.B);
        }

        [Fact]
        public void Will_Create_Indigo_HtmlColor()
        {
            var color = Color.Indigo;
            Assert.Equal(75, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(130, color.B);
        }

        [Fact]
        public void Will_Create_Ivory_HtmlColor()
        {
            var color = Color.Ivory;
            Assert.Equal(255, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(240, color.B);
        }

        [Fact]
        public void Will_Create_Khaki_HtmlColor()
        {
            var color = Color.Khaki;
            Assert.Equal(240, color.R);
            Assert.Equal(230, color.G);
            Assert.Equal(140, color.B);
        }

        [Fact]
        public void Will_Create_Lavender_HtmlColor()
        {
            var color = Color.Lavender;
            Assert.Equal(230, color.R);
            Assert.Equal(230, color.G);
            Assert.Equal(250, color.B);
        }

        [Fact]
        public void Will_Create_LavenderBlush_HtmlColor()
        {
            var color = Color.LavenderBlush;
            Assert.Equal(255, color.R);
            Assert.Equal(240, color.G);
            Assert.Equal(245, color.B);
        }

        [Fact]
        public void Will_Create_LawnGreen_HtmlColor()
        {
            var color = Color.LawnGreen;
            Assert.Equal(124, color.R);
            Assert.Equal(252, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_LemonChiffon_HtmlColor()
        {
            var color = Color.LemonChiffon;
            Assert.Equal(255, color.R);
            Assert.Equal(250, color.G);
            Assert.Equal(205, color.B);
        }

        [Fact]
        public void Will_Create_LightBlue_HtmlColor()
        {
            var color = Color.LightBlue;
            Assert.Equal(173, color.R);
            Assert.Equal(216, color.G);
            Assert.Equal(230, color.B);
        }

        [Fact]
        public void Will_Create_LightCoral_HtmlColor()
        {
            var color = Color.LightCoral;
            Assert.Equal(240, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(128, color.B);
        }

        [Fact]
        public void Will_Create_LightCyan_HtmlColor()
        {
            var color = Color.LightCyan;
            Assert.Equal(224, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_LightGoldenrodYellow_HtmlColor()
        {
            var color = Color.LightGoldenrodYellow;
            Assert.Equal(250, color.R);
            Assert.Equal(250, color.G);
            Assert.Equal(210, color.B);
        }

        [Fact]
        public void Will_Create_LightGray_HtmlColor()
        {
            var color = Color.LightGray;
            Assert.Equal(211, color.R);
            Assert.Equal(211, color.G);
            Assert.Equal(211, color.B);
        }

        [Fact]
        public void Will_Create_LightGreen_HtmlColor()
        {
            var color = Color.LightGreen;
            Assert.Equal(144, color.R);
            Assert.Equal(238, color.G);
            Assert.Equal(144, color.B);
        }

        [Fact]
        public void Will_Create_LightGrey_HtmlColor()
        {
            var color = Color.LightGrey;
            Assert.Equal(211, color.R);
            Assert.Equal(211, color.G);
            Assert.Equal(211, color.B);
        }

        [Fact]
        public void Will_Create_LightPink_HtmlColor()
        {
            var color = Color.LightPink;
            Assert.Equal(255, color.R);
            Assert.Equal(182, color.G);
            Assert.Equal(193, color.B);
        }

        [Fact]
        public void Will_Create_LightSalmon_HtmlColor()
        {
            var color = Color.LightSalmon;
            Assert.Equal(255, color.R);
            Assert.Equal(160, color.G);
            Assert.Equal(122, color.B);
        }

        [Fact]
        public void Will_Create_LightSeaGreen_HtmlColor()
        {
            var color = Color.LightSeaGreen;
            Assert.Equal(32, color.R);
            Assert.Equal(178, color.G);
            Assert.Equal(170, color.B);
        }

        [Fact]
        public void Will_Create_LightSkyBlue_HtmlColor()
        {
            var color = Color.LightSkyBlue;
            Assert.Equal(135, color.R);
            Assert.Equal(206, color.G);
            Assert.Equal(250, color.B);
        }

        [Fact]
        public void Will_Create_LightSlateGray_HtmlColor()
        {
            var color = Color.LightSlateGray;
            Assert.Equal(119, color.R);
            Assert.Equal(136, color.G);
            Assert.Equal(153, color.B);
        }

        [Fact]
        public void Will_Create_LightSlateGrey_HtmlColor()
        {
            var color = Color.LightSlateGrey;
            Assert.Equal(119, color.R);
            Assert.Equal(136, color.G);
            Assert.Equal(153, color.B);
        }

        [Fact]
        public void Will_Create_LightSteelBlue_HtmlColor()
        {
            var color = Color.LightSteelBlue;
            Assert.Equal(176, color.R);
            Assert.Equal(196, color.G);
            Assert.Equal(222, color.B);
        }

        [Fact]
        public void Will_Create_LightYellow_HtmlColor()
        {
            var color = Color.LightYellow;
            Assert.Equal(255, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(224, color.B);
        }

        [Fact]
        public void Will_Create_Lime_HtmlColor()
        {
            var color = Color.Lime;
            Assert.Equal(0, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_LimeGreen_HtmlColor()
        {
            var color = Color.LimeGreen;
            Assert.Equal(50, color.R);
            Assert.Equal(205, color.G);
            Assert.Equal(50, color.B);
        }

        [Fact]
        public void Will_Create_Linen_HtmlColor()
        {
            var color = Color.Linen;
            Assert.Equal(250, color.R);
            Assert.Equal(240, color.G);
            Assert.Equal(230, color.B);
        }

        [Fact]
        public void Will_Create_Magenta_HtmlColor()
        {
            var color = Color.Magenta;
            Assert.Equal(255, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_Maroon_HtmlColor()
        {
            var color = Color.Maroon;
            Assert.Equal(128, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_MediumAquamarine_HtmlColor()
        {
            var color = Color.MediumAquamarine;
            Assert.Equal(102, color.R);
            Assert.Equal(205, color.G);
            Assert.Equal(170, color.B);
        }

        [Fact]
        public void Will_Create_MediumBlue_HtmlColor()
        {
            var color = Color.MediumBlue;
            Assert.Equal(0, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(205, color.B);
        }

        [Fact]
        public void Will_Create_MediumOrchid_HtmlColor()
        {
            var color = Color.MediumOrchid;
            Assert.Equal(186, color.R);
            Assert.Equal(85, color.G);
            Assert.Equal(211, color.B);
        }

        [Fact]
        public void Will_Create_MediumPurple_HtmlColor()
        {
            var color = Color.MediumPurple;
            Assert.Equal(147, color.R);
            Assert.Equal(112, color.G);
            Assert.Equal(219, color.B);
        }

        [Fact]
        public void Will_Create_MediumSeaGreen_HtmlColor()
        {
            var color = Color.MediumSeaGreen;
            Assert.Equal(60, color.R);
            Assert.Equal(179, color.G);
            Assert.Equal(113, color.B);
        }

        [Fact]
        public void Will_Create_MediumSlateBlue_HtmlColor()
        {
            var color = Color.MediumSlateBlue;
            Assert.Equal(123, color.R);
            Assert.Equal(104, color.G);
            Assert.Equal(238, color.B);
        }

        [Fact]
        public void Will_Create_MediumSpringGreen_HtmlColor()
        {
            var color = Color.MediumSpringGreen;
            Assert.Equal(0, color.R);
            Assert.Equal(250, color.G);
            Assert.Equal(154, color.B);
        }

        [Fact]
        public void Will_Create_MediumTurquoise_HtmlColor()
        {
            var color = Color.MediumTurquoise;
            Assert.Equal(72, color.R);
            Assert.Equal(209, color.G);
            Assert.Equal(204, color.B);
        }

        [Fact]
        public void Will_Create_MediumVioletRed_HtmlColor()
        {
            var color = Color.MediumVioletRed;
            Assert.Equal(199, color.R);
            Assert.Equal(21, color.G);
            Assert.Equal(133, color.B);
        }

        [Fact]
        public void Will_Create_MidnightBlue_HtmlColor()
        {
            var color = Color.MidnightBlue;
            Assert.Equal(25, color.R);
            Assert.Equal(25, color.G);
            Assert.Equal(112, color.B);
        }

        [Fact]
        public void Will_Create_MintCream_HtmlColor()
        {
            var color = Color.MintCream;
            Assert.Equal(245, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(250, color.B);
        }

        [Fact]
        public void Will_Create_MistyRose_HtmlColor()
        {
            var color = Color.MistyRose;
            Assert.Equal(255, color.R);
            Assert.Equal(228, color.G);
            Assert.Equal(225, color.B);
        }

        [Fact]
        public void Will_Create_Moccasin_HtmlColor()
        {
            var color = Color.Moccasin;
            Assert.Equal(255, color.R);
            Assert.Equal(228, color.G);
            Assert.Equal(181, color.B);
        }

        [Fact]
        public void Will_Create_NavajoWhite_HtmlColor()
        {
            var color = Color.NavajoWhite;
            Assert.Equal(255, color.R);
            Assert.Equal(222, color.G);
            Assert.Equal(173, color.B);
        }

        [Fact]
        public void Will_Create_Navy_HtmlColor()
        {
            var color = Color.Navy;
            Assert.Equal(0, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(128, color.B);
        }

        [Fact]
        public void Will_Create_OldLace_HtmlColor()
        {
            var color = Color.OldLace;
            Assert.Equal(253, color.R);
            Assert.Equal(245, color.G);
            Assert.Equal(230, color.B);
        }

        [Fact]
        public void Will_Create_Olive_HtmlColor()
        {
            var color = Color.Olive;
            Assert.Equal(128, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_OliveDrab_HtmlColor()
        {
            var color = Color.OliveDrab;
            Assert.Equal(107, color.R);
            Assert.Equal(142, color.G);
            Assert.Equal(35, color.B);
        }

        [Fact]
        public void Will_Create_Orange_HtmlColor()
        {
            var color = Color.Orange;
            Assert.Equal(255, color.R);
            Assert.Equal(165, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_OrangeRed_HtmlColor()
        {
            var color = Color.OrangeRed;
            Assert.Equal(255, color.R);
            Assert.Equal(69, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_Orchid_HtmlColor()
        {
            var color = Color.Orchid;
            Assert.Equal(218, color.R);
            Assert.Equal(112, color.G);
            Assert.Equal(214, color.B);
        }

        [Fact]
        public void Will_Create_PaleGoldenrod_HtmlColor()
        {
            var color = Color.PaleGoldenrod;
            Assert.Equal(238, color.R);
            Assert.Equal(232, color.G);
            Assert.Equal(170, color.B);
        }

        [Fact]
        public void Will_Create_PaleGreen_HtmlColor()
        {
            var color = Color.PaleGreen;
            Assert.Equal(152, color.R);
            Assert.Equal(251, color.G);
            Assert.Equal(152, color.B);
        }

        [Fact]
        public void Will_Create_PaleTurquoise_HtmlColor()
        {
            var color = Color.PaleTurquoise;
            Assert.Equal(175, color.R);
            Assert.Equal(238, color.G);
            Assert.Equal(238, color.B);
        }

        [Fact]
        public void Will_Create_PaleVioletRed_HtmlColor()
        {
            var color = Color.PaleVioletRed;
            Assert.Equal(219, color.R);
            Assert.Equal(112, color.G);
            Assert.Equal(147, color.B);
        }

        [Fact]
        public void Will_Create_PapayaWhip_HtmlColor()
        {
            var color = Color.PapayaWhip;
            Assert.Equal(255, color.R);
            Assert.Equal(239, color.G);
            Assert.Equal(213, color.B);
        }

        [Fact]
        public void Will_Create_PeachPuff_HtmlColor()
        {
            var color = Color.PeachPuff;
            Assert.Equal(255, color.R);
            Assert.Equal(218, color.G);
            Assert.Equal(185, color.B);
        }

        [Fact]
        public void Will_Create_Peru_HtmlColor()
        {
            var color = Color.Peru;
            Assert.Equal(205, color.R);
            Assert.Equal(133, color.G);
            Assert.Equal(63, color.B);
        }

        [Fact]
        public void Will_Create_Pink_HtmlColor()
        {
            var color = Color.Pink;
            Assert.Equal(255, color.R);
            Assert.Equal(192, color.G);
            Assert.Equal(203, color.B);
        }

        [Fact]
        public void Will_Create_Plum_HtmlColor()
        {
            var color = Color.Plum;
            Assert.Equal(221, color.R);
            Assert.Equal(160, color.G);
            Assert.Equal(221, color.B);
        }

        [Fact]
        public void Will_Create_PowderBlue_HtmlColor()
        {
            var color = Color.PowderBlue;
            Assert.Equal(176, color.R);
            Assert.Equal(224, color.G);
            Assert.Equal(230, color.B);
        }

        [Fact]
        public void Will_Create_Purple_HtmlColor()
        {
            var color = Color.Purple;
            Assert.Equal(128, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(128, color.B);
        }

        [Fact]
        public void Will_Create_RebeccaPurple_HtmlColor()
        {
            var color = Color.RebeccaPurple;
            Assert.Equal(102, color.R);
            Assert.Equal(51, color.G);
            Assert.Equal(153, color.B);
        }

        [Fact]
        public void Will_Create_Red_HtmlColor()
        {
            var color = Color.Red;
            Assert.Equal(255, color.R);
            Assert.Equal(0, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_RosyBrown_HtmlColor()
        {
            var color = Color.RosyBrown;
            Assert.Equal(188, color.R);
            Assert.Equal(143, color.G);
            Assert.Equal(143, color.B);
        }

        [Fact]
        public void Will_Create_RoyalBlue_HtmlColor()
        {
            var color = Color.RoyalBlue;
            Assert.Equal(65, color.R);
            Assert.Equal(105, color.G);
            Assert.Equal(225, color.B);
        }

        [Fact]
        public void Will_Create_SaddleBrown_HtmlColor()
        {
            var color = Color.SaddleBrown;
            Assert.Equal(139, color.R);
            Assert.Equal(69, color.G);
            Assert.Equal(19, color.B);
        }

        [Fact]
        public void Will_Create_Salmon_HtmlColor()
        {
            var color = Color.Salmon;
            Assert.Equal(250, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(114, color.B);
        }

        [Fact]
        public void Will_Create_SandyBrown_HtmlColor()
        {
            var color = Color.SandyBrown;
            Assert.Equal(244, color.R);
            Assert.Equal(164, color.G);
            Assert.Equal(96, color.B);
        }

        [Fact]
        public void Will_Create_SeaGreen_HtmlColor()
        {
            var color = Color.SeaGreen;
            Assert.Equal(46, color.R);
            Assert.Equal(139, color.G);
            Assert.Equal(87, color.B);
        }

        [Fact]
        public void Will_Create_SeaShell_HtmlColor()
        {
            var color = Color.SeaShell;
            Assert.Equal(255, color.R);
            Assert.Equal(245, color.G);
            Assert.Equal(238, color.B);
        }

        [Fact]
        public void Will_Create_Sienna_HtmlColor()
        {
            var color = Color.Sienna;
            Assert.Equal(160, color.R);
            Assert.Equal(82, color.G);
            Assert.Equal(45, color.B);
        }

        [Fact]
        public void Will_Create_Silver_HtmlColor()
        {
            var color = Color.Silver;
            Assert.Equal(192, color.R);
            Assert.Equal(192, color.G);
            Assert.Equal(192, color.B);
        }

        [Fact]
        public void Will_Create_SkyBlue_HtmlColor()
        {
            var color = Color.SkyBlue;
            Assert.Equal(135, color.R);
            Assert.Equal(206, color.G);
            Assert.Equal(235, color.B);
        }

        [Fact]
        public void Will_Create_SlateBlue_HtmlColor()
        {
            var color = Color.SlateBlue;
            Assert.Equal(106, color.R);
            Assert.Equal(90, color.G);
            Assert.Equal(205, color.B);
        }

        [Fact]
        public void Will_Create_SlateGray_HtmlColor()
        {
            var color = Color.SlateGray;
            Assert.Equal(112, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(144, color.B);
        }

        [Fact]
        public void Will_Create_SlateGrey_HtmlColor()
        {
            var color = Color.SlateGrey;
            Assert.Equal(112, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(144, color.B);
        }

        [Fact]
        public void Will_Create_Snow_HtmlColor()
        {
            var color = Color.Snow;
            Assert.Equal(255, color.R);
            Assert.Equal(250, color.G);
            Assert.Equal(250, color.B);
        }

        [Fact]
        public void Will_Create_SpringGreen_HtmlColor()
        {
            var color = Color.SpringGreen;
            Assert.Equal(0, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(127, color.B);
        }

        [Fact]
        public void Will_Create_SteelBlue_HtmlColor()
        {
            var color = Color.SteelBlue;
            Assert.Equal(70, color.R);
            Assert.Equal(130, color.G);
            Assert.Equal(180, color.B);
        }

        [Fact]
        public void Will_Create_Tan_HtmlColor()
        {
            var color = Color.Tan;
            Assert.Equal(210, color.R);
            Assert.Equal(180, color.G);
            Assert.Equal(140, color.B);
        }

        [Fact]
        public void Will_Create_Teal_HtmlColor()
        {
            var color = Color.Teal;
            Assert.Equal(0, color.R);
            Assert.Equal(128, color.G);
            Assert.Equal(128, color.B);
        }

        [Fact]
        public void Will_Create_Thistle_HtmlColor()
        {
            var color = Color.Thistle;
            Assert.Equal(216, color.R);
            Assert.Equal(191, color.G);
            Assert.Equal(216, color.B);
        }

        [Fact]
        public void Will_Create_Tomato_HtmlColor()
        {
            var color = Color.Tomato;
            Assert.Equal(255, color.R);
            Assert.Equal(99, color.G);
            Assert.Equal(71, color.B);
        }

        [Fact]
        public void Will_Create_Turquoise_HtmlColor()
        {
            var color = Color.Turquoise;
            Assert.Equal(64, color.R);
            Assert.Equal(224, color.G);
            Assert.Equal(208, color.B);
        }

        [Fact]
        public void Will_Create_Violet_HtmlColor()
        {
            var color = Color.Violet;
            Assert.Equal(238, color.R);
            Assert.Equal(130, color.G);
            Assert.Equal(238, color.B);
        }

        [Fact]
        public void Will_Create_Wheat_HtmlColor()
        {
            var color = Color.Wheat;
            Assert.Equal(245, color.R);
            Assert.Equal(222, color.G);
            Assert.Equal(179, color.B);
        }

        [Fact]
        public void Will_Create_White_HtmlColor()
        {
            var color = Color.White;
            Assert.Equal(255, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(255, color.B);
        }

        [Fact]
        public void Will_Create_WhiteSmoke_HtmlColor()
        {
            var color = Color.WhiteSmoke;
            Assert.Equal(245, color.R);
            Assert.Equal(245, color.G);
            Assert.Equal(245, color.B);
        }

        [Fact]
        public void Will_Create_Yellow_HtmlColor()
        {
            var color = Color.Yellow;
            Assert.Equal(255, color.R);
            Assert.Equal(255, color.G);
            Assert.Equal(0, color.B);
        }

        [Fact]
        public void Will_Create_YellowGreen_HtmlColor()
        {
            var color = Color.YellowGreen;
            Assert.Equal(154, color.R);
            Assert.Equal(205, color.G);
            Assert.Equal(50, color.B);
        }

        [Fact]
        public void Will_Enumerate_All_Colors()
        {
            Assert.Equal(148, Color.All.Count());
        }

        [Fact]
        public void Will_Equal_Same_Color()
        {
            var lhs = new Color(123, 111, 222);
            var rhs = new Color(123, 111, 222);
            Assert.True(lhs.Equals(rhs));
        }      
    }
}