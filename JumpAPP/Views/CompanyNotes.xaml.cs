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
	public partial class CompanyNotes : ContentPage
	{
		public CompanyNotes ()
		{
			InitializeComponent ();
            BindingContext = new CompanyNotesViewModel();
		}
	}
}