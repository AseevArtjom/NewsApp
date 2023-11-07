using NewsApp.Domain;
using NewsApp.Domain.User;
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
    /// Логика взаимодействия для HomeNews.xaml
    /// </summary>
    public partial class HomeNews : UserControl
    {
        User CurrentUser = new User();
        private UserList users = new UserList();

        public HomeNews()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigatorObject.Switch(new HomeMain());
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

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            foreach (User item in users.GetUsers())
            {
                if (item.GetEmail() == EmailBox.Text && item.GetPassword() == PasswordBox.Password)
                {
                    CurrentUser = item;
                    UserNameTextBlock.Content = CurrentUser.GetUserName();
                    LoginPopup.IsOpen = false;
                    return;
                }
            }
            ErrorLabel.Foreground = Brushes.Red;
            ErrorLabel.Content = "Incorrect password or email";

            EmailBox.BorderBrush = Brushes.Red;
            PasswordBox.BorderBrush = Brushes.Red;
        }
        private void CreateNewAccount_Click(object sender, MouseButtonEventArgs e)
        {
            RegistrationMenu registrationMenu = new RegistrationMenu(users);
            registrationMenu.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            registrationMenu.ShowDialog();
        }
        private void ForgetPasswordClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("There is nothing we can do");
        }
        public void ShowLoginPopup(object sender, RoutedEventArgs e)
        {
            if (LoginPopup.IsOpen)
            {
                LoginPopup.IsOpen = false;
            }
            else if (LoginPopup.IsOpen == false)
            {
                LoginPopup.IsOpen = true;
            }
        }
    }
}
