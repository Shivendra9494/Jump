using JumpAPP.Controls;
using JumpAPP.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.ViewModels
{
    public class WeekDayViewModel : ViewModelBase
    {
        private DateTime currentTime = DateTime.Now;
        public ICommand OrganiserTap { get; private set; }
        public ICommand DropdownTap { get; private set; }
        public ICommand PannedCommand { get; private set; }
        public WeekDayViewModel()
        {
            OrganiserTap = new Command(OrganiserTappedS);
            DropdownTap = new Command(DropdownTapped);

            WeekDayAgenda = GetHtmlString();

            if (App.AppointmentResponse != null)
            {

            }
            PannedCommand = new Command<PannedDirection>((e) =>
            {
                if (e == PannedDirection.Left)
                {
                    currentTime = currentTime.AddDays(7);
                    WeekDayAgenda = GetHtmlString();
                }
                else if (e == PannedDirection.Right)
                {
                    currentTime = currentTime.AddDays(-7);
                    WeekDayAgenda = GetHtmlString();
                }
            });
        }

        private string _username = App.NameCoome;           

        public string Username
        {
            get { return _username; }
            set {
                _username = value;
                NotifyPropertyChanged("Username");
            }
        }


        private string GetHtmlString()
        {
            string htmlDay = "";
            string fullDayName = "";
            string shortDayName = "";

            var currentDay = currentTime;
            for (int i = 0; i < 7; i++)
            {
                htmlDay += currentDay.Day.ToString() + (i != 6 ? "," : string.Empty);
                switch (currentDay.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        fullDayName += "'MON'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'M'" + (i != 6 ? "," : string.Empty);
                        break;
                    case DayOfWeek.Tuesday:
                        fullDayName += "'TUE'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'D'" + (i != 6 ? "," : string.Empty);
                        break;
                    case DayOfWeek.Wednesday:
                        fullDayName += "'WED'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'M'" + (i != 6 ? "," : string.Empty);
                        break;
                    case DayOfWeek.Thursday:
                        fullDayName += "'THU'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'D'" + (i != 6 ? "," : string.Empty);
                        break;
                    case DayOfWeek.Friday:
                        fullDayName += "'FRI'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'F'" + (i != 6 ? "," : string.Empty);
                        break;
                    case DayOfWeek.Saturday:
                        fullDayName += "'SAT'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'S'" + (i != 6 ? "," : string.Empty);
                        break;
                    case DayOfWeek.Sunday:
                        fullDayName += "'SUN'" + (i != 6 ? "," : string.Empty);
                        shortDayName += "'S'" + (i != 6 ? "," : string.Empty);
                        break;
                }
                currentDay = currentDay.AddDays(1);
            }

            string html = @"<!doctype html>
<html>
  <head>
      <title>hcal test</title>
      <meta charset='utf-8'>
      <meta name='viewport' content='width=device-width, initial-scale=1.0, minimum-scale=1.0, maximum-scale=1.0, user-scalable=no'>
    
  </head>
  <style type='text/css'>
  
html {
  font-family: sans-serif; 
  -ms-text-size-adjust: 100%; 
  -webkit-text-size-adjust: 100%;
}


body {
  margin: 0;
}



article,
aside,
details,
figcaption,
figure,
footer,
header,
hgroup,
main,
menu,
nav,
section,
summary {
  display: block;
}



audio,
canvas,
progress,
video {
  display: inline-block;
  vertical-align: baseline; 
}



audio:not([controls]) {
  display: none;
  height: 0;
}



[hidden],
template {
  display: none;
}



a {
  background-color: transparent;
}


a:active,
a:hover {
  outline: 0;
}



abbr[title] {
  border-bottom: 1px dotted;
}



b,
strong {
  font-weight: bold;
}



dfn {
  font-style: italic;
}


h1 {
  font-size: 2em;
  margin: 0.67em 0;
}


mark {
  background: #ff0;
  color: #000;
}



small {
  font-size: 80%;
}



sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sup {
  top: -0.5em;
}

sub {
  bottom: -0.25em;
}


img {
  border: 0;
}



svg:not(:root) {
  overflow: hidden;
}



figure {
  margin: 1em 40px;
}



hr {
  -moz-box-sizing: content-box;
  box-sizing: content-box;
  height: 0;
}



pre {
  overflow: auto;
}



code,
kbd,
pre,
samp {
  font-family: monospace, monospace;
  font-size: 1em;
}



button,
input,
optgroup,
select,
textarea {
  color: inherit; 
  font: inherit; 
  margin: 0; 
}


button {
  overflow: visible;
}


button,
select {
  text-transform: none;
}



button,
html input[type='button'], 
input[type='reset'],
input[type='submit'] {
  -webkit-appearance: button; 
  cursor: pointer; 
}



button[disabled],
html input[disabled] {
  cursor: default;
}



button::-moz-focus-inner,
input::-moz-focus-inner {
  border: 0;
  padding: 0;
}



input {
  line-height: normal;
}



input[type='checkbox'],
input[type='radio'] {
  box-sizing: border-box; 
  padding: 0; 
}



input[type='number']::-webkit-inner-spin-button,
input[type='number']::-webkit-outer-spin-button {
  height: auto;
}



input[type='search'] {
  -webkit-appearance: textfield; 
  -moz-box-sizing: content-box;
  -webkit-box-sizing: content-box; 
  box-sizing: content-box;
}

/

input[type='search']::-webkit-search-cancel-button,
input[type='search']::-webkit-search-decoration {
  -webkit-appearance: none;
}


fieldset {
  border: 1px solid #c0c0c0;
  margin: 0 2px;
  padding: 0.35em 0.625em 0.75em;
}


legend {
  border: 0; 
  padding: 0; 
}



textarea {
  overflow: auto;
}



optgroup {
  font-weight: bold;
}



table {
  border-collapse: collapse;
  border-spacing: 0;
}

td,
th {
  padding: 0;
}
  </style>
  <style type='text/css'>
  

html{
  width:99.6%;
  height:100%;
}

body{
  width:100%;
  height:100%;
  overflow-x: hidden;
}

body{
  color: #333;
}

#content{
  width:100%;
  height:100%;
}

.hcal{
  font-size:20px;
  font-family:'HelveticaNeue-Light', 'Helvetica Neue Light', 'Helvetica Neue', Helvetica,  arial, sans-serif;
  background:#fff;
  position:relative;
}

.hcal, .hcal > .hcal-header, .hcal > .hcal-body, .hcal > .hcal-body > .hcal-body-row{
  width:100%;
  
}
.hcal-body{
  MARGIN-TOP: 20PX;
}


.hcal .hcal-header{
  background-color: #F2F2F2;  
  padding:10px 0 0;
  border-bottom:1px solid #ddd;
  text-align:center;
}

.hcal .hcal-header-days{
  font-size:12px;
  font-weight: bold;
}

.hcal .hcal-header-days, .hcal .hcal-header-dates{
  display:-webkit-flex;
  display:flex;
}

.hcal .hcal-header-dates{
  margin-top:
  
}

.hcal .hcal-header-date{
  color: #333;
  
}

.hcal .hcal-header-day, .hcal .hcal-header-date{
  width:15%;
  text-align:center;
  color: #595958;
}

.hcal .hcal-header-date-inner{
  display:inline-block;
  border-radius:200px;
  background: transparent;
  width: 30px;
  height: 25px;
  text-align: center;
  padding-top: 6px;
  font-size: 13px;
  line-height: 20px;
}

.hcal .hcal-header-date-inner.active{
  background: #A1C51E;
  color:#fff;
}

.hcal .hcal-header-today{
  margin-top:10px;
  font-size:15px;
}



.hcal-body .hcal-body-row{
  height: 50px;
}

.hcal-body .hcal-body-row-time{
  margin-top:5px;
  margin-left:8px;
  font-size:12px;
  text-transform: uppercase;
  color: #A4A4A4;
}

.hcal-body .hcal-body-row-hr{
  margin-top:-30px;
  margin-left:10px;
  border:0;
  width: 93%;
}
.hcal-body-row:not(:nth-child(1)) .hcal-body-row-hr{
  border-bottom:1px solid rgba(163, 199, 35, 1);
}
.hcal .hcal-body-row-item{
  overflow:hidden;
  text-overflow: ellipsis;
  background-color: rgba(100,100,100,0.6);  
  right:0;
  position:absolute;
  left:100px;
  margin-top:-10px;  
  height:55px;
  width: calc(100% - 112px);
  border-radius: 10px;
  padding: 5px;
  padding-left: 10px;
  box-sizing: border-box;
}

.hcal .hcal-body-row-item .hcal-body-row-item-headline, .hcal .hcal-body-row-item .hcal-body-row-item-text{
  color:#6A6F6E;
  margin-left:5px;
}

.hcal .hcal-body-row-item .hcal-body-row-item-headline{
  font-size:14px;
  margin-top:2px;
  margin-bottom:0px;
  line-height:16px;
  padding-right:5px;
  letter-spacing: -0.75px;
  font-family:'Helvetica Neue', Helvetica,  arial, sans-serif;
}

.hcal .hcal-body-row-item .hcal-body-row-item-headline *{
  font-family:'HelveticaNeue-Light', 'Helvetica Neue Light', 'Helvetica Neue', Helvetica,  arial, sans-serif;
}

.hcal .hcal-body-row-item .hcal-body-row-item-text{
  font-size:13px;
  line-height:17px;
  height:100%;
  bottom:0;
  top:0px;
  margin-top:2px;
  padding-right:5px;
  font-weight: bold;
}

.hcal .hcal-body-row-item .hcal-item-nr{

  letter-spacing:normal;
}

.hcal .hcal-body-item-color01{background-color: rgba(235, 254, 255, 1);}
.hcal .hcal-body-item-color02{background-color: rgba(255, 212, 202, 1);}
.hcal .hcal-body-item-color03{background-color: rgba(196, 223, 155, 1);}
.hcal .hcal-body-item-color04{background-color: rgba(210, 210, 255,1);}

.hcal .hcal-duration-1h{height:45px}
.hcal .hcal-duration-2h{height:98px}
.hcal .hcal-duration-3h{height:151px}
.hcal .hcal-duration-4h{height:204px}
.hcal .hcal-duration-5h{height:257px}
.hcal .hcal-duration-6h{height:310px}
.hcal .hcal-duration-7h{height:363px}
.hcal .hcal-duration-8h{height:416px}
.hcal .hcal-duration-9h{height:469px}
.hcal .hcal-duration-10h{height:522px}
.hcal .hcal-duration-11h{height:575px}
.hcal .hcal-duration-12h{height:628px}
.hcal .hcal-duration-13h{height:681px}
.hcal .hcal-duration-14h{height:734px}
.hcal .hcal-duration-15h{height:787px}
.hcal .hcal-duration-16h{height:840px}
.hcal .hcal-duration-17h{height:893px}
.hcal .hcal-duration-18h{height:946px}
.hcal .hcal-duration-19h{height:999px}
.hcal .hcal-duration-20h{height:1052px}
.hcal .hcal-duration-21h{height:1105px}
.hcal .hcal-duration-22h{height:1158px}
.hcal .hcal-duration-23h{height:1211px}
.hcal .hcal-duration-24h{height:1264px}
  </style>

  <body>
    <div id='content'></div>
     <script src='https://code.jquery.com/jquery-2.1.3.min.js' integrity='sha256-ivk71nXhz9nsyFDoYoGf2sbjrR9ddh+XDkCcfZxjvcM=' crossorigin='anonymous'></script>

     <script type='text/javascript'>
	


(function ($) {
  'use strict';
  
  var $container,
    $hcal,
    $hcalHeader,
    $hcalBody;

  
  function createHcalHeader(dates, markerpos, today, format) {
    var $header = $('<div class=\'hcal-header\'>'),
      i = 0,
      $days = $('<div class=\'hcal-header-days\'>').appendTo($header),
      $dates = $('<div class=\'hcal-header-dates\'>').appendTo($header),
      $day,
      $date,
      $dateInner,
      $today,
      days = format === 'ger' ? [";
            html += shortDayName;
            html += "] : [";
            html += fullDayName;
            html += @"],
      date;
    
    for (i = 0; i < dates.length; i = i + 1) {
      $day = $('<div class=\'hcal-header-day\'>').text(days[i]).appendTo($days);
      $date = $('<a href=\'javascript:void(0);\' class=\'hcal-header-date\'>').appendTo($dates);
      $dateInner = $('<div class=\'hcal-header-date-inner\'>').text(dates[i]).appendTo($date);
      if (i === markerpos) {
        $dateInner.addClass('active');
      }
    }
    
    $today = $('<div class=\'hcal-header-today\'>').text(today).appendTo($header);
    
    return $header;
  }
  
  
  function createHcalBody(format, starthour) {
    var $body = $('<div class=\'hcal-body\'>'),
      i = 0,
      $row,
      $time,
      $hr,
      timevalue;
    
    for (i = starthour; i < 12; i = i + 1) {

      timevalue = format === 'ger' ? i + ':00' : (i % 12) + (i < 12 ? ' pm' : ' am');
      if (format !== 'ger') {
       
        timevalue = i === 0 ? '12 pm' : timevalue;
        timevalue = i === 12 ? '12 pm' : timevalue;
        timevalue = i === 24 ? '12 pm' : timevalue;
      }
      let startTime=timevalue;
      let endTime=parseInt(timevalue)+1;
      
      if(timevalue!='12 pm'){
        $row = $('<div class=\'hcal-body-row\'>').appendTo($body);
        $time = $('<div class=\'hcal-body-row-time\'>').text(startTime + ' - ' + endTime+' pm').appendTo($row);
        $hr = $('<div class=\'hcal-body-row-hr\'>').appendTo($row);
      }
     
    }
    
    return $body;
  }
  
  
  function init(el, dates, markerpos, today, format, starthour) {
    $container = el;
    $hcal = $('<div class=\'hcal\'>');
    
    $hcalHeader = createHcalHeader(dates, markerpos, today, format).appendTo($hcal);
    $hcalBody = createHcalBody(format, starthour).appendTo($hcal);
    
    $hcal.appendTo($container);
  }
 
  $.fn.addHcalAppointment = function (position, duration, title, place, desc, color) {
    var $row = $hcalBody.children('.hcal-body-row:nth-child(\' + (position + 1) + \')'),
      $item = $('<div class=\'hcal-body-row-item\'>'),
      $headline = $('<h3 class=\'hcal-body-row-item-headline\'>').appendTo($item),
      $desc = $('<div class=\'hcal-body-row-item-text\'>').text(desc).appendTo($item),
      rgbaStringFull,
      rgbaStringTransparent;
    
    
    $headline.html(title + '<span class=\'hcal-item-nr\'>  ' + place + '</span>');
    
    
    $item.addClass('hcal-duration-' + duration + 'h');
    
   
    if (Object.prototype.toString.call(color) === '[object Array]') {
      rgbaStringFull = 'rgba(' + color[0] + ', ' + color[1] + ', ' + color[2] + ', 1)';
      rgbaStringTransparent = 'rgba(' + color[0] + ', ' + color[1] + ', ' + color[2] + ', 1)';
      $item.css({
        'background': rgbaStringTransparent,        
      });
    } else {
      $item.addClass('hcal-body-item-color0' + color);
    }
    
    $item.prependTo($row);
    
    return this;
  };

  
  $.fn.hcal = function (dates, markerpos, today, format, starthour=0) {
    init(this, dates, markerpos, today, format, starthour);
    return this;
  };

}(jQuery));

	 </script>

    
    <script>
      $(document).ready(function () {
        var dates = [";
            // Dates here
            html += htmlDay;
            html += @"];
        var $hcal = $('#content').hcal(dates, 1, '', 'us');
        
        $hcal.addHcalAppointment(0, 1, 'Adam Smith', '', 'Techno Sunday', 1);
        $hcal.addHcalAppointment(1, 1, 'Adam Smith', '', 'Techno Sunday', 2);
        $hcal.addHcalAppointment(2, 1, 'Adam Smith', '', 'Techno Sunday', 3);
        $hcal.addHcalAppointment(3, 1, 'Adam Smith', '', 'Techno Sunday', 4);
       
      });

      $(document).ready(function () {
        $('.hcal-header-date-inner').click(function(){                          
          $('.hcal-header-date-inner').removeClass('active');
          $(this).addClass('active');            
        });
      });
    </script>
    
  </body>

</html>";
            return html;
        }

        private string _weekDayAgenda;
        public string WeekDayAgenda
        {
            get
            {
                return _weekDayAgenda;
            }
            set
            {
                _weekDayAgenda = value;
                NotifyPropertyChanged("WeekDayAgenda");
            }
        }
        private bool _mail = false;
        public bool mail
        {
            get
            {
                return _mail;
            }
            set
            {
                _mail = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("mail");
            }
        }
        private bool _pdf = false;
        public bool pdf
        {
            get
            {
                return _pdf;
            }
            set
            {
                _pdf = value;
                //RaisePropertyChanged();
                NotifyPropertyChanged("pdf");
            }
        }

        private void OrganiserTappedS(object obj)
        {
            Application.Current.MainPage.Navigation.PushModalAsync(new OrgamiserFormPage());
            //App.Current.MainPage = new CompanyContactPage();
            // Application.Current.MainPage.Navigation.PushAsync(new CompanyBranchPage());

        }

        private void DropdownTapped(object obj)
        {
            mail = !mail;
            pdf = !pdf;

        }
    }
}
