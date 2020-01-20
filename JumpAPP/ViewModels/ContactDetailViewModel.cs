using JumpAPP.Models.WebResponse;
using JumpAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class ContactDetailViewModel :ViewModelBase
    {
        private string _surname = string.Empty; //"Singh";
        private string _name = string.Empty; //"SHivendra Pratap";
        
        private string _birth_Date = string.Empty; // "23/03/1996";
        private string _type = string.Empty; //"Sales";
        private string _notes = string.Empty; //"cbjhbhj kjaschb dwcasbDSibkja JIAbhdsuihckli. dsokchbkaa  a";
        private string _branch_Phone = string.Empty; // "99536961119";
        private string _email = string.Empty; // "shivendra2396@gmail.com";
        private string _role = string.Empty; // "Developer";
        private string _company_Name = string.Empty; // "MobileCoderz";
        private string _location = string.Empty; //"Noida";
        private string _mobile_Phone = string.Empty; //"99536966119";
        private string _note_Other = string.Empty; //"bncdhjs bvgh ugyugyudsgc vyhu bcdh jasb hkudb vhu kjfj iyusb v us";
        private string _notes_First = string.Empty; //"bncdhjs bvgh ugyugyudsgc vyhu bcdh jasb hkudb vhu kjfj ib ";
        public ICommand BackTap { get; private set; }

        public ICommand EmailICon { get; private set; }
        public ICommand PhoneICon { get; private set; }
        public ContactDetailViewModel(ContactResponseModel contactDetails)
        {
            Surname = contactDetails.COGNOME;
          Name = contactDetails.NOME;
          // Birth_Date = contactDetails.DT_NASC;
            //Type = contactDetails;
            Notes = contactDetails.NOTE;
            Branch_Phone = contactDetails.TELEF01;
            Email = contactDetails.EMAIL;
            Role = contactDetails.RUOLO;
            Company_Name = contactDetails.NOMEAZIENDA;
            Location = contactDetails.INDIRIZZO;
            Mobile_Phone = contactDetails.MOBILE;
            Note_Other = contactDetails.MEMO;
            Notes_First = contactDetails.NOTE;
            BackTap = new Command(BackTapped);
            EmailICon = new Command(EmailIConTap);
            PhoneICon = new Command(PhoneIConTap);
        }

        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();

        }
        private void EmailIConTap(object obj)
        {
            Device.OpenUri(new Uri("mailto:" + Email));
                 
        }
        private void PhoneIConTap(object obj)
        {
            Device.OpenUri(new Uri("tel:" + Mobile_Phone));

        }
        public string Surname
        {
            get { return _surname; }
            set { _surname = value; NotifyPropertyChanged("Surname"); }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged("Name"); }
        }

        public string Birth_Date
        {
            get { return _birth_Date; }
            set { _birth_Date = value; NotifyPropertyChanged("Birth_Date"); }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; NotifyPropertyChanged("Type"); }
        }

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; NotifyPropertyChanged("Notes"); }
        }

        public string Branch_Phone
        {
            get { return _branch_Phone; }
            set { _branch_Phone = value; NotifyPropertyChanged("Branch_Phone"); }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; NotifyPropertyChanged("Email"); }
        }
        public string Role
        {
            get { return _role; }
            set { _role = value; NotifyPropertyChanged("Role"); }
        }

        public string Company_Name
        {
            get { return _company_Name; }
            set { _company_Name = value; NotifyPropertyChanged("Company_Name"); }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; NotifyPropertyChanged("Location"); }
        }

        public string Mobile_Phone
        {
            get { return _mobile_Phone; }
            set { _mobile_Phone = value; NotifyPropertyChanged("Mobile_Phone"); }
        }

        public string Note_Other
        {
            get { return _note_Other; }
            set { _note_Other = value; NotifyPropertyChanged("ItemContact"); }
        }

        public string Notes_First
        {
            get { return _notes_First; }
            set { _notes_First = value; NotifyPropertyChanged("Notes_First"); }
        }

    }
}
