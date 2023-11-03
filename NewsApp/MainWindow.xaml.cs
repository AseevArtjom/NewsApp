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
using NewsApp.Domain.User;
using NewsApp.Pages;

namespace NewsApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewsList list;
        User CurrentUser = new User();

        private UserList users = new UserList();

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
        public void ShowLoginPopup(object sender, RoutedEventArgs e)
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
            tb.Foreground = Brushes.Indigo;
        }

        private void OnLostFocusHandler(object sender, MouseEventArgs e)
        {
            Button tb = e.Source as Button;
            tb.Background = Brushes.Indigo;
            tb.Foreground = Brushes.White;
        }

        private void ForgotPassword_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void LoginClick(object sender, RoutedEventArgs e)
        {
            foreach(User item in users.GetUsers())
            {
                if(item.GetEmail() == EmailBox.Text && item.GetPassword() == PasswordBox.Password)
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
    }
}
