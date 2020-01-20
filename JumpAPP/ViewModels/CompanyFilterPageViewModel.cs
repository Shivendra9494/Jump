using JumpAPP.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyFilterPageViewModel : ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public ICommand CompanyName { get; private set; }
        public ICommand CompanyCode { get; private set; }
        public ICommand City { get; private set; }
        public ICommand Type { get; private set; }
        public ICommand email { get; private set; }
        public ICommand VATNumber { get; private set; }
        public ICommand Telephone { get; private set; }
        public ICommand Marketing { get; private set; }
        public ICommand Technical { get; private set; }
        public ICommand Sales { get; private set; }
        public ICommand Supervisor { get; private set; }
        public ICommand Alias { get; private set; }
        public ICommand TaxCode { get; private set; }
        public ICommand Apply { get; private set; }
        public ICommand Cancel { get; private set; }
       

        public CompanyFilterPageViewModel()
        {
            BackTap = new Command(BackTapped);
            CompanyName = new Command(CompanyNameTap);
            CompanyCode = new Command(CompanyCodeTap);
            City = new Command(CityTap);
            Type = new Command(TypeTap);
            email = new Command(emailTap);
            VATNumber = new Command(VATNumberTap);
            Telephone = new Command(TelephoneTap);
            Marketing = new Command(MarketingTap);
            Technical = new Command(TechnicalTap);
            Sales = new Command(SalesTap);
            Supervisor = new Command(SupervisorTap);
            Alias = new Command(AliasTap);
            TaxCode = new Command(TaxCodeTap);
            Apply = new Command(ApplyTap);
            Cancel = new Command(CancelTap);

            
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
        private void ApplyTap(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        } 
        private void CancelTap(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
        private void CompanyNameTap(object obj)
        {
            companyname = true;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }

        private void emailTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = true;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }
        private void CompanyCodeTap(object obj)
        {
            companyname = false;
            CompCode = true;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }

        private void CityTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = true;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }

        private void TypeTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = true;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }

        private void VATNumberTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = true;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }

        private void TelephoneTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = true;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }

        private void MarketingTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = true;
        }

        private void TechnicalTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = false;
            Tech = true;
            marketing = false;
        }

        private void SalesTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = false;
            sales = true;
            Tech = false;
            marketing = false;
        }

        private void SupervisorTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = false;
            supervisor = true;
            sales = false;
            Tech = false;
            marketing = false;
        }
        private void AliasTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = false; ;
            alias = true;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;
        }
        private void TaxCodeTap(object obj)
        {
            companyname = false;
            CompCode = false;
            city = false;
            type = false;
            Vat = false;
            Email = false;
            Telphone = false;
            Tax = true; 
            alias = false;
            supervisor = false;
            sales = false;
            Tech = false;
            marketing = false;

        }
        

        private CompanyFilterModel _selectedFilterContent;
        public CompanyFilterModel SelectedFilterContent
        {
            get
            {
                return _selectedFilterContent;
            }
            set
            {
                _selectedFilterContent = value;

                //RaisePropertyChanged();
                NotifyPropertyChanged("SelectedFilterContent");
            }
        }
        private List<CompanyFilterModel> _itemFilterContent;
        public List<CompanyFilterModel> ItemFilterContent
        {
            get
            {
                return _itemFilterContent;
            }
            set
            {
                _itemFilterContent = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("ItemFilterContent");
            }
        }

        private bool _companyname = false;
        public bool companyname
        {
            get
            {
                return _companyname;
            }
            set
            {
                _companyname = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("companyname");
            }
        }


        private bool _CompCode = false;
        public bool CompCode
        {
            get
            {
                return _CompCode;
            }
            set
            {
                _CompCode = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("CompCode");
            }
        }


        private bool _city = false;
        public bool city
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("city");
            }
        }

        private bool _type = false;
        public bool type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("type");
            }
        }


        private bool _vat = false;
        public bool Vat
        {
            get
            {
                return _vat;
            }
            set
            {
                _vat = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("Vat");
            }
        }

        private bool _email = false;
        public bool Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("Email");
            }
        }


        private bool _telphone = false;
        public bool Telphone
        {
            get
            {
                return _telphone;
            }
            set
            {
                _telphone = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("Telphone");
            }


        }

        private bool _marketing = false;
        public bool marketing
        {
            get
            {
                return _marketing;
            }
            set
            {
                _marketing = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("marketing");
            }
        }


        private bool _Tech = false;
        public bool Tech
        {
            get
            {
                return _Tech;
            }
            set
            {
                _Tech = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("Tech");
            }

        }

        private bool _sales = false;
        public bool sales
        {
            get
            {
                return _sales;
            }
            set
            {
                _sales = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("sales");
            }
        }



        private bool _supervisor = false;
        public bool supervisor
        {
            get
            {
                return _supervisor;
            }
            set
            {
                _supervisor = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("supervisor");
            }
        }


        private bool _alias = false;
        public bool alias
        {
            get
            {
                return _alias;
            }
            set
            {
                _alias = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("alias");
            }
        }

        private bool _tax = false;
        public bool Tax
        {
            get
            {
                return _tax;
            }
            set
            {
                _tax = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("Tax");
            }
        }
    }
}
