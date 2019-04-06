
namespace Lands5.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsRunning { get; set; }
        public bool IsRemembered { get; set; }
        #endregion

        #region Commands
        public ICommand  LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        private async void Login()
        {
            if(string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an email",
                    "Accept");
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "You must enter an password",
                    "Accept");
                return;
            }

            if (this.Email != "r@gmail.com" || this.Password != "123")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Email or password incorrect.",
                    "Accept");
                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                    "Ok",
                    "Correct.",
                    "Accept");
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.IsRemembered = true;   
        }
        #endregion
    }
}
