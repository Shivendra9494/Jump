using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JumpAPP.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomLoader : Rg.Plugins.Popup.Pages.PopupPage
    {
        public CustomLoader()
        {
            InitializeComponent();
        }
    }
}