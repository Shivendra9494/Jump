using JumpAPP.Models;
using JumpAPP.Models.WebResponse;
using JumpAPP.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace JumpAPP
{
    public partial class App : Application
    {
        public static string accesstoken = "";
        public static string expiresTime = "";
        public static string IssuedTime = "";
        public static string tokentype = "";
        public static string username = "";
        public static string Name = "";
        public static string COName = "";
        public static string Email = "";
        public static string NameCoome = "";

        public static List<ContactResponseModel> contactResponse;
        public static List<CompanyResponseModel> companyResponse;
        public static List<AppointmentResponseModel> AppointmentResponse;
        public string Response;
        public static List<CompanyNoteResponseModel> ContactNote;
        public App()
        {
            // InitializeComponent();
            
           
            
            //MainPage = new NavigationPage(new MainPage());
            //  Current.MainPage.Navigation.PushAsync(new MainPage()); 
            Current.MainPage = new CompanyCodePage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
