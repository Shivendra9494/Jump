using JumpAPP.Models.WebResponse;
using JumpAPP.Services;
using JumpAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyDetailViewModel :ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public ICommand CompanyBranch { get; private set; }
        public ICommand CompanyContact { get; private set; }
        public ICommand CompanyNotes { get; private set; }
        public ICommand EmailICon { get; private set; }
        public ICommand PhoneICon { get; private set; }
        public CompanyDetailViewModel(CompanyResponseModel companyResponseModel)
        {
                Company_code = companyResponseModel.ID_ANAGEN.ToString();
            Alias = companyResponseModel.ALIAS;
            // Company_name = companyResponseModel.NOMEAZIENDA; 
            Vat_number = companyResponseModel.PIVA;
            Tax_code = companyResponseModel.CODFIS;
            Email = companyResponseModel.EMAIL;
            Phone = companyResponseModel.TELEF01;
            Principle_Address = companyResponseModel.DESCR;

            BackTap = new Command(BackTapped);
            CompanyBranch = new Command(CompanyBranches);
            CompanyContact = new Command(CompanyContactTap);
            CompanyNotes = new Command(CompanyNotesTap);
            EmailICon = new Command(EmailIConTap);
            PhoneICon = new Command(PhoneIConTap);
        }
        private string _company_code = string.Empty;
        public string Company_code
        {
            get { return _company_code; }
            set { _company_code = value; NotifyPropertyChanged("Company_code"); }
        }
         private string _alias = string.Empty;
        public string Alias
        {
            get { return _alias; }
            set { _alias = value; NotifyPropertyChanged("Alias"); }
        }
         private string _company_name = string.Empty;
        public string Company_name
        {
            get { return _company_name; }
            set { _company_name = value; NotifyPropertyChanged("Company_name"); }
        }
         private string _vat_number = string.Empty;
        public string Vat_number
        {
            get { return _vat_number; }
            set { _vat_number = value; NotifyPropertyChanged("Vat_number"); }
        }
         private string _tax_code = string.Empty;
        public string Tax_code
        {
            get { return _tax_code; }
            set { _tax_code = value; NotifyPropertyChanged("Tax_code"); }
        }
         private string _email = string.Empty;
        public string Email
        {
            get { return _email; }
            set { _email = value; NotifyPropertyChanged("Email"); }
        }
         private string _phone = string.Empty;
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; NotifyPropertyChanged("Phone"); }
        }
         private string _principle_Address = string.Empty;
        public string Principle_Address
        {
            get { return _principle_Address; }
            set { _principle_Address = value; NotifyPropertyChanged("Principle_Address"); }
        }
       

        private void BackTapped(object obj)
        {
           Application.Current.MainPage.Navigation.PopModalAsync();
           
        }
           private void CompanyBranches(object obj)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new CompanyBranchPage());
           // App.Current.MainPage = new CompanyBranchPage();
            // Application.Current.MainPage.Navigation.PushAsync(new CompanyBranchPage());

        }
          private void CompanyContactTap(object obj)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new CompanyContactPage());
            //App.Current.MainPage = new CompanyContactPage();
            // Application.Current.MainPage.Navigation.PushAsync(new CompanyBranchPage());

        } 
        private void EmailIConTap(object obj)
        {
            Device.OpenUri(new Uri("mailto:" + Email));

        }
        private void PhoneIConTap(object obj)
        {
            Device.OpenUri(new Uri("tel:" + Phone));

        }
        private void CompanyNotesTap(object obj)
        {

            WebServices service = new WebServices();

            //to get response from api
            Task.Run(async () =>
            {

               App.ContactNote = await service.GetNote();
              
            });
            Application.Current.MainPage.Navigation.PushModalAsync(new CompanyNotes());
            //  App.Current.MainPage = new CompanyNotes();
            // Application.Current.MainPage.Navigation.PushAsync(new CompanyBranchPage());

        }

    }
}
