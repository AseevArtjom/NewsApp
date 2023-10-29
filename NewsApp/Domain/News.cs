﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Domain
{
    public class News : INotifyPropertyChanged
    {
        public string? _titel;
        public string? _description;
        public string? _photo;
        public string? _date;

        public News(string titel, string desc, string photo, string date)
        {
            Titel = titel;
            Description = desc;
            Photo = photo;
            Date = date;
        }

        public string? Titel
        {
            get { return _titel; }
            set
            {
                _titel = value;
                OnPropertyChanged("Titel");
            }
        }

        public string? Description
        {
            get { return _description; }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }

        public string? Photo
        {
            get { return _photo; }
            set
            {
                _photo = value;
                OnPropertyChanged("Photo");
            }
        }

        public string? Date
        {
            get { return _date; }
            set
            {
                _date = value;
                OnPropertyChanged("Date");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string propetyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propetyName));
        }
    }
}