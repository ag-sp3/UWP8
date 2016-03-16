using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP8
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void btn_Shuffle_Click(object sender, RoutedEventArgs e)
        {
            //var color = Colors.YellowGreen;
            //var colors = Enum.GetNames(typeof(Colors));
            //var shuffledColors = colors.OrderBy(c => Guid.NewGuid()).Take(3).ToArray();

            var ColorNames = new Dictionary<Color, string>();
            foreach (var color in typeof(Colors).GetRuntimeProperties())
            {
                ColorNames[(Color)color.GetValue(null)] = color.Name;
            }



            var colors = typeof(Colors).GetRuntimeProperties().Select(c => (Color)c.GetValue(null));
            var shuffledColors = colors.OrderBy(p => Guid.NewGuid()).Take(3).ToArray();


            var color1 =  shuffledColors[0];
            rtg_R1.Fill = new SolidColorBrush(color1);
            tb_R1.Text = color1.ToString();
            tb_R11.Text = ColorNames[color1];

            var color2 = shuffledColors[1];
            rtg_R2.Fill = new SolidColorBrush(color2);
            tb_R2.Text = color2.ToString();
            tb_R12.Text = ColorNames[color2];

            var color3 = shuffledColors[2];
            rtg_R3.Fill = new SolidColorBrush(color3);
            tb_R3.Text = color3.ToString();
            tb_R13.Text = ColorNames[color3];





        }
    }
}
