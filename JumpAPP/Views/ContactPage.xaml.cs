using JumpAPP.Models.WebResponse;
using JumpAPP.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactPage : ContentPage
	{
		public ContactPage ()
		{
			InitializeComponent ();
            BindingContext = new ContactPageViewModel();
		}

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (sender as ListView).SelectedItem as ContactResponseModel;
            await Navigation.PushModalAsync(new NavigationPage(new ContactDetail(selectedItem)));
       
          //  await Application.Current.MainPage.Navigation.PushAsync(new ContactDetail());
           

        }
    }
    
}