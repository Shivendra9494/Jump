using JumpAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class MorePageViewModel
    {
        public ICommand FAQTap { get; private set; }
        public ICommand ContactTap { get; private set; }
        public ICommand TCTap { get; private set; }
        public MorePageViewModel()
        {
            FAQTap = new Command(FAQTapped);
            ContactTap = new Command(ContactTapped);
            TCTap = new Command(TCTapped);
        }
        private void FAQTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new FAQPage());

        }
        private void TCTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new TermConditionPage());
            
        }
        private void ContactTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new ContactUSPage());
           
        }
    }
}
