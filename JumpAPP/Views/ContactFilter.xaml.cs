using JumpAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpAPP.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactFilter : ContentPage
	{
		public ContactFilter ()
		{
			InitializeComponent ();
            BindingContext = new ContactFilterViewModel();
		}

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}