using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class FAQViewModel : ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public ICommand AboutTap { get; set; }
        public ICommand ForgetTap { get; set; }
        public ICommand AccountTap { get; set; }
        public ICommand ResetTap { get; set; }
        public ICommand SecureTap { get; set; }
        public ICommand UsernameTap { get; set; }
        public FAQViewModel()
        {
            BackTap = new Command(BackTapped);
            AboutTap = new Command(AboutTapped);
            ForgetTap = new Command(ForgetTapped);
            AccountTap = new Command(AccountTaped);
            ResetTap = new Command(ResetTapped);
            SecureTap = new Command(SecureTapped);
            UsernameTap = new Command(UsernameTapped);
        }





        private bool _isVisible1 = false;
        private bool _isVisible2 = false;
        private bool _isVisible3 = false;
        private bool _isVisible4 = false;
        private bool _isVisible5 = false;
        private bool _isVisible6 = false;
        public bool isVisible1
        {
            get
            {
                return _isVisible1;
            }
            set
            {
                _isVisible1 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("isVisible1");
            }
        }

        public bool isVisible2
        {
            get
            {
                return _isVisible2;
            }
            set
            {
                _isVisible2 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("isVisible2");
            }
        }

        public bool isVisible3
        {
            get
            {
                return _isVisible3;
            }
            set
            {
                _isVisible3 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("isVisible3");
            }
        }

        public bool isVisible4
        {
            get
            {
                return _isVisible4;
            }
            set
            {
                _isVisible4 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("isVisible4");
            }
        }

        public bool isVisible5
        {
            get
            {
                return _isVisible5;
            }
            set
            {
                _isVisible5 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("isVisible5");
            }
        }

        public bool isVisible6
        {
            get
            {
                return _isVisible6;
            }
            set
            {
                _isVisible6 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("isVisible6");
            }
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }
        private void AboutTapped(object obj)
        {
            isVisible1 = !isVisible1;

        }

        private void ForgetTapped(object obj)
        {
            isVisible2 = !isVisible2;

        }

        private void AccountTaped(object obj)
        {
            isVisible3 = !isVisible3;

        }
       
            private void ResetTapped(object obj)
            {
                isVisible4 = !isVisible4;

            }
        private void SecureTapped(object obj)
        {
            isVisible5 = !isVisible5;

        }

        private void UsernameTapped(object obj)
        {
            isVisible6 = !isVisible6;

        }

       
    }
}
