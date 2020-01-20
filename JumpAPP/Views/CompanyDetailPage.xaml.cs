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
    public partial class CompanyDetailPage : ContentPage
    {
        public CompanyDetailPage(CompanyResponseModel companyResponseModel)
        {
            InitializeComponent();
            BindingContext = new CompanyDetailViewModel(companyResponseModel);
        }

      
    }
}