using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Assignment.ViewModels
{
    public class WelcomeViewModel : BaseViewModel
    {
        public WelcomeViewModel()
        {



            //Intial Peoject
            Title = "Welcome to the application";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://www.google.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
