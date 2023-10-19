using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Domain
{
    public class NewsList : INotifyPropertyChanged
    {
        public List<News>? ListNews = null;
        public NewsList()
        {
            ListNews = new List<News>();
        }
       
        public void AddNews(News news)
        {
            ListNews?.Add(news);
        }

        public void RemoveNews(News news)
        {
            ListNews?.Remove(news);
        }

        public void RemoveAllNews()
        {
            ListNews?.Clear();
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}
