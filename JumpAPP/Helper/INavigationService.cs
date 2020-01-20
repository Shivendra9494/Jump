using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace JumpAPP.Helper
{
    public interface INavigationService
    {
        string CurrentPageKey { get; }
        void Configure(string pageKey, Type pageType);
        Task GoBack();
        Task NavigateModalAsync(string pageKey, bool animated = true);
        Task NavigateModalAsync(string pageKey, object parameter, bool animated = true);
        Task NavigateAsync(string pageKey, bool animated = true);
        Task NavigateAsync(string pageKey, object parameter, bool animated = true);
        Task NavigationTabbedPage(string pageKey, TabbedPage tab, bool animated = true);
        void RemovePageFromStack();
    }
}
