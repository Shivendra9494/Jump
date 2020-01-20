using JumpAPP.Models;
using JumpAPP.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class ContactFilterViewModel :ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public ICommand SurnameClick { get; private set; }
        public ICommand FirstClick { get; private set; }
        public ICommand RoleClick { get; private set; }
        public ICommand MobileClick { get; private set; }
        public ICommand CompanyClick { get; private set; }
        public ICommand ApplyCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }
        public ContactFilterViewModel()
        {
            BackTap = new Command(BackTapped);
            SurnameClick = new Command(SurnameClickTap);
            FirstClick = new Command(FirstClickTap);
            RoleClick = new Command(RoleClickTap);
            MobileClick = new Command(MobileClickTap);
            CompanyClick = new Command(CompanyClickTap);
            ApplyCommand = new Command(ApplyCommandTap);
            ApplyCommand = new Command(ApplyCommandTap);
            CancelCommand = new Command(CancelCommandTap);

        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }

        private void CancelCommandTap(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }
        private void ApplyCommandTap(object obj)
        {
            WebServices service = new WebServices();

            //to get response from api
            Task.Run(async () =>
            {

                App.contactResponse = await service.ContactDetail();
            });

            Application.Current.MainPage.Navigation.PopModalAsync();
        }
            

        private void SurnameClickTap(object obj)
        {
            SurnameVisible = true;
            FirstnameVisible = false;
            RoleVisible = false;
            CompanyVisible = false;
            MobileVisible = false;
        }

        private void FirstClickTap(object obj)
        {
            SurnameVisible = false;
            FirstnameVisible = true;
            RoleVisible = false;
            CompanyVisible = false;
            MobileVisible = false;
        }

        private void RoleClickTap(object obj)
        {
            SurnameVisible = false;
            FirstnameVisible = false;
            RoleVisible = true;
            CompanyVisible = false;
            MobileVisible = false;
        }

        private void MobileClickTap(object obj)
        {
            SurnameVisible = false;
            FirstnameVisible = false;
            RoleVisible = false;
            CompanyVisible = false;
            MobileVisible = true;
        }

        private void CompanyClickTap(object obj)
        {
            SurnameVisible = false;
            FirstnameVisible = false;
            RoleVisible = false;
            CompanyVisible = true;
            MobileVisible = false;
        }
      

        private bool _surnameVisible = false;
        public bool SurnameVisible
        {
            get
            {
                return _surnameVisible;
            }
            set
            {
                _surnameVisible = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("SurnameVisible");
            }
        }

        private bool _firstnameVisible = false;
        public bool FirstnameVisible
        {
            get
            {
                return _firstnameVisible;
            }
            set
            {
                _firstnameVisible = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("FirstnameVisible");
            }
        }

        private bool _companyVisible = false;
        public bool CompanyVisible
        {
            get
            {
                return _companyVisible;
            }
            set
            {
                _companyVisible = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("CompanyVisible");
            }
        }

        private bool _roleVisible = false;
        public bool RoleVisible
        {
            get
            {
                return _roleVisible;
            }
            set
            {
                _roleVisible = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("RoleVisible");
            }
        }


        private bool _mobileVisible = false;
        public bool MobileVisible
        {
            get
            {
                return _mobileVisible;
            }
            set
            {
                _mobileVisible = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("MobileVisible");
            }
        }
    }

}
