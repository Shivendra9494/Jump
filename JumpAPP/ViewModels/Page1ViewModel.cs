using JumpAPP.Views;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class Page1ViewModel
    {
        public ICommand YesCommand { get; private set; }
        public ICommand NoCommand { get; private set; }
        public ICommand CrossImage { get; private set; }
        public Page1ViewModel()
        {
            YesCommand = new Command(YesTap);
            NoCommand = new Command(NoTap);
            CrossImage = new Command(CrossImageTap);
        }
        private void YesTap(object obj)
        {
            Application.Current.MainPage = new LoginPage();
            PopupNavigation.PopAsync();
        }
        private void NoTap(object obj)
        {
            
            PopupNavigation.PopAsync();
        }

        private void CrossImageTap(object obj)
        {

            PopupNavigation.PopAsync();
        }
    }
}
