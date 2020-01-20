using JumpAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class ContactUsPageViewModel
    {
        public ICommand BackTap { get; private set; }
        public ICommand SubmitCommand { get; private set; }
        public ContactUsPageViewModel()
        {
            BackTap = new Command(BackTapped);
            SubmitCommand = new Command(SubmitCommandTap);
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
        private void SubmitCommandTap(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
