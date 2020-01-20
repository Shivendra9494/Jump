using JumpAPP.Helper;
using JumpAPP.Models.WebResponse;
using JumpAPP.Popup;
using JumpAPP.Services;
using JumpAPP.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        public INavigationService _navigationService { get; set; }
        public ICommand LoginCommand { get; private set; }
        public LoginPageViewModel()
        {
            LoginCommand = new Command(LoginTap);
        }
        private async void LoginTap(object obj)
        {
            await CheckLogin();

        }


        private string _password = "rahul.aswal";

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyPropertyChanged("Password");
            }

        }


        private string _email = "rahul.aswal";

        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                NotifyPropertyChanged("Email");
            }
        }

        public async Task<int> CheckLogin()
        {
            if (string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Password))
            {


                if (string.IsNullOrEmpty(Email))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Please fill Email", "OK");
                }

                if (string.IsNullOrEmpty(Password))
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Please fill Password", "OK");
                }

            }
            else
            {
                return await Webapi();
            }
            return 0;
        }




        public string Grant_type = "password";
        public async Task<int> Webapi()
        {
            try
            {
                string grant_type = Grant_type;
                string username = _email;
                string password = _password;
                await PopupNavigation.Instance.PushAsync(new CustomLoader());
                WebServices service = new WebServices();

                var response = await service.LoginApi(grant_type, username, password);
                if (Convert.ToInt16(response.StatusCode) == 200)
                {
                    string loginBody = string.Empty;
                    loginBody = await response.Content.ReadAsStringAsync();
                    DataContractJsonSerializer ser1 = new DataContractJsonSerializer(typeof(LoginResponseModel));
                    MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(loginBody));
                    var log = (LoginResponseModel)ser1.ReadObject(stream1);
                    App.accesstoken = log.access_token;
                    App.expiresTime = log.expires;
                    App.IssuedTime = log.issued;
                    App.username = log.userName;
                    App.tokentype = log.token_type;
                    await PopupNavigation.Instance.PopAllAsync();
                    await PopupNavigation.Instance.PushAsync(new LoadingData());
                    var responses = await service.GetUser();
                    if (Convert.ToInt16(response.StatusCode) == 200)
                    {
                        App.NameCoome = responses.NomeCognome;
                        App.Email = responses.Email;
                        App.Name = responses.Nome;
                        App.COName = responses.Cognome;
                    }

                    App.contactResponse = await service.ContactDetail();
                    App.companyResponse = await service.Company();

                    App.AppointmentResponse = await service.GetAppoint();



                    if (Device.RuntimePlatform == Device.Android)
                        Application.Current.MainPage = new MainPage();
                    else if (Device.RuntimePlatform == Device.iOS)
                        await Application.Current.MainPage.Navigation.PushModalAsync(new MainPage());

                    //IsOpens = true;
                    // Application.Current.MainPage = new MainPage();

                    await PopupNavigation.Instance.PopAllAsync();
                    return 1;





                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "Invalid Username or Password", "OK");
                    return 0;
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }
    }
}



