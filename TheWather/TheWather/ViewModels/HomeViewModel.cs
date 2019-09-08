using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using TheWather.Models;
using Xamarin.Forms;

namespace TheWather.ViewModels
{
    public class HomeViewModel:BaseViewModel
    {
        public HomeViewModel(INavigation navigation) : base(navigation)
        {
            GetWeatherResponseCommand = new Command(GetWeatherResponse);
        }

        
        private WeatherResponseRoot response;
        private string city;
        private Weather weather;

        public WeatherResponseRoot Response
        {
            get => response;
            set => SetProperty(ref response, value);
        }
        public string City
        {
            get => city;
            set => SetProperty(ref city, value);
        }

        public Weather Weather
        {
            get => weather;
            set => SetProperty(ref weather, value);
        }
        

        private async void GetWeatherResponse()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            Response = await Services.WebService.GetWeatherAsync(City);
            Weather = Response.Weather[0];
            IsBusy = false;
        }

        public ICommand GetWeatherResponseCommand { get; }
    }
}
