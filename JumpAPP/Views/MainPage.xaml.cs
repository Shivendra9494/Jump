using JumpAPP.Controls;
using JumpAPP.Services;
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
    public partial class MainPage : BottomNavTabPage
    {
        public MainPage()
        {
            InitializeComponent();
            Xamarin.Forms.PlatformConfiguration.AndroidSpecific.TabbedPage.SetIsSwipePagingEnabled(this, false);
        }
    }
}