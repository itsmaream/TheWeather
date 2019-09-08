using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TheWather.Models;
using Xamarin.Forms;

namespace TheWather.ViewModels
{
    /// <summary>
    /// HomeViewModel
    /// </summary>
    public class HomeViewModel : BaseViewModel
    {
        // have your fields and properties above the constructor
        private WeatherResponseRoot response;
        private string city;

        /// <summary>
        /// WeatherResponseRoot object
        /// </summary>
        public WeatherResponseRoot Response
        {
            get => response;
            set => SetProperty(ref response, value);
        }
        /// <summary>
        /// City to search by
        /// </summary>
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        public ICommand GetWeatherResponseCommand { get; }

        public HomeViewModel(INavigation navigation) : base(navigation)
        {
            Title = "TheWather";

            GetWeatherResponseCommand = new Command(GetWeatherResponse);
        }

        /// <summary>
        /// Load WeatherResponse and set the object
        /// </summary>
        private async void GetWeatherResponse()
        {
            if (IsBusy)
                return;
            // check if there's an actual input, if not, there is no need to search
            if (string.IsNullOrEmpty(City))
                return; // TODO:: notify the user
            IsBusy = true;
            Response = await Services.WebService.GetWeatherAsync(City);
            IsBusy = false;
        }

    }
}
