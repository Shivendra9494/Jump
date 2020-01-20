using JumpAPP.Popup;
using JumpAPP.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyCodePageViewModel
    {
        public ICommand SubmitCommand { get; private set; }
        public CompanyCodePageViewModel()
        {
            SubmitCommand = new Command(SubmitTaapped);
        }

        private async void SubmitTaapped(object obj)
        {
            await PopupNavigation.PushAsync(new Page1());
           // Application.Current.MainPage = new LoginPage();
        }
    }

}
