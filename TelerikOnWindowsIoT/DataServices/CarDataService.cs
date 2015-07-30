using System.Collections.ObjectModel;
using System.Threading.Tasks;
using TelerikOnWindowsIoT.ViewModels;

namespace TelerikOnWindowsIoT.DataServices
{
    public static class CarDataService
    {
        /// <summary>
        /// Task to create sample cars
        /// </summary>
        /// <returns>ObservableCollection of car objects containing make, model, year, and price</returns>
        public static async Task<ObservableCollection<CarItemViewModel>> GetSampleCarsAsync()
        {
            return await Task.Run(() => new ObservableCollection<CarItemViewModel>()
            {
                new CarItemViewModel { Make="Audi", Model="A4 Quattro", Year = 2014, Price = 30500},
                new CarItemViewModel { Make="Audi", Model = "A6 Quattro", Year = 2015, Price = 46200},
                new CarItemViewModel { Make="Audi", Model = "A8 Quattro", Year = 2012, Price = 62400},
                new CarItemViewModel { Make="BMW", Model = "3 Series", Year = 2011, Price = 12950},
                new CarItemViewModel { Make="BMW", Model = "4 Series", Year = 2012, Price = 22000},
                new CarItemViewModel { Make="BMW", Model = "5 Series", Year = 2013, Price = 39950},
                new CarItemViewModel { Make="BMW", Model = "7 Series", Year = 2014, Price = 69000},
                new CarItemViewModel { Make="Mercedes", Model = "C Class", Year = 2013, Price = 28400},
                new CarItemViewModel { Make="Mercedes", Model = "E Class", Year = 2015, Price = 51800}
            });
        }
    }
}
