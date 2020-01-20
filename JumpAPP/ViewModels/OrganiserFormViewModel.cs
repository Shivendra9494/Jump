using JumpAPP.Models.WebRequest;
using JumpAPP.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class OrganiserFormViewModel :ViewModelBase
    {
        public ICommand BackTap { get; private set; }
        public ICommand SubmitCommand { get; private set; }
        public ICommand ShowHiddenRow0Command { get; set; }
        public ICommand ShowHiddenRow1Command { get; set; }
        public ICommand Datepick { get; set; }

        public OrganiserFormViewModel()
        {
            BackTap = new Command(BackTapped);
            SubmitCommand = new Command(SubmitCommandTap);
            Datepick = new Command(DatepickRTap);
            ShowHiddenRow0Command = new Command(ShowHiddenRow0CommandTap);
            ShowHiddenRow1Command = new Command(ShowHiddenRow1CommandTap);
           
        }
        private void BackTapped(object obj)
        {
            Application.Current.MainPage.Navigation.PopModalAsync();
        }
        private void DatepickRTap(object obj)
        {
           
        }
        private void SubmitCommandTap(object obj)
        {
            Send_Data();
            Task.Run(async () =>
            {

                WebServices webService = new WebServices();
                OrganiserFormRequestModel organiserFormRequestModel = new OrganiserFormRequestModel();

                var response = await webService.PostAgendaApi(organiserFormRequestModel);
                if(response.USERNAME == "Rahul.aswal")
                {
                    await Application.Current.MainPage.Navigation.PopModalAsync();
                }

                


            });
          
        }


        private string _email;
        public string Email
        {
            get { return _email; }
            set {_email = value;
                NotifyPropertyChanged("Email");
            }
        }
        private string _object;
        public string Object
        {
            get { return _object; }
            set {
                _object = value;
                NotifyPropertyChanged("Object");
            }
        }
        private string _description;
        public string Description
        {
            get { return _description; }
            set {
                _description = value;
                NotifyPropertyChanged("Description");
            }
        }
        private DateTime _startdate;
        public DateTime Startdate
        {
            get { return _startdate; }
            set {
                _startdate = value;
                NotifyPropertyChanged("Startdate");
            }
        }
        private DateTime _endDate;
        public DateTime EndDate
        {
            get { return _endDate; }
            set {
                _endDate = value;
                NotifyPropertyChanged("EndDate");
            }
        }
        private string _status;
        public string Status
        {
            get { return _status; }
            set {
                _status = value;
                NotifyPropertyChanged("Status");
            }
        }
        private string _internal;
        public string Internal
        {
            get { return _internal; }
            set {
                _internal = value;
                NotifyPropertyChanged("Internal");
            }
        }
        private string _user = App.NameCoome;
        public string User
        {
            get { return _user; }
            set {
                _user = value;
                NotifyPropertyChanged("User");
            }
        }
        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set {
                _notes = value;
                NotifyPropertyChanged("Notes");
            }
        }
        private string _branch;
        public string Branch
        {
            get { return _branch; }
            set {
                _branch = value;
                NotifyPropertyChanged("Branch");
            }
        }
        private string _contact;
        public string Contact
        {
            get { return _contact; }
            set {
                _contact = value;
                NotifyPropertyChanged("Contact");
            }
        }
        private string _order;
        public string Order
        {
            get { return _order; }
            set {
                _order = value;
                NotifyPropertyChanged("Order");
            }
        }
        private string _phase;
        public string Phase
        {
            get { return _phase; }
            set {
                _phase = value;
                NotifyPropertyChanged("Phase");
            }
        }
        private string _ticket;
        public string Ticket
        {
            get { return _ticket; }
            set {
                _ticket = value;
                NotifyPropertyChanged("Ticket");
            }
        }
        private string _miles;
        public string Miles
        {
            get { return _miles; }
            set {
                _miles = value;
                NotifyPropertyChanged("Miles");
            }
        }
        private string _fuel;
        public string Fuel
        {
            get { return _fuel; }
            set {
                _fuel = value;
                NotifyPropertyChanged("Fuel");
            }
        }
        private string _toll;
        public string Toll
        {
            get { return _toll; }
            set {
                _toll = value;
                NotifyPropertyChanged("Toll");
            }
        }
        private string _food;
        public string Food
        {
            get { return _food; }
            set {
                _food = value;
                NotifyPropertyChanged("Food");
            }
        }
        private string _accomodation;
        public string Accomodation
        {
            get { return _accomodation; }
            set {
                _accomodation = value;
                NotifyPropertyChanged("Accomodation");
            }
        }
        private string _overnight;
        public string Overnight
        {
            get { return _overnight; }
            set {
                _overnight = value;
                NotifyPropertyChanged("Overnight");
            }
        }
        private string _forAway;
        public string ForAway
        {
            get { return _forAway; }
            set {
                _forAway = value;
                NotifyPropertyChanged("ForAway");
            }
        }
        private string _others;
        public string Others
        {
            get { return _others; }
            set {
                _others = value;
                NotifyPropertyChanged("Others");
            }
        }

        private bool _SLRow1 = false;
        public bool SLRow1
        {
            get
            {
                return _SLRow1;
            }
            set
            {
                _SLRow1 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("SLRow1");
            }
        }

        private bool _SLRow0 = false;
        public bool SLRow0
        {
            get
            {
                return _SLRow0;
            }
            set
            {
                _SLRow0 = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("SLRow0");
            }
        }

        public void Send_Data()
        {
            OrganiserFormRequestModel organiserFormRequestModel = new OrganiserFormRequestModel();


            organiserFormRequestModel.DESCRIZIONE = Notes;
            //  organiserFormRequestModel.LABEL = Internal;
            //organiserFormRequestModel.STATO = Status;
            organiserFormRequestModel.STARTIME = Startdate;
            organiserFormRequestModel.ENDTIME = EndDate;
            organiserFormRequestModel.SYS_OWNER = User;
            organiserFormRequestModel.SYS_DTCREAZ = DateTime.UtcNow;


        }
        

        private void ShowHiddenRow0CommandTap(object obj)
        {
            SLRow1 = !SLRow1;
        }

        private void ShowHiddenRow1CommandTap(object obj)
        {
            SLRow0 = !SLRow0;
        }
    }
}
