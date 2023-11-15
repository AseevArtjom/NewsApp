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
            list.AddNews(new News("Bellingham and Colwill withdraw from England squad", "Jude Bellingham and Levi Colwill have been forced to withdraw from the England squad for the upcoming Euro 2024 qualifiers against Malta and North Macedonia due to injury.\n Bellingham has suffered a minor hamstring injury, while Colwill is nursing a groin problem. Both players are expected to be out of action for a few weeks.", "https://e0.365dm.com/23/11/1600x900/skysports-england-football_6360142.jpg?20231114103015", "19.10.2023"));
            list.AddNews(new News("Hayes: Winning Champions League would be fairytale end at Chelsea", "Chelsea manager Emma Hayes has said that winning the Women's Champions League would be a fairytale end to her time at the club.\n Hayes has been in charge of Chelsea since 2012 and has led the club to two WSL titles, three FA Cups and two League Cups. However,\n the Women's Champions League is the one trophy that has eluded her. Hayes said: \"I think\n it would be a fairytale end to my time here. It would be a real achievement and it would put Chelsea on the map as one of the best clubs in the world.\"", "https://e0.365dm.com/23/11/1600x900/skysports-emma-hayes-chelsea_6355242.jpg?20231110164302", "19.10.2023"));
            list.AddNews(new News("Lyon 9-0 Slavia Prague: Ada Hegerberg hits milestone in Women's Champions League opener", "Ada Hegerberg scored her 60th Women's Champions League goal as Lyon opened their campaign with a nine-goal demolition of Slavia Prague.\r\n\r\nKadidiatou Diani and Vanessa Gilles scored two apiece as their dispirited hosts offered little in response.\r\n\r\nHegerberg's milestone goal came in only her 62nd Champions League appearance.\r\n\r\nThe Norwegian became the tournament's top scorer in 2019 when she broke the previous record of 51 held by Germany's Anja Mittag.\r\n\r\nSara Dabritz opened the scoring for eight-time champions Lyon inside three minutes before Danielle van de Donk poked in from close range to double their lead in Prague.\r\n\r\nFour headed goals before half-time followed - from Gilles, Eugenie le Sommer and Diani's double - as the Czechs struggled to deal with Lyon's aerial threat.\r\n\r\nAfter the break, Hegerberg converted from the penalty spot after she was pulled back in the area by Diana Bartovicova.\r\n\r\nAmel Majri made it eight with an easy finish from a Van de Donk ball, before Gilles headed in her second with 10 minutes remaining.\r\n\r\n\"I am really satisfied how we started off, with the result and with the way we performed tonight,\" said Sonia Bompastor, head coach of Division 1 Feminine leaders Lyon.\r\n\r\n\"Maybe we faced a less experienced team, but I am still proud of my side. We kept to our plan and scored a few beautiful goals. Despite the result, there are still things we might improve.\"\r\n\r\nLyon, who hold the record for Women's Champions League titles, next face Austrian side St Polten on 22 November.\r\n\r\nIn Tuesday's earlier Group B match, St Polten were beaten 2-1 by Brann on the Norwegian club's Champions League group stage debut.\r\n\r\nAfter a goalless first half, Rakel Engesvik opened the scoring for Brann before Maria Mikolajova equalised for St Polten with a stunning long-range effort.\r\n\r\nNatasha Anasi headed in Brann's winner 11 minutes from time with her first goal for the club.", "https://s.yimg.com/ny/api/res/1.2/KvsSPdEn3VVlelJ2rxR5TQ--/YXBwaWQ9aGlnaGxhbmRlcjt3PTk2MDtoPTU0MDtjZj13ZWJw/https://media.zenfs.com/en/bbc_us_articles_995/bbb63b6750bc956ecb33f6b4426539a8", "19.10.2023"));
            list.AddNews(new News("Hungary unhappy about relocation of Bulgaria game", "The Hungarian football federation has expressed its unhappiness with the Bulgarian football union after their Euro 2024 qualifier was moved from Sofia to Sliven.\n The Hungarian federation said that they would not \"organise a family holiday in this way\". The match will now be played at the Hadzhi Dimitar Stadium in Sliven.", "https://lh3.googleusercontent.com/7IWWMhOpkeMHs8CIW4GaeETsvNiVPv9KR_YxX_U8R6mcROQnGD9zWlckGJXEkj0KCIXAWLXQ2DeRZOjneALTcAd7EXRKu4W1biQRgQccLg=s1200", "19.10.2023"));
            list.AddNews(new News("Man United are mocked by rival fans that Old Trafford is falling down", "Manchester United fans have been mocked by rival fans after a video emerged showing parts of Old Trafford falling apart. The video, which was posted on social media, shows cracks in the walls and paint peeling off the ceiling. Rival fans have been quick to mock United, with some calling Old Trafford a \"dump\".\r\n\r\nThese are just a few of the top football headlines from around the world. For more news, please visit your favorite football website or social media platform.", "https://i.dailymail.co.uk/1s/2023/11/14/22/77802245-12749695-image-a-86_1699999530264.jpg", "19.10.2023"));
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
