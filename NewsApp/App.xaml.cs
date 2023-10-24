using NewsApp.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NewsApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        NewsList list;

        public App()
        {
            list = new NewsList();
            list.AddNews(new News("123", "123", "123", "123"));
            InitializeComponent();
        }
    }
}
