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
    /// <summary>
    /// Логика взаимодействия для ReligionMain.xaml
    /// </summary>
    public partial class ReligionMain : UserControl
    {
        NewsList list;
        public ReligionMain()
        {
            InitializeComponent();
            list = new NewsList();
            list.AddNews(new News("Pope Francis urges world leaders to take action on climate change", "Pope Francis has urged world leaders to take action on climate change, calling it a \"grave threat\" to the planet and its people.\n In a speech to world leaders at the United Nations climate summit in Glasgow, Scotland,\n the Pope said that the world is facing a \"moment of crisis\" and that it is time to \"act decisively\" to protect the planet. He called for a \"radical transformation\" of the global economy,\n saying that we need to move away from fossil fuels and invest in renewable energy sources.", "https://deshika.files.wordpress.com/2007/04/1.jpg", "15.11.2023"));
            list.AddNews(new News("Archbishop of Canterbury calls for unity in divided world", "The Archbishop of Canterbury, Justin Welby, has called for unity in a divided world. In a speech to the General Assembly of the Church of England,\n the Archbishop said that the world is facing a \"crisis of division\" and that it is time to \"come together\" and find common ground.\n He called for a \"new era of cooperation\" and said that we need to \"work together to build a better future for all\".", "https://upload.wikimedia.org/wikipedia/commons/1/12/Official_portrait_of_The_Lord_Archbishop_of_Canterbury.jpg", "15.11.2023"));
            list.AddNews(new News("Muslim leaders condemn violence against women", "Muslim leaders have condemned violence against women, calling it \"un-Islamic\". In a statement issued by the Federation of Islamic Organisations in Europe,\n the leaders said that violence against women is \"never justified\" and that it is a \"violation of Islamic law\".\n They called on all Muslims to \"speak out against violence against women\" and to do everything they can to protect women from harm.", "https://www.newarab.com/sites/default/files/media/images/B767CF4A-4BC3-43F0-8D47-A79C9AA531E2.jpg", "15.11.2023"));
            list.AddNews(new News("Jewish community in Germany celebrates Hanukkah", "The Jewish community in Germany is celebrating Hanukkah this year with a series of events and activities.\n Hanukkah is an eight-day Jewish holiday that celebrates the rededication of the Second Temple in Jerusalem in 164 BCE.\n The holiday is marked by the lighting of the menorah, a candelabra with nine branches.\r\n\r\n", "https://m.media-amazon.com/images/I/81xWaoC89rL._AC_SX679_.jpg", "15.11.2023"));
            list.AddNews(new News("Dalai Lama calls for compassion and understanding in times of conflict", "The Dalai Lama has called for compassion and understanding in times of conflict. In a speech to a peace conference in India,\n the Dalai Lama said that violence is \"never the answer\" and that we need to find ways to resolve our differences through dialogue and peaceful means.\n He called for a \"global movement of compassion\" and said that we need to \"learn to live together in peace and harmony\".", "https://upload.wikimedia.org/wikipedia/commons/3/30/Dalai_Lama_in_2012_02.jpg", "15.11.2023"));
            list.AddNews(new News("Religious leaders call for peace in Ukraine", "Religious leaders from around the world have called for peace in Ukraine and an end to the war that has been raging there since February 2022.\n In a joint statement, the leaders said that they are “deeply saddened and concerned by the ongoing conflict in Ukraine” and that they are “united in our call for an immediate cessation of hostilities”.\r\n\r\nThe statement was signed by the heads of the Catholic Church, the Orthodox Church,\n the World Council of Churches, the Lutheran World Federation, the World Jewish Congress, and the Islamic Council for North America.\n The leaders called for a “diplomatic solution” to the conflict and urged all parties involved to “lay down their weapons and engage in dialogue”.\r\n\r\n“We pray for the victims of this conflict and for all those who are suffering as a result of it,” the statement said. “We also pray for the leaders of both sides,\n that they will find the wisdom and courage to choose peace over war.”\r\n\r\nThe call for peace from religious leaders comes as the war in Ukraine enters its 11th month. The conflict has caused a humanitarian crisis in the country, with millions of people displaced from their homes.\n The war has also had a significant impact on the global economy, causing energy prices to soar and disrupting supply chains.\r\n\r\nIn addition to calling for peace, religious leaders have also been providing humanitarian aid to the victims of the war. The Catholic Church, for example, has donated millions of dollars in aid to Ukraine.\n The Orthodox Church has also been providing food, shelter, and medical care to refugees.\r\n\r\nThe call for peace from religious leaders is a powerful reminder that we must all work together to end this war and bring peace to Ukraine.", "https://www.lpj.org/cached_uploads/resize/635/576/2022/03/21/dsc-0176-jpg-1647870096.jpg?_mhk=c2e9435cf68dfd5e96", "15.11.2023"));
            LVNews.ItemsSource = list.ListNews;

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
        private void WrapPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var news = (sender as StackPanel).DataContext as News;
            NavigatorObject.Switch(new NewsScreen(news.Titel, news.Description, news.Photo, news.Date));
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeNews());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new TravelingMain());

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeMain());
        }
    }
}
