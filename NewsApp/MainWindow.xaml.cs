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
using System.Windows.Media.Animation;
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
            list = new NewsList();
            list.AddNews(new News("NEWS","Important news","","19.10.2023"));
            InitializeComponent();
            LVMainFootball.ItemsSource = list.ListNews;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dropDownStoryboard = FindResource("DropDownStoryboard") as Storyboard;
            if (dropDownStoryboard != null)
            {
                dropDownStoryboard.Begin();
            }
        }
    }
}
