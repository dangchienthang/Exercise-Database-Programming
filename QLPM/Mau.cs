using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLPM
{
    public static class Mau
    {
        public static Color MauChinh { get; set; }
        public static Color MauPhu { get; set; }
        public static List<string> DSMau = new List<string>() { "#3F51B5",
                                                                    "#009688",
                                                                    "#FF5722",
                                                                    "#607D8B",
                                                                    "#FF9800",
                                                                    "#9C27B0",
                                                                    "#2196F3",
                                                                    "#EA676C",
                                                                    "#E41A4A",
                                                                    "#5978BB",
                                                                    "#018790",
                                                                    "#0E3441",
                                                                    "#00B0AD",
                                                                    "#721D47",
                                                                    "#EA4833",
                                                                    "#EF937E",
                                                                    "#F37521",
                                                                    "#A12059",
                                                                    "#126881",
                                                                    "#8BC240",
                                                                    "#364D5B",
                                                                    "#C7DC5B",
                                                                    "#0094BC",
                                                                    "#E4126B",
                                                                    "#43B76E",
                                                                    "#7BCFE9",
                                                                    "#B71C46"};

        public static Color ChinhDoSangMau(Color mau, double heso)
        {
            double maudo = mau.R;
            double xanhla = mau.G;
            double xanhduong = mau.B;
            //nếu hệ số hiệu chỉnh lớn hơn 0, hãy làm tối màu
            if (heso < 0)
            {
                heso = 1 + heso;
                maudo *= heso;
                xanhla *= heso;
                xanhduong *= heso;
            }
            //nếu hệ số hiệu chỉnh lớn hơn 0, hãy làm sáng màu.
            else
            {
                maudo = (255 - maudo) * heso + maudo;
                xanhla = (255 - xanhla) * heso + xanhla;
                xanhduong = (255 - xanhduong) * heso + xanhduong;
            }
            return Color.FromArgb(mau.A, (byte)maudo, (byte)xanhla, (byte)xanhduong);
        }
    }
}
