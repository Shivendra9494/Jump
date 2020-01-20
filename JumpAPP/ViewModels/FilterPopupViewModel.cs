using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class FilterPopupViewModel
    {

        public ICommand YesCommand { get; private set; }
       
        public ICommand CrossImage { get; private set; }
        public FilterPopupViewModel()
        {
            YesCommand = new Command(YesTap);
           
            CrossImage = new Command(CrossImageTap);
        }
        private void YesTap(object obj)
        {
           
            PopupNavigation.PopAsync();
        }
       

        private void CrossImageTap(object obj)
        {

            PopupNavigation.PopAsync();
        }
    }
}

