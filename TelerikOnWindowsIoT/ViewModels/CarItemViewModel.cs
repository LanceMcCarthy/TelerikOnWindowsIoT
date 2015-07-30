using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TelerikOnWindowsIoT.Annotations;

namespace TelerikOnWindowsIoT.ViewModels
{
    public class CarItemViewModel : ViewModelBase
    {
        private string make;
        private string model;
        private int year;
        private double price;

        public string Make
        {
            get { return make; }
            set { make = value; OnPropertyChanged();}
        }

        public string Model
        {
            get { return model; }
            set { model = value; OnPropertyChanged();}
        }

        public int Year
        {
            get { return year; }
            set { year = value; OnPropertyChanged();}
        }

        public double Price
        {
            get { return price; }
            set { price = value; OnPropertyChanged();}
        }
    }
}
