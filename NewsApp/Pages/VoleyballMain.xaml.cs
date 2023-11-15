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
    /// Логика взаимодействия для VoleyballMain.xaml
    /// </summary>
    public partial class VoleyballMain : UserControl
    {
        NewsList list;
        public VoleyballMain()
        {
            InitializeComponent();
            list = new NewsList();
            list.AddNews(new News("Luciano De Cecco: A leader of few words and many victories", "In a recent interview with VBTV, American star setter Micah Christenson described his Argentinean counterpart Luciano De Cecco by saying that\n “nobody can try to be Luciano De Cecco because he’s individually himself.”\nAlthough Micah’s comments made a reference to De Cecco’s playing style, which make of him a truly unique player in the position, they also perfect summarize another intriguing facet of \nthe Olympic medalist – his leadership.\r\n\r\nCaptaining the Argentinean national team since 2015, the 35-year-old De Cecco has been exposed to all kinds of leadership styles over his almost 20 years of professional volleyball and still, \njust like he does with his playmaking duties, he just opted to be himself.\r\n\r\n“I think that when someone is a good leader, it just shows, it’s not something you can really develop if you don’t have that on you,” he told Volleyball World. “There’s a lot of different forms to lead \nand there’s no right or wrong. Each leader has its own way of doing things and each of them works in a different way.”", "https://images.volleyballworld.com/image/private/t_editorial_landscape_12_desktop/f_auto/fivb-prd/wtuzypnpcsdxpzry4hc4.jpg", "15.11.2023"));
            list.AddNews(new News("Facts you should know about the Club World Champs", "There are still two major events left in the 2023 international volleyball calendar and they will both take place in Asia in December – the F\r\n\r\nThere are still two major events left in the 2023 international volleyball calendar and they will both take place in Asia in December – the Men’s and Women’s Club World Championships.\r\n\r\nThe men will play first, in Bengaluru, India, from December 6-10, while the women will get on the court one week later, from 13-17, in Hangzhou, China. \nBoth events will be streamed live for VBTV subscribers around the world.\r\n\r\nWatch the 2023 FIVB Volleyball Club World Championships live on VBTV\r\nClub teams from seven different countries and some of the best players in the world will be in action and as you start getting ready to follow them, here are a few bites of information that will help you \nbuild your knowledge ahead of the tournaments.", "https://images.volleyballworld.com/image/private/t_editorial_landscape_12_desktop/f_auto/v1700004553/fivb-prd/lytkqkuqs891ntfbp43r.jpg", "15.11.2023"));
            list.AddNews(new News("Suntory Sunbirds win Japan’s first Asian men’s club crown", "Suntory Sunbirds Osaka became the first-ever Japanese club to win the Asian Men’s Club Volleyball Championship on Sunday and earned the right to represent their continent at the 2023 FIVB Volleyball Men’s Club World Championship in India. Grupa Azoty ZAKSA Kedzierzyn-Kozle defeated Jastrzebski Wegiel Jastrzebie-Zdroj in Saturday’s all-Polish final of the CEV Champions League, as both teams qualified to represent Europe at the Club World Champs in December.\nSuntory have never played at the Club World Championships before. In fact, Japan has been represented at the competition by different clubs only three times, at the first two editions in 1989 and 1990,\n and most recently, by Panasonic Panthers Hirakata in 2013. In Sunday’s final of the continental championship, held over eight days in Manama, Bahrain, the club from Osaka produced a 3-1\n (28-26, 25-23, 23-25, 25-17) victory over Indonesia’s Jakarta Bhayangkara Presisi, with a 31-point match high from Russian super star Dmitriy Muserskiy, and became the first non-Iranian team\n to win the competition since 2015. The Iranian streak saw its end the previous day, when Suntory delivered a 3-1 (25-22, 23-25, 34-32, 25-17) upset of Shahdab Yazd to knock the Iranian champions\n out of contention for the title. Qatar’s Police Doha also stunned Shahdab by 3-1 (24-26, 25-16, 25-20, 25-19) in the third place match to win the bronze.\r\n\r\nMuserskiy was named the competition’s Most Valuable Player (MVP). Setter Makasi Oya (Suntory Sunbirds), opposite Amir Ghafour (Shahdab), outside hitters Alain Junior de Armas\n (Suntory Sunbirds) and Mohammadjavad Manavinezhad (Jakarta Bhayangkara), middle blockers Belal Nabel Abunabot (Police) and Hendra Kurniawan (Jakarta Bhayangkara), and libero \nFahreza Rakha Abhinaya (Jakarta Bhayangkara) made up the tournament’s Dream Team.", "https://images.volleyballworld.com/image/upload/t_editorial_landscape_12_desktop/f_auto/fivb-prd/hfhyubkvupl9n490az0r.jpg", "15.11.2023"));
            list.AddNews(new News("For the first time ever, the Volleyball Club World Championships are coming to India!", "Volleyball World and FIVB today announce India as the host nation for the Men’s Club World Championships for two years in partnership with the RuPay Prime Volleyball League, India’s top \nprofessional volleyball league. As the host nation, the winners of the RuPay Prime Volleyball League in 2023 and 2024 will represent India in the tournament, where they will face fierce\n competition against established clubs from the top volleyball nations from around the globe like Italy, Brazil, Iran etc.\r\n\r\nThe Club World Championships will be exclusively marketed in India by India’s leading sports marketing firm, Baseline Ventures, who are also founding Partners of the Prime Volleyball League.\r\n\r\nThe championships will be staged between December 6 and 10, 2023. The host city will be announced later this year.\r\n\r\nThe tournament brings the best of international volleyball to India, where the sport is seeing a meteoric rise since the commencement of the RuPay Prime Volleyball League in 2022.\n Season 1 of the league saw a cumulative TV viewership of 133 million in India alone and managed to reach over 84 million fans on digital platforms.\r\n\r\nFor over 20 years, the Volleyball Club World Championships have featured the best men’s professional clubs from around the world, competing for the title of World Champions and a share of over USD 350,000 in prize money.", "https://images.volleyballworld.com/image/private/t_editorial_landscape_12_desktop/f_auto/fivb-prd/xro6qpr3474kaihwy6fs.jpg", "15.11.2023"));
            list.AddNews(new News("Calumet dominates inaugural All-UP volleyball honors", "MARQUETTE — For the first time in its 70-plus-year history, the Upper Peninsula Sportswriters and Sportscasters Association has chosen to select and honor the U.P.’s best high school volleyball players.\n Awards were divided between Division 1-3 teams and players and Division 4 teams and players.\r\n\r\nIn Division 1-3 nominees, Calumet coach Kate Bonacorsi was named Coach of the Year. She just led the Copper Kings (19-2) to their fourth consecutive regional title in MHSAA Division 3 play.\r\n\r\nThe Copper Kings were appropriately named the Division 1-3 Team of the Year, and several players\n from the team received top honors. Among them were Laina Kariniemi and Allie Bjorn,\n who were named to the Dream Team.\r\n\r\nEarning spots on the Division 1-3 First Team were Houghton’s Brynn Arko, Hancock’s Brielle Kero and Brooke Koskela, Kaeda Rajala, of Jeffers, and Calumet’s Jackie Kiilunen.\r\n\r\nOn the Division 1-3 Second Team, Jeffers’ Sara Johnson, Houghton’s Clea Ollanketo and Laney Johnson, as well as Calumet’s Caitlyn Strom and Maddie Torola all received honors.\r\n\r\nMaddy Kreider, of Kingsford, was named Ms. Volleyball. The Divison 1-3 Offensive Player of\n the Year was Ella Schuetter, of Manistique. Maddy Kreider, of Kingsford, was named Defensive Player of the Year.", "https://ogden_images.s3.amazonaws.com/www.mininggazette.com/images/2023/11/14160849/11-15-VB-All-UP-honors.jpg", "15.11.2023"));
            list.AddNews(new News("Vanier Spirits crowned city volleyball champs", "The Vanier Spirits senior girls volleyball team is once again city champions in the Moose Jaw High School Athletic Association (MJHSAA) after a hard-fought three sets to two victory over the Peacock \nToilers Tuesday night at Sask Polytech.\nVanier's last city championship was back in 2018.\r\n\r\nIt looked like the Spirits would have an easy time with the Toilers after winning the first set 25-9. But Peacock bounced back in the second set, taking it by a score 25-17.\n Vanier would take a two sets-to-one lead after a 25-20 win in the third, with Peacock once again rebounding with a 25-23 come-from-behind victory in the fourth set.\n Vanier took control early in the fifth and final set and went on to win the tie-breaker 15-8.\r\n\r\n\"It was intense, it was exciting,\" said Spirits head coach Aly Bell. \"Peacock came to play. We weren't expecting any less from them. We had some ups and downs but eventually,\n we found it again and we came out on top which was awesome. \nVanier hasn't won a city championship in a very long time. It's nice to put the school on the map again.\"", "https://dht7q8fif4gks.cloudfront.net/2023-11/VANIER.jpg", "15.11.2023"));
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
