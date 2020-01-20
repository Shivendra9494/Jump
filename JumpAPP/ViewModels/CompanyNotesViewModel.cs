using JumpAPP.Models;
using JumpAPP.Popup;
using JumpAPP.Services;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class CompanyNotesViewModel : ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public CompanyNotesViewModel()
        {
            PopupNavigation.Instance.PushAsync(new CustomLoader());


            if (App.ContactNote != null)
            {
                ItemCompanyBranch = new List<CompanyNotesModel>();
                foreach (var item in App.ContactNote)
                {
                    ItemCompanyBranch.Add(new CompanyNotesModel
                    {
                        Date = item.DATA_RIGA.ToString(),
                        Description = item.NOTE,
                        Type_Notes = item.TIPO_NOTA,
                        Expiration_Date = item.DATA_SCAD.ToString(),
                        Notes = item.NOTE


                    });
                }
            }
            
            
           PopupNavigation.Instance.PopAllAsync();
            BackTap = new Command(BackTapped);
            
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }

        private CompanyNotesModel _selectedcompanyBranch;
        public CompanyNotesModel SelectedCompanyBranch
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
        private List<CompanyNotesModel> _itemCompanyBranch;
        public List<CompanyNotesModel> ItemCompanyBranch
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
