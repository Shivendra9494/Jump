using JumpAPP.Popup;
using JumpAPP.ViewModels;
using Rg.Plugins.Popup.Services;
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
    public partial class OrganizerPageDetail : ContentPage
    {
        private DateTime currentDateTime = DateTime.Now;
        private DateTime selectedDate = DateTime.Now;
        private double minuteMultiplier = (5.0f / 3.0f);
        public OrganizerPageDetail()
        {
            InitializeComponent();
            // stack.HeightRequest = Application.Current.MainPage.Height;
            //browser.HeightRequest = Application.Current.MainPage.Height;
            BindingContext = new WeekDayViewModel();

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CreateDayView(currentDateTime);
            scrollStack.Content = CreateGrid(currentDateTime);
        }

        public void CreateDayView(DateTime date)
        {
            if (date.Date.Equals(DateTime.Now.Date))
            {
                firstDate.BackgroundColor = Color.FromHex("#A1C51E");
                firstDate.TextColor = Color.White;
            }

            firstDayOfWeek.Text = GetDayTxt(date.DayOfWeek);
            firstDate.Text = date.Day.ToString();

            secondDayOfWeek.Text = GetDayTxt(date.AddDays(1).DayOfWeek);
            secondDate.Text = date.AddDays(1).Day.ToString();

            thirdDayOfWeek.Text = GetDayTxt(date.AddDays(2).DayOfWeek);
            thirdDate.Text = date.AddDays(2).Day.ToString();

            fourthDayOfWeek.Text = GetDayTxt(date.AddDays(3).DayOfWeek);
            fourthDate.Text = date.AddDays(3).Day.ToString();

            fifthDayOfWeek.Text = GetDayTxt(date.AddDays(4).DayOfWeek);
            fifthDate.Text = date.AddDays(4).Day.ToString();

            sixthDayOfWeek.Text = GetDayTxt(date.AddDays(5).DayOfWeek);
            sixthDate.Text = date.AddDays(5).Day.ToString();

            seventhDayOfWeek.Text = GetDayTxt(date.AddDays(6).DayOfWeek);
            seventhDate.Text = date.AddDays(6).Day.ToString();
            //stack.Children.Add(btn);
            //return stack;
        }

        public Label CreateLbl(string text = "")
        {

            return new Label
            {
                Text = text,
                BackgroundColor = Color.White,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#6A6F6E")
            };
        }

        public Grid CreateGrid(DateTime date)
        {
            Grid grid = new Grid
            {
                BackgroundColor = Color.FromHex("#A1C51E"),
                RowSpacing = 1,
                ColumnSpacing = 0
            };

            // Row Definition
            for (int i = 1; i < 25; i++)
                grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(70, GridUnitType.Absolute) });

            // Column Definition
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(150, GridUnitType.Absolute) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            for (int i = 1; i < 25; i++)
            {
                var lbl0 = new Label
                {
                    Text = i <= 12 ? ((i - 1 == 0 ? 12 : i - 1).ToString() + ":00 AM - " + (i == 12 ? i.ToString() + ":00 PM" : i.ToString() + ":00 AM")) :
                                     ((i - 13 == 0 ? 12 : i - 13).ToString() + ":00 PM - " + (i - 12).ToString() + ":00 PM"),
                    BackgroundColor = Color.White,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand,
                    FontAttributes = FontAttributes.Bold,
                    TextColor = Color.FromHex("#6A6F6E")
                };
                grid.Children.Add(lbl0, 0, (i - 1));
                var lbl = CreateLbl();
                TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer
                {
                    NumberOfTapsRequired = 1
                };
                tapGestureRecognizer.Tapped += EmptyLabelTapped;
                lbl.GestureRecognizers.Add(tapGestureRecognizer);
                grid.Children.Add(lbl, 1, (i - 1));
            }

            var filteredData = App.AppointmentResponse.Where(x => x.STARTIME.Date == selectedDate.Date);

            foreach (var item in filteredData)
            {
                if (item.ENDTIME.Subtract(item.STARTIME).TotalMinutes != 0)
                {
                    var frame = CreateFrame(item.STARTIME.Minute, item.ENDTIME.Minute, item.USERNAME, item.DESCR_LABEL, Color.LightGreen);
                    grid.Children.Add(frame, 1, item.STARTIME.Hour);
                    if (item.ENDTIME.Hour - item.STARTIME.Hour < 2)
                    {
                        if (item.STARTIME.Minute == 0 && item.ENDTIME.Minute == 0)
                            Grid.SetRowSpan(frame, 1);
                        else
                            Grid.SetRowSpan(frame, 2);
                    }
                    else
                        Grid.SetRowSpan(frame, item.ENDTIME.Hour - item.STARTIME.Hour + 1);
                }
            }
            return grid;
        }

        private async void EmptyLabelTapped(object sender, EventArgs e)
        {
           
            await Navigation.PushModalAsync(new NavigationPage(new OrgamiserFormPage()));
        }
           

        private void OnRightSwipe(object sender, SwipedEventArgs e)
        {
            currentDateTime = currentDateTime.AddDays(-7);
            selectedDate = currentDateTime;
            CreateDayView(currentDateTime);
            scrollStack.Content = CreateGrid(currentDateTime);
        }

        private void OnLeftSwipe(object sender, SwipedEventArgs e)
        {
            currentDateTime = currentDateTime.AddDays(7);
            selectedDate = currentDateTime;
            CreateDayView(currentDateTime);
            scrollStack.Content = CreateGrid(currentDateTime);
        }
        public string GetDayTxt(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    return "SUN";
                case DayOfWeek.Monday:
                    return "MON";
                case DayOfWeek.Tuesday:
                    return "TUE";
                case DayOfWeek.Wednesday:
                    return "WED";
                case DayOfWeek.Thursday:
                    return "THU";
                case DayOfWeek.Friday:
                    return "FRI";
                case DayOfWeek.Saturday:
                    return "SAT";
                default:
                    return "";
            }
        }

        public Frame CreateFrame(double topMargin, double bottomMargin, string headerTxt, string descTxt, Color bgColor)
        {
            Frame frame = new Frame
            {
                BackgroundColor = bgColor,
                CornerRadius = 5,
                Padding = new Thickness(15, 10),
                Margin = new Thickness(5, (topMargin * minuteMultiplier) + 2, 5, (bottomMargin * minuteMultiplier) + 2)
            };

            StackLayout stack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Label headerLbl = new Label
            {
                Text = headerTxt,
                BackgroundColor = Color.Transparent,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#6A6F6E")
            };

            Label descLbl = new Label
            {
                Text = descTxt,
                BackgroundColor = Color.Transparent,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.Start,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center,
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.FromHex("#6A6F6E"),
                Margin = new Thickness(0, 10, 0, 10)
            };

            stack.Children.Add(headerLbl);
            stack.Children.Add(descLbl);
            frame.Content = stack;
            return frame;
        }

        private async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await PopupNavigation.PushAsync(new FilterPopup());
        }

        private void UpdateSelectedDate(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var date = Convert.ToInt32(btn.Text);
            if (date >= currentDateTime.Day)
                selectedDate = currentDateTime.AddDays(date - currentDateTime.Day);
            else
                selectedDate = new DateTime(currentDateTime.Year, currentDateTime.Month + 1, date);

            scrollStack.Content = CreateGrid(currentDateTime);

            firstDate.BackgroundColor = Color.Transparent;
            firstDate.TextColor = Color.FromHex("#6A6F6E");

            secondDate.BackgroundColor = Color.Transparent;
            secondDate.TextColor = Color.FromHex("#6A6F6E");

            thirdDate.BackgroundColor = Color.Transparent;
            thirdDate.TextColor = Color.FromHex("#6A6F6E");

            fourthDate.BackgroundColor = Color.Transparent;
            fourthDate.TextColor = Color.FromHex("#6A6F6E");

            fifthDate.BackgroundColor = Color.Transparent;
            fifthDate.TextColor = Color.FromHex("#6A6F6E");

            sixthDate.BackgroundColor = Color.Transparent;
            sixthDate.TextColor = Color.FromHex("#6A6F6E");

            seventhDate.BackgroundColor = Color.Transparent;
            seventhDate.TextColor = Color.FromHex("#6A6F6E");


            switch (btn.ClassId.ToString())
            {
                case "1":
                    firstDate.BackgroundColor = Color.FromHex("#A1C51E");
                    firstDate.TextColor = Color.White;
                    break;
                case "2":
                    secondDate.BackgroundColor = Color.FromHex("#A1C51E");
                    secondDate.TextColor = Color.White;
                    break;

                case "3":
                    thirdDate.BackgroundColor = Color.FromHex("#A1C51E");
                    thirdDate.TextColor = Color.White;
                    break;

                case "4":
                    fourthDate.BackgroundColor = Color.FromHex("#A1C51E");
                    fourthDate.TextColor = Color.White;
                    break;

                case "5":
                    fifthDate.BackgroundColor = Color.FromHex("#A1C51E");
                    fifthDate.TextColor = Color.White;
                    break;

                case "6":
                    sixthDate.BackgroundColor = Color.FromHex("#A1C51E");
                    sixthDate.TextColor = Color.White;
                    break;

                case "7":
                    seventhDate.BackgroundColor = Color.FromHex("#A1C51E");
                    seventhDate.TextColor = Color.White;
                    break;
            }
        }

        private void MainDatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {


            currentDateTime = e.NewDate;

            selectedDate = currentDateTime;
            CreateDayView(currentDateTime);
            scrollStack.Content = CreateGrid(currentDateTime);
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            MainDatePicker.Focus();
            
        }
    }
}