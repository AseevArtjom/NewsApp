﻿using NewsApp.Navigator;
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
    /// Логика взаимодействия для FootballMain.xaml
    /// </summary>
    public partial class FootballMain : UserControl
    {
        public FootballMain()
        {
            InitializeComponent();
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
    }
}