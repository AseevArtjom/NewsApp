using NewsApp.Domain;
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

    public partial class FootballMain : UserControl
    {
        NewsList list;

        public FootballMain()
        {
            InitializeComponent();
            list = new NewsList();
            list.AddNews(new News("EURO 2024", "The national team of Ukraine defeated the national team of Malta in the qualification for the European Championship 2024 with a score of 2:1", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLndt9o-5VSDibcMTkmE7g6CBFIvDwuBe5qg&usqp=CAU", "19.10.2023"));
            list.AddNews(new News("NEWS", "Important news", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLndt9o-5VSDibcMTkmE7g6CBFIvDwuBe5qg&usqp=CAU", "19.10.2023"));
            list.AddNews(new News("NEWS", "Important news", "", "19.10.2023"));
            list.AddNews(new News("NEWS", "Important news", "", "19.10.2023"));
            list.AddNews(new News("NEWS", "Important news", "", "19.10.2023"));
            list.AddNews(new News("NEWS", "Important news", "", "19.10.2023"));
            LVNews.ItemsSource = list.ListNews;
        }

        private void WrapPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var news = (sender as StackPanel).DataContext as News;
            NavigatorObject.Switch(new NewsScreen(news.Titel,news.Description,news.Photo,news.Date));
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

        private void Voleyball_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new VoleyballMain());
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
