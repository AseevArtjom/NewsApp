using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using NewsApp.Domain.User;
using NewsApp;
using System.Windows.Navigation;

namespace NewsApp.Pages
{
    /// <summary>
    /// Interaction logic for RegistrationMenu.xaml
    /// </summary>
    public partial class RegistrationMenu : Window
    {
        private UserList users;

        public RegistrationMenu(UserList users)
        {
            InitializeComponent();
            this.users = users;
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegSignUpButton(object sender, RoutedEventArgs e)
        {
            RegPasswordTextBox.BorderBrush = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            RegConfirmPasswordTextBox.BorderBrush = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            RegEmailTextBox.BorderBrush = new SolidColorBrush(Color.FromRgb(220, 220, 220));
            RegUserNameTextBox.BorderBrush = new SolidColorBrush(Color.FromRgb(220, 220, 220));

            string email = RegEmailTextBox.Text;
            string password = RegPasswordTextBox.Text;
            string username = RegUserNameTextBox.Text;

            if (RegConfirmPasswordTextBox.Text != RegPasswordTextBox.Text)
            {
                RegPasswordTextBox.BorderBrush = Brushes.Red;
                RegConfirmPasswordTextBox.BorderBrush = Brushes.Red;
                ErrorLabel.Foreground = Brushes.Red;
                ErrorLabel.Content = "Passwords do not match";
                return;
            }
            else if (IsEmailRegistered(email))
            {
                RegEmailTextBox.BorderBrush = Brushes.Red;
                ErrorLabel.Foreground = Brushes.Red;
                ErrorLabel.Content = "Account with this email is already registered!";
                return;
            }
            else if (IsUserNameRegistered(username))
            {
                RegUserNameTextBox.BorderBrush = Brushes.Red;
                ErrorLabel.Foreground = Brushes.Red;
                ErrorLabel.Content = "Account with this username is already registered!";
                return;
            }
            if (RegConfirmPasswordTextBox.Text == RegPasswordTextBox.Text)
            {
                User NewUser = new User(email, password, username);
                users.AddUser(NewUser);
                this.Close();
            }
        }
        public bool IsEmailRegistered(string email)
        {
            foreach(User item in users.GetUsers())
            {
                if(item.GetEmail() == email)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsUserNameRegistered(string username)
        {
            foreach (User item in users.GetUsers())
            {
                if (item.GetUserName() == username)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
