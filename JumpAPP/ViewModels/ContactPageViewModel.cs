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
    public class ContactPageViewModel : ViewModelBase
    {
        public ICommand ListTap { get; }
        public ICommand FilterTap { get; }

        public ContactPageViewModel()
        {
            //WebServices service = new WebServices();

            ////to get response from api
            //Task.Run(async () =>
            //{
            //    var response = await service.ContactDetail();
            if (App.contactResponse != null)
            {
                ItemContact = new ObservableCollection<ContactResponseModel>();
                foreach (var item in App.contactResponse)
                {
                    ItemContact.Add(item);
                }
            }
            //});
            ListTap = new Command(ListTapped);
            FilterTap = new Command(FilterTapped);
        }


        private void ListTapped(object obj)
        {
            // do something
            //Application.Current.MainPage = new NavigationPage(new ContactDetail());
        }
        private void FilterTapped(object obj)
        {
            // do something
            Application.Current.MainPage.Navigation.PushModalAsync(new ContactFilter());

        }
        private ContactPageModel _selectedContact;
        public ContactPageModel SelectedContact
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
        private ObservableCollection<ContactResponseModel> _itemContact;
        public ObservableCollection<ContactResponseModel> ItemContact
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
