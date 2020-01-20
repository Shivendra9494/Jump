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
    public partial class OrganizerPage : MasterDetailPage
    {
        //public static readonly BindableProperty DrawerWidthProperty =
        //         BindableProperty.Create(
        //             "WidthRatio",
        //             typeof(int),
        //             typeof(OrganizerPage),
        //             (float)0.2,
        //             propertyChanged: (bindable, oldValue, newValue) =>
        //             {
        //             });

        public readonly static BindableProperty WidthRatioProperty =
            BindableProperty.Create("WidthRatio",
            typeof(float),
            typeof(OrganizerPage),
            (float)0.68);

        //public float WidthRatio
        //{
        //    get { return (float)GetValue(WidthRatioProperty); }
        //    set { SetValue(WidthRatioProperty, value); }
        //}


        public float WidthRatio
        {
            get
            {
                return (float)GetValue(WidthRatioProperty);
            }
            set
            {
                SetValue(WidthRatioProperty, value);
            }
        }
        public OrganizerPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            MasterPage.IconImageSource = "hamburger";
            

            WidthRatio = (float)0.68;
          
            //MasterPage.BackgroundColor = Color.Black;
         //  MasterPage.b = Color.OrangeRed;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as OrganizerPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

          

            Detail = new NavigationPage(page);
           
     
            IsPresented = false;
           

            MasterPage.ListView.SelectedItem = null;
           


        }
    }
}