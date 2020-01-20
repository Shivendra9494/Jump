using JumpAPP.Models;
using JumpAPP.Models.WebResponse;
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
	public partial class CompanyPage : ContentPage
	{
		public CompanyPage ()
		{
			InitializeComponent ();
            BindingContext = new CompanyPageviewModel();
        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedItem = (sender as ListView).SelectedItem as CompanyResponseModel;
            await Navigation.PushModalAsync(new NavigationPage(new CompanyDetailPage(selectedItem)));


           
            //Application.Current.MainPage.Navigation.PushModalAsync(new CompanyDetailPage());
        }
    }
}