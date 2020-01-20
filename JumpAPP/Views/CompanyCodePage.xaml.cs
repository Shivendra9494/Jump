using JumpAPP.Interfaces;
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
	public partial class CompanyCodePage : ContentPage
	{
		public CompanyCodePage ()
		{
			InitializeComponent ();
            BindingContext = new CompanyCodePageViewModel();
		}
        private void EntryPasscode1_Completed(object sender, System.EventArgs e)
        {

            if (string.IsNullOrEmpty(EntryPasscode1.Text.ToString()))
            {
                EntryPasscode1.Focus();
               // DependencyService.Get<IKeyboardHelper>().HideKeyboard();
                //EntryPasscode1.TextChanged += (s, f) => EntryPasscode1.Focus();

            }
            else
            {
                EntryPasscode2.Focus();
                //EntryPasscode1.TextChanged += (s, f) => EntryPasscode2.Focus();

            }

        }

        private void EntryPasscode2_Completed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryPasscode2.Text.ToString()))
            {
                EntryPasscode1.Focus();
                //EntryPasscode2.TextChanged += (s, f) => EntryPasscode1.Focus();

            }
            else
            {
                EntryPasscode3.Focus();
                //EntryPasscode2.TextChanged += (s, f) => EntryPasscode3.Focus();

            }

        }

        private void EntryPasscode3_Completed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryPasscode3.Text.ToString()))
            {
                EntryPasscode2.Focus();
                //EntryPasscode3.TextChanged += (s, f) => EntryPasscode2.Focus();

            }
            else
            {
                EntryPasscode4.Focus();
                //EntryPasscode3.TextChanged += (s, f) => EntryPasscode4.Focus();

            }
        }
        private void EntryPasscode4_Completed(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(EntryPasscode4.Text.ToString()))
            {
                EntryPasscode3.Focus();
                //EntryPasscode4.TextChanged += (s, f) => EntryPasscode3.Focus();

            }
            else
            {
                EntryPasscode4.Focus();
                //DependencyService.Get<IKeyboardHelper>().HideKeyboard();
                //loginBtn.Focus();
                //EntryPasscode4.Unfocus();
                //EntryPasscode4.TextChanged += (s, f) => EntryPasscode4.Focus();

            }
        }

    }
}