using JumpAPP.ViewModels;
using Rg.Plugins.Popup.Pages;
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
	public partial class Page1 : Rg.Plugins.Popup.Pages.PopupPage
    {
		public Page1 ()
		{
			InitializeComponent ();
            BindingContext = new Page1ViewModel();
		}
	}
}