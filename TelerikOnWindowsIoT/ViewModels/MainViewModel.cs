using System.Collections.ObjectModel;
using TelerikOnWindowsIoT.DataServices;

namespace TelerikOnWindowsIoT.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<CarItemViewModel> cars;

        public MainViewModel()
        {
            LoadCarsFromService();
        }
        
        /// <summary>
        /// Collection of sample cars to bind to the UI
        /// </summary>
        public ObservableCollection<CarItemViewModel> Cars
        {
            get { return cars ?? (cars = new ObservableCollection<CarItemViewModel>()); }
            set { cars = value; OnPropertyChanged(); }
        }

        /// <summary>
        /// MainViewModel method to get a list of cars from a sample data service
        /// </summary>
        private async void LoadCarsFromService()
        {
            Cars = await CarDataService.GetSampleCarsAsync();
        }
    }
}
