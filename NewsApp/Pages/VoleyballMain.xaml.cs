using NewsApp.Navigator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewsApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для VoleyballMain.xaml
    /// </summary>
    public partial class VoleyballMain : UserControl
    {
        public VoleyballMain()
        {
            InitializeComponent();
        }

        private void OnGotFocusHandler(object sender, RoutedEventArgs e)
        {
            Button tb = e.Source as Button;
            tb.Background = Brushes.White;
            tb.Foreground = Brushes.Black;
        }
        // Raised when Button losses focus.
        // Changes the color of the Button back to white.
        private void OnLostFocusHandler(object sender, RoutedEventArgs e)
        {

            Button tb = e.Source as Button;
            tb.Background = Brushes.Black;
            tb.Foreground = Brushes.White;
        }

        private void Basketball_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new BasketballMain());
        }

        private void Football_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new FootballMain());
        }

        private void AllSports_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeMain());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeNews());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new ReligionMain());

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new TravelingMain());

        }
    }
}
