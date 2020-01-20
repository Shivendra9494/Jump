using JumpAPP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyContactViewModel :ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public CompanyContactViewModel()
        {
            BackTap = new Command(BackTapped);
            Load();
        }

        public void Load()
        {
           
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }

        private CompanyContactModel _selectedContact;
        public CompanyContactModel SelectedContact
        {
            get
            {
                return _selectedContact;
            }
            set
            {
                _selectedContact = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("SelectedContact");
            }
        }
        private ObservableCollection<CompanyContactModel> _itemContact;
        public ObservableCollection<CompanyContactModel> ItemContact
        {
            get
            {
                return _itemContact;
            }
            set
            {
                _itemContact = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("ItemContact");
            }
        }

    }
}
