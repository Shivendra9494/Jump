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
	public partial class OrgamiserFormPage : ContentPage
	{
		public OrgamiserFormPage ()
		{
			InitializeComponent ();
            BindingContext = new OrganiserFormViewModel();
		}

        

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            StartDatePicker.Focus();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            EndDatePicker.Focus();
        }
    }
}