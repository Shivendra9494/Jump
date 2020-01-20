using JumpAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpAPP.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilterPopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public FilterPopup()
        {
            InitializeComponent();
            BindingContext = new FilterPopupViewModel();
        }
    }
}