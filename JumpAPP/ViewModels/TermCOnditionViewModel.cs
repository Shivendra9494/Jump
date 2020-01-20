using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class TermCOnditionViewModel
    {
        public ICommand BackTap { get; private set; }
        public TermCOnditionViewModel()
        {
            BackTap = new Command(BackTapped);
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }
    }
}
