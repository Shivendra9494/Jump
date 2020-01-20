using JumpAPP.Models.WebResponse;
using JumpAPP.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetail : ContentPage
	{
		public ContactDetail (ContactResponseModel contactDetails)
		{
			InitializeComponent ();
            BindingContext = new ContactDetailViewModel(contactDetails);
		}
	}
}