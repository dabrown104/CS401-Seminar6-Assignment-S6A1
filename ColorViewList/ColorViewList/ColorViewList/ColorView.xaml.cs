using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ColorViewList
{
    public partial class ColorView : ContentView
    {
        string colorName;
        ColorTypeConverter converter = new ColorTypeConverter();

        public ColorView()
        {
            InitializeComponent();
        }

        public string ColorName
        {
            set
            {
                colorName = value;
                colorNameLabel.Text = value;

                Color color = (Color)converter.ConvertFrom(colorName);
                boxView.Color = color;
                colorValueLabel.Text = String.Format("{0:X2} = {1:X2} = {2:X2}",
                                                    (int)(255 * color.R),
                                                    (int)(255 * color.G),
                                                    (int)(255 * color.B));
            }
            get
            {
                return colorName;
            }
        }
    }
}
