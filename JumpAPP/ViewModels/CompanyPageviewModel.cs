using JumpAPP.Models;
using JumpAPP.Models.WebResponse;
using JumpAPP.Services;
using JumpAPP.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyPageviewModel : ViewModelBase
    {
        public ICommand FilterTap { get; }
        // public ICommand ListTap { get; private set; }
        public CompanyPageviewModel()
        {
            //WebServices service = new WebServices();
            ////to get response from api
            //Task.Run(async () =>
            //{

            if (App.companyResponse != null)
            {
                ItemCompanyList = new ObservableCollection<CompanyResponseModel>();
                //ItemCompanyList.Clear();
                foreach (var item in App.companyResponse)
                {
                    ItemCompanyList.Add(item);
                }
            }
            //});

            FilterTap = new Command(FilterTapped);
            //  ListTap = new Command(ListTapped);
        }


        private void FilterTapped(object obj)
        {
            // do something
            Application.Current.MainPage.Navigation.PushModalAsync(new CompanyFilterPage());

        }
        //private void ListTapped(object obj)
        //{
        //    Application.Current.MainPage = new NavigationPage(new CompanyDetailPage());
        //}

        private CompanyListModel _selectedcompanyList;
        public CompanyListModel SelectedCompanyList
        {
            get
            {
                return _selectedcompanyList;
            }
            set
            {
                _selectedcompanyList = value;

                //RaisePropertyChanged();
                NotifyPropertyChanged("SelectedCompanyList");
            }
        }
        private ObservableCollection<CompanyResponseModel> _itemCompanyList;
        public ObservableCollection<CompanyResponseModel> ItemCompanyList
        {
            get
            {
                return _itemCompanyList;
            }
            set
            {
                _itemCompanyList = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("ItemCompanyList");
            }
        }
    }
}
