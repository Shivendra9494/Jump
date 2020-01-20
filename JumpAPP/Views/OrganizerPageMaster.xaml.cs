using JumpAPP.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpAPP.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OrganizerPageMaster : ContentPage
    {
        public ListView ListView;


        public OrganizerPageMaster()
        {
            InitializeComponent();
            BindingContext = new OrganizerPageMasterViewModel();
            ListView = MenuItemsListView;

        }



        public class OrganizerPageMasterViewModel : ViewModelBase
        {

            public ObservableCollection<OrganizerPageMenuItem> MenuItems { get; set ; }
            // public ICommand ViewcellCommand { get; set; }
            public OrganizerPageMasterViewModel()
            {
                // ViewcellCommand = new Command(ViewCellTapped);
                MenuItems = new ObservableCollection<OrganizerPageMenuItem>(new[]
                {
                    new OrganizerPageMenuItem { Id = 0, Title = "Week Day" ,BackgroundColor = Color.White   , TargetType = typeof(OrganizerPageDetail)},
                    new OrganizerPageMenuItem { Id = 1, Title = "3 Day", BackgroundColor = Color.White, TargetType = typeof(ThreeDayOrganiser)},
                    new OrganizerPageMenuItem { Id = 2, Title = "Day", BackgroundColor =  Color.White, TargetType = typeof(OneDayOrganiser) },

                });
            }

            //protected bool SetProperty<T>(ref T backingStore, T value,
            //[CallerMemberName] string propertyName = "", Action onChanged = null)
            //{
            //    if (EqualityComparer<T>.Default.Equals(backingStore, value)) return false;
            //    backingStore = value;
            //    onChanged?.Invoke();
            //    OnPropertyChanged(propertyName);
            //    return true;
            //}
            private string _emails = App.Email;

            public string Emails
            {
                get { return _emails; }
                set
                {
                    _emails = value;
                    NotifyPropertyChanged("Emails");
                }
            }

            private OrganizerPageMenuItem _itemSelected;

            public OrganizerPageMenuItem ItemSelected
            {
                get { return _itemSelected; }
                set
                {
                    _itemSelected = value;
                    if (ItemSelected != null)
                    {
                        ObservableCollection<OrganizerPageMenuItem> tempItems = new ObservableCollection<OrganizerPageMenuItem>();
                        foreach(var item in MenuItems)
                        {
                            OrganizerPageMenuItem tempObj = new OrganizerPageMenuItem
                            {
                                Id = item.Id,
                                TargetType = item.TargetType,
                                Title = item.Title
                            };
                            if (item.Id == ItemSelected.Id)
                                tempObj.BackgroundColor = Color.YellowGreen;
                            else
                                tempObj.BackgroundColor = Color.White;
                            tempItems.Add(tempObj);
                        }
                        MenuItems = tempItems;
                        NotifyPropertyChanged("MenuItems");
                    }


                    NotifyPropertyChanged("ItemSelected");
                }
            }


            private string _name = App.NameCoome;

            public string Name
            {
                get { return _name; }
                set
                {
                    _name = value;
                    NotifyPropertyChanged("Name");
                }
            }


            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }






        //private void ViewCell_Tapped(object sender, EventArgs e)
        //{
        //    var viewCell = (ViewCell)sender;
        //    if (viewCell.View != null)
        //    {
        //        viewCell.View.BackgroundColor = Color.YellowGreen;
        //    }
        //    else
        //    {
        //        viewCell.View.BackgroundColor = Color.White;
        //    }
        //}

    }
}