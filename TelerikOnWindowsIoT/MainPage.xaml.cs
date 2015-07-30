using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using TelerikOnWindowsIoT.ViewModels;

namespace TelerikOnWindowsIoT
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// This Slider ValueChanged event changes the price of every car in the Cars collection
        /// </summary>
        private void RangeBase_OnValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var vm = this.DataContext as MainViewModel;

            var isPositiveChange = e.NewValue - e.OldValue > 0;

            foreach (var car in vm.Cars)
            {
                car.Price = isPositiveChange ? car.Price + e.NewValue : car.Price - e.NewValue;
            }
        }
    }
}
