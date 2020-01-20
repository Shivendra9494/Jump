using JumpAPP.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyBranchPageViewModel : ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public CompanyBranchPageViewModel()
        {
            BackTap = new Command(BackTapped);
           
        }

        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }
        private CompanyBranchModel _selectedcompanyBranch;
        public CompanyBranchModel SelectedCompanyBranch
        {
            get
            {
                return _selectedcompanyBranch;
            }
            set
            {
                _selectedcompanyBranch = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("SelectedCompanyBranch");
            }
        }
        private ObservableCollection<CompanyBranchModel> _itemCompanyBranch;
        public ObservableCollection<CompanyBranchModel> ItemCompanyBranch
        {
            get
            {
                return _itemCompanyBranch;
            }
            set
            {
                _itemCompanyBranch = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("ItemCompanyBranch");
            }
        }
    }
}
