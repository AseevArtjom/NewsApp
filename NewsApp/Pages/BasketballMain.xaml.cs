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
    /// Логика взаимодействия для BasketballMain.xaml
    /// </summary>
    public partial class BasketballMain : UserControl
    {
        NewsList list;

        public BasketballMain()
        {
            InitializeComponent();
            list = new NewsList();
            list.AddNews(new News("Kamilla Cardoso headlines season's first women's basketball starting five of the week", "South Carolina senior center Kamilla Cardoso figured prominently in the Gamecocks’ two top-15 victories that opened the season and propelled them to the No. 1 position in the latest Associated\n Press Top 25 poll.\r\n \r\nCardoso was the Gamecocks’ top scorer and rebounder as they opened the season with a scoring margin of +33.5 in wins scored over No. 10 Notre Dame (100-71) and No. 14 Maryland (114-76).\n Cardoso averaged a double-double for the week, shooting 66.7 percent from the field.\r\n \r\nIn the season opener against Notre Dame on Nov. 6 in Paris, Cardoso turned in the program’s first 20-point, 15-rebound effort since Aliyah Boston surpassed those marks in the 2022 NCAA Women’s\n Final Four game against Louisville. Cardoso, who also blocked four shots in the game, pulled down 10 of her 15 boards in the first half, including eight in the second quarter as the Gamecocks \ndominated the period 24-8. She scored 13 of her 20 points in the third quarter, including eight in the first four minutes of the period.\r\n \r\nIn the Gamecocks’ home opener against Maryland, Cardoso was a steadying force on the inside with 12 points to keep the defense in the lane for the Gamecocks’ 3-point shooters. South Carolina (2-0)\n had seven players in double figures. The 114 points scored against the Terrapins marked the most points scored against a ranked opponent in program history (previously 104 against Arkansas on Jan.\n 18, 2021).", "https://www.ncaa.com/_flysystem/public-s3/styles/original/public-s3/images/2023-11-14/Kamilla-Cardoso.jpg?itok=Zek4PCTa", "15.11.2023"));
            list.AddNews(new News("AP men’s basketball Top 25: Michigan State, Duke tumble after rough opening-week losses", "We’re just a week into the college basketball season and already there are two major upsets in the books — though that’s tame compared to the women’s side.\r\n\r\nBoth Michigan State and Duke lost in the opening week of the 2023-24 season, which shook up the top five significantly. James Madison pulled off a second wild win late last week, too, \nand Saint Mary’s may be in trouble already.\r\n\r\nHere’s everything you missed in Week 1 of the season, and the latest Associated Press men’s basketball poll.", "https://s.yimg.com/ny/api/res/1.2/1uMA38rqpsjc9Dbsk3RC7A--/YXBwaWQ9aGlnaGxhbmRlcjt3PTk2MDtoPTY0MDtjZj13ZWJw/https://s.yimg.com/os/creatr-uploaded-images/2023-11/1d206420-81e5-11ee-a4de-8c6f395b44f9", "15.11.2023"));
            list.AddNews(new News("Warriors-Timberwolves fight: Draymond Green must be suspended for putting Rudy Gobert in a WWE chokehold", "Draymond Green is a certified hothead. Everyone knows this. He gets to pass off a lot of his antics as the almost romantic cost of a fierce competitor, but that's a copout.\n The guy seems borderline obsessed with letting the basketball world know, at every possible opportunity, just how tough he is. \r\n\r\nHe did it again Tuesday night, making a fight he had nothing to do with all about him as he put Timberwolves center Rudy Gobert into a full-on WWE chokehold and dragged him away from \nthe scene like the hero he likes to think he is. ", "https://sportshub.cbsistatic.com/i/r/2023/11/15/c76a18e4-727d-4b8f-ade4-19fa764e123e/thumbnail/770x433/d2706ddaa2c7be4674b7bc9de5948e0f/draymond-getty-1.png", "15.11.2023"));
            list.AddNews(new News("NBA considering expansion to Canada and Mexico", "The NBA is considering expansion into Canada and Mexico. The league has already held discussions with several potential franchise owners in these countries.\r\n\r\nOne possible option is to locate the franchise in Toronto, Canada. Toronto is already home to the NHL team the Toronto Maple Leafs, and the city has a large basketball fan base.\r\n\r\nAnother possible option is to locate the franchise in Mexico City, Mexico. Mexico City is the second largest city in North America, and it also has a large basketball fan base.\r\n\r\nThe NBA has not made a final decision on expansion into Canada or Mexico. However, the league said it is considering these options seriously.", "https://images.sidearmdev.com/resize?url=https%3a%2f%2fdbukjj6eu5tsf.cloudfront.net%2fncaa.org%2fimages%2f2023%2f3%2f30%2fMBB-WBB_BallHoop.JPG&width=942&type=jpeg", "15.11.2023"));
            list.AddNews(new News("Draymond Green was ejected from the court for choking Rudy Gobert", "Draymond Green was ejected from the court during the game between the Golden State Warriors and the Minnesota Timberwolves for using a choke on Rudy Gobert.\r\n\r\nThe incident occurred in the fourth quarter of the match when Green and Gobert collided for a rebound. Green grabbed Gobert's neck and began to choke him.\n The referee immediately sent Green off the court.\r\n\r\nAs a result of the deletion, Golden State lost the match with a score of 119-116.", "https://img.championat.com/s/735x490/news/big/i/g/drejmond-grin-byl-udalyon-s-ploschadki-za-to-chto-primenil-udushayuschij-na-rudi-gobere_17000214431544300199.jpg", "15.11.2023"));
            list.AddNews(new News("Egor Demin is second in the Eurohopes ranking among players born in 2006", "17-year-old Russian basketball player Egor Demin took second place in the Eurohopes ranking among players born in 2006.\r\n\r\nDemin plays for the CSKA-Moscow youth team. He averaged 13.9 points, 7.1 rebounds and 1.9 assists per game this season.\r\n\r\nDemin is one of the most promising young basketball players in Russia. He is already attracting the attention of foreign clubs, including the NBA.", "https://blog.nasm.org/hubfs/Training%20Basketball%20Players-1.jpg", "15.11.2023"));
            LVNews.ItemsSource = list.ListNews;
        }
        private void WrapPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            var news = (sender as StackPanel).DataContext as News;
            NavigatorObject.Switch(new NewsScreen(news.Titel, news.Description, news.Photo, news.Date));
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

        private void Voleyball_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new VoleyballMain());
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
