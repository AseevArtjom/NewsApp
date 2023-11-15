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
    /// Логика взаимодействия для TravelingMain.xaml
    /// </summary>
    public partial class TravelingMain : UserControl
    {
        NewsList list;
        public TravelingMain()
        {
            InitializeComponent();
            list = new NewsList();
            list.AddNews(new News("This US-based couple bought a cheap apartment in France to give their kids a different upbringing", "CNN\r\n — \r\nSplashing out an apartment in the south of France and renovating it yourself may sound like a difficult – and hugely expensive – task.\nBut this couple have managed to do it twice, all while on a relatively tight budget.\nEric Freeze, originally from Canada, and his wife Rixa, from the US, spent several summers in the region as part of a study abroad program when they were in their 20s, \nand always felt a strong attachment to Nice.\r\n\r\nBut the pair, who married in 1998, began seriously looking into purchasing a property in the city after having their four children, Zari, 16, Dio, 14, Inga, 12, and Ivy, 10.\r\n\r\nIn 2014, they asked a realtor to look for a suitable property for the whole family in Old Nice, a historic neighborhood filled with tenements, churches, and squares.", "https://media.cnn.com/api/v1/images/stellar/prod/230904132853-02-communist-party-nice-fr-apartment-cnn-travel.jpg?c=16x9&q=h_720,w_1280,c_fill/f_webp", "15.11.2023"));
            list.AddNews(new News("One of Japan’s most elegant hotels is actually a treehouse", "CNN — Some little kids dream of building a treehouse. But one Japanese man turned his childhood dream into an adult reality.\r\n\r\nGrowing up in Tokyo, Satoru Kikugawa frequently visited the family summer home in the countryside, where he learned to appreciate nature. A Japanese children’s book called “I Want a Big Tree” sparked\n the dream of having a treehouse one day.\nHowever, it wasn’t until decades later that a family trip to Borneo brought urgency and the push to make that dream a reality.\r\n\r\nAs Kikugawa explains it, he was flying over the island when he saw a large forest cut down and turned into a palm plantation.\r\n\r\n“I understand economically that selling lumber brings a stable income, but this impacts carbon levels and the diversity in wildlife. So I thought about how we can save the environment that can still provide\n income for the locals,” says Kikugawa.\nIt was the first seed of what is now Treeful, an upscale resort in Okinawa prefecture.", "https://media.cnn.com/api/v1/images/stellar/prod/spiral-p1015508v2.jpg?c=original", "15.11.2023"));
            list.AddNews(new News("Thanksgiving travel predicted to be busy on the roads and record-setting in the skies", "CNN — This Thanksgiving travel period is expected to be the busiest in several years and a record-setter for air travel.\r\n\r\nIn all, AAA forecasts there will be 55.4 million people traveling, including more than 49 million Americans driving, between the Wednesday before Thanksgiving (November 23) and the Sunday after\n the holiday. And the Transportation Security Administration is bracing for an all-time record number of passengers at America’s airports over the Thanksgiving travel rush.\r\n\r\nAAA’s estimates don’t even count the many Americans who are expected to travel days ahead of the five-day peak period.\r\n\r\n“The trend is that people are still traveling in very large volumes,” Aixa Diaz of AAA told CNN. “Post-pandemic, the demand for travel just continues to go up year after year, and this\n Thanksgiving is no exception.”\nAAA’s estimates make this the third-busiest Thanksgiving travel period in the more than two decades AAA has tracked it. This year ranks behind only 2019 and 2005 and is about 2% higher than last year.\r\n\r\nBut that only tells part of the story.\r\n\r\nThe total number of turkey day travelers is even larger thanks to new post-Covid work trends. Office workers freed from sitting in a cubicle daily might have the flexibility to make Thanksgiving a weeklong trip or return the following week.\r\n\r\n“Hybrid schedules and remote schedules have changed everything,” said Diaz of AAA.  “Now people can leave for holiday travel at different times.”", "https://media.cnn.com/api/v1/images/stellar/prod/231110164541-01-thanksgiving-travel.jpg?c=16x9&q=h_720,w_1280,c_fill/f_webp", "15.11.2023"));
            list.AddNews(new News("As a kid she posed with her pilot dad in the cockpit. Years later they recreated the photo, with a twist", "CNN — The first time Jasmijn van Waalwijk van Doorn accompanied her pilot father, Jorrit van Waalwijk van Doorn, to work was a day to remember.\nIt was 2006. Eight-year-old Jasmijn joined Jorrit on a KLM flight traveling from their home country of the Netherlands to Uganda.\nPilot Jorrit flew the Boeing 767 there and back. Jasmijn and her mother Ellen were passengers.  Before the flight to Uganda took off, Ellen took a picture of her husband and daughter in the cockpit.\r\n\r\nIn the photo, Jorrit’s clutching the controls, Jasmijn is clutching a beloved lion toy. She’s got one arm around her father. Both are smiling widely.\r\n\r\nCut to 2019. Jorrit and Jasmijn once again found themselves in an airplane cockpit together. It was another day to remember. This time round, Jasmijn wasn’t a passenger – she was a qualified KLM pilot,\n flying alongside her dad for the first time.\r\n\r\nWhen Jasmijn packed her suitcase that morning, she’d made sure to include the beloved lion toy among her belongings. Then, before the flight took off, Jasmijn and Jorrit recreated the photo from over a decade previously.\r\n\r\nOnce again, Jorrit clutched the controls and Jasmijn clutched the lion toy. Both smiled proudly. The main difference between the photos? The now adult Jasmijn is wearing a KLM pilot uniform. And right after the photo was taken, Jasmijn got behind the controls, ready to fly the Boeing 777 to Hong Kong.\r\n\r\nIt was Jasmijn’s mother Ellen who suggested her husband and daughter recreate the 2006 photo.\r\n\r\n“She said, ‘We have that picture of the two of you in the cockpit. Why not take the toy again, and take the same picture again?’” Jasmijn tells CNN Travel. “I was happy that I still had the toy because it’s so special to have that picture.”\n“It started off as a fun thing,” Jorrit tells CNN Travel. “But it was nice to see the two pictures together, then and now.”", "https://media.cnn.com/api/v1/images/stellar/prod/231115095820-01-father-daughter-pilot-team.jpg?c=16x9&q=h_720,w_1280,c_fill/f_webp", "15.11.2023"));
            list.AddNews(new News("The night train revolution has been hailed as an alternative to airplanes. Here’s how that’s going", "CNN — Night trains have been making a resurgence across Europe after decades of decline, raising the prospect of more sustainable ways of crisscrossing the continent as travelers look to find\n alternatives to flying.\nThere’s nothing quite like an overnight train. The excitement before an evening departure. The sense of adventure. The cosmopolitan mix of international travelers.\n And the timeless cultural appeal that inspired “Murder on the Orient Express” and “From Russia With Love” or legendary songs by the likes of James Brown, David Bowie and Ray Charles.\r\n\r\nAnd then there’s the journey itself – retiring to bed as you clatter out of a big city and waking up in a new city, or even a new country, can create memories to last a lifetime.\r\n\r\nAt least that’s the theory – and why the new wave of night trains are being touted as one way to replace short or even medium-haul flights across Europe and the US.\nSo how’s that going?\nEven before their renaissance, night trains could be a pleasant, memorable and sometimes economic way to cover long distances – but luck has always been a big factor.\r\n\r\nAt their best, fares can be good value, combining the cost of a bed for the night and hundreds of miles of travel, but prices quickly ramp up on busy routes, often putting them out of reach for most travelers.\r\n\r\nWherever they run, night trains are complicated, labor intensive and expensive to operate – one of the major reasons they went into decline in the first place.\r\n\r\nDelays are frequently measured in hours rather than minutes, thanks to overnight diversions, while the quality of accommodation has been patchy, ranging from modern and comfortable to basic and outdated.\r\n\r\nEqually, the novelty soon wears off if you’re trying to sleep in a carriage full of hyperactive teenagers or a bachelor party. No one likes to arrive in a new city at 7 a.m. feeling like they’ve slept on a park bench.", "https://media.cnn.com/api/v1/images/stellar/prod/nightjet-1.jpg?c=16x9&q=h_720,w_1280,c_fill/f_webp", "12.11.2023"));
            list.AddNews(new News("The ‘world’s skinniest hotel’ measures nine feet across", "CNN — A new hotel in Indonesia is trying to nab the title of being the “world’s skinniest.” But its creator says the project isn’t just about trying to set a world record – it’s about getting international attention\n for the small town he calls home.\nAry Indra grew up in Salatiga, Central Java. After training as an architect and making his career in Jakarta and Singapore, he felt himself called to return home to Salatiga – and to use his skills there.\nThere, he found an unwanted piece of land, which no one was willing to develop on due to its odd size. It’s now the home of PituRooms, a seven-room hotel (Pitu is Javanese for “seven”) that measures\n just 2.8 meters (9 feet) wide.\nThe building is five floors high, with each of the seven rooms big enough for a double bed and small bathroom with a shower and toilet. Each room has a different feel thanks to local artwork and interiors.\n“I want people to experience Salatiga in a new way,” Indra tells CNN. “I own, designed and operate PituRooms with my own team. It has become my new platform to generate a new type of tourism\n which involves local communities.”", "https://media.cnn.com/api/v1/images/stellar/prod/231112051059-01-piturooms-hotel-indonesia.jpg?c=16x9&q=w_800,c_fill", "15.11.2023"));
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeMain());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new ReligionMain());
        }
    }
}
