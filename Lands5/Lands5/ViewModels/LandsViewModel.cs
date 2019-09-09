namespace Lands5.ViewModels
{
    using Lands5.Models;
    using Lands5.Services;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Xamarin.Forms;

    class LandsViewModel: BaseViewModel
    {
        #region Services
        private ApiService apiService;
        #endregion
        #region Attributes
        private ObservableCollection<Land> lands;
        #endregion

        #region Properties
        public ObservableCollection<Land> Lands
        {
            get { return this.lands; }
            set {SetValue( ref this.lands, value); }
        }
        #endregion

        #region Constructors
        public LandsViewModel()
        {
            this.apiService = new ApiService();
            this.LoadLands();
        }
        #endregion

        #region Methods
        private async void LoadLands()
        {
            var connection = await this.apiService.CheckConnetion();
            if (!connection.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "connection.Message",
                    "Accept");
                await Application.Current.MainPage.Navigation.PopAsync();//retorno por codigo
                return;
            }

            var response = await this.apiService.GetList<Land>(
                "http://restcountries.eu",
                "/rest",
                "/v2/all");

            if (!response.IsSuccess)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error", 
                    "response.Message", 
                    "Accept");
            }

            var lista = (List<Land>)response.Result;
            this.Lands = new ObservableCollection<Land>(lista);
        }
        #endregion
    }

    internal class lands
    {
    }
}
