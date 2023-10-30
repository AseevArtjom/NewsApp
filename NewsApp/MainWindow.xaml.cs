using MahApps.Metro.Controls;
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
            list.AddNews(new News("Nigel Pearson: Bristol City sack manager following Cardiff loss", "Bristol City have sacked manager Nigel Pearson after two and a half years in charge, with the Robins 15th in the Championship.\r\n\r\nThe club have lost five of their past seven matches with Saturday's 2-0 defeat by Cardiff Pearson's final game.\r\n\r\nThe 60-year-old was appointed in February 2021, initially on a short-term deal, and was the second-longest serving manager in the Championship.\r\n\r\nHis contract was due to expire at the end of this season.\r\n\r\n\"This was a difficult decision to make as we recognise and appreciate how much Nigel has done for the club over the past two-and-a-half years on and off the pitch,\" said club chairman Jon Lansdown.\r\n\r\n\"Nigel is highly respected by the staff and players and has been very supportive of the academy structure and our women's team.\r\n\r\n\"We all wanted Nigel to achieve our ambition to be promoted but, with our recent results, feel that now is the time to make a change to give the club the best possible chance of success.\"\r\n\r\nAssistant manager Curtis Fleming will take on the role of interim head coach, while a new appointment is made.\r\n\r\nFormer Leicester and Watford manager Pearson signed a three-year deal until 2024, but after the loss to Coventry last weekend he said that he may be \"fighting for his job\" with the deal soon to expire.\r\n\r\n\"My position has not been secure, which irritates me,\" Pearson told BBC Radio Bristol.\r\n\r\nThe team finished 14th in the Championship last season and have won five of their 14 league matches during this campaign, with three draws and six defeats.\r\n\r\nPearson is the sixth manager to leave a club in the second tier so far this season, with Gareth Ainsworth sacked by QPR on Saturday.\r\n\r\nFirst-team coach Jason Euell has also left Bristol City, along with head of medical performance Dave Rennie.\r\n\r\n'A big, controversial decision'\r\nAnalysis - Richard Hoskin, BBC Radio Bristol sport editor\r\n\r\nThere's been a lot of 'noise' in recent days about the future of Nigel Pearson, ever since he expressed his \"irritation\" that the club hadn't opened contract negotiations about a new deal.\r\n\r\nIn his time at Ashton Gate, Pearson has trimmed the squad and wage bill - losing Antoine Semenyo and Alex Scott to Bournemouth, with the significant transfer fees received for these players not appearing to be reinvested in the squad.\r\n\r\nHe also gave youngsters like Sam Bell and Tommy Conway opportunities and they're now among key first-team players.\r\n\r\nIn recent weeks he's been walking with crutches, as he waited for more tests to diagnose a \"neurological situation\".\r\n\r\nAgainst Cardiff on Saturday, the Robins were hindered by an ever-growing injury list.\r\n\r\nIt's a big, dare I say controversial decision by the Lansdown family - with a lot of City supporters backing Pearson.", "Issy Ronald", "19.10.2023"));
            list.AddNews(new News("Mangrove forests: Steely gaze of young tigress wins photo award", "Soham Bhattacharyya has been named overall winner of this year's Mangrove Photography Awards, for his image of an endangered tigress in the Sundarbans Biosphere Reserve, India. Run by the Mangrove Action Project, the competition - now in its ninth year - aims to show the relationships between wildlife, coastal communities and mangrove forests, as well as the fragility of these unique ecosystems, both above and below the waterline.\r\n\r\nMr Bhattacharyya's winning image, called The Finest Flower of the Mangroves, shows a young Royal Bengal tigress in its natural mangrove habitat, peering at the photographer.\r\n\r\n\"The solitary figure of the tiger, standing amidst the lush green mangrove forest vegetation, poignantly underscores the isolation it must endure in an ever-shrinking habitat,\" said competition judge Daisy Gilardini.\r\n\r\nIn 2021, West Bengal Forest Department estimated there were only 96 Royal Bengal tigers in the region.\r\n\r\nMangroves are an important protection against climate change, with one acre (4,000sq m) of mangrove forest absorbing nearly the same amount of carbon dioxide as an acre of Amazon rainforest.\r\n\r\nThe forests also protect coastlines from eroding, as intense storms grow more frequent.\r\n\r\n\"Photographs of mangroves play a multifaceted role in advocating for the conservation and protection of these critical coastal forests,\" said another of the judges, Fulvio Eccardi.\r\n\r\nFellow judge Octavio Aburto added: \"The images from this year captivated our imagination... giving us hope and illuminating a positive future for mangrove ecosystems.\"\r\n\r\nHere are a selection of winning images from seven competition categories, with descriptions by the photographers.", "Matthew Tucker", "29.10.2023"));
            LVNews.ItemsSource = list.ListNews;
        }
        private void LVNews_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Window1 NewsWindow = new Window1();
            if (e.ClickCount == 1) {
                string Title1 = list.ListNews[0].Titel;
                string description1 = list.ListNews[0].Description;
                string author1 = list.ListNews[0].Photo;
                string date1 = list.ListNews[0].Date;
                System.Windows.Controls.Label titleLabel = new System.Windows.Controls.Label();
                titleLabel.Content = Convert.ToString(Title1);
                System.Windows.Controls.Label descriptionLabel = new System.Windows.Controls.Label();
                descriptionLabel.Content = Convert.ToString(description1);
                System.Windows.Controls.Label photolabel = new System.Windows.Controls.Label();
                photolabel.Content = Convert.ToString(author1);
                System.Windows.Controls.Label datelabel = new System.Windows.Controls.Label();
                datelabel.Content = Convert.ToString(date1);
                NewsWindow.Title.Content = titleLabel;
                NewsWindow.description.Content = descriptionLabel;
                NewsWindow.photo.Content = photolabel;
                NewsWindow.date.Content = datelabel;
                NewsWindow.ShowDialog();
            }
            else if(e.ClickCount == 2)
            {
                string Title2 = list.ListNews[1].Titel;
                string description2 = list.ListNews[1].Description;
                string author2 = list.ListNews[1].Photo;
                string date2 = list.ListNews[1].Date;
                System.Windows.Controls.Label titleLabel = new System.Windows.Controls.Label();
                titleLabel.Content = Convert.ToString(Title2);
                System.Windows.Controls.Label descriptionLabel = new System.Windows.Controls.Label();
                descriptionLabel.Content = Convert.ToString(description2);
                System.Windows.Controls.Label photolabel = new System.Windows.Controls.Label();
                photolabel.Content = Convert.ToString(author2);
                System.Windows.Controls.Label datelabel = new System.Windows.Controls.Label();
                datelabel.Content = Convert.ToString(date2);
                NewsWindow.Title.Content = titleLabel;
                NewsWindow.description.Content = descriptionLabel;
                NewsWindow.photo.Content = photolabel;
                NewsWindow.date.Content = datelabel;
                NewsWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("An error occurred when opening the news", "Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        private void ShowLoginPopup(object sender, RoutedEventArgs e)
        {
            if (LoginPopup.IsOpen)
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