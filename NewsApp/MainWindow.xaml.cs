using NewsApp.Domain;
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

namespace NewsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewsList list;
        public MainWindow()
        {
            InitializeComponent();
            list = new NewsList();
            list.AddNews(new News("NEWS", "Important news", "", "19.10.2023"));
            list.AddNews(new News("NEWS", "Important news", "", "19.10.2023"));
            LVNews.ItemsSource = list.ListNews;
        }

        private void LVNews_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 NewsWindow = new Window1();
            NewsWindow.ShowDialog();
        }
        private void ShowLoginPopup(object sender, RoutedEventArgs e)
        {
            if(LoginPopup.IsOpen)
            {
                LoginPopup.IsOpen = false;
            }
            else
            {
                LoginPopup.IsOpen = true;
            }
        }

        private void OnGotFocusHandler(object sender, MouseEventArgs e)
        {
            Button tb = e.Source as Button;
            tb.Background = Brushes.White;
            tb.Foreground = Brushes.Black;
        }

        private void OnLostFocusHandler(object sender, MouseEventArgs e)
        {
            Button tb = e.Source as Button;
            tb.Background = Brushes.Black;
            tb.Foreground = Brushes.White;
        }
    }
}
