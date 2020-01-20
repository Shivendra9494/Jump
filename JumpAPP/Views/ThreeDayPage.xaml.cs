using JumpAPP.ViewModels;
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
    public partial class ThreeDayPage : ContentPage
    {
        public ThreeDayPage()
        {
            InitializeComponent();
            stack.HeightRequest = Application.Current.MainPage.Height;
            browser.HeightRequest = Application.Current.MainPage.Height;
            BindingContext = new WeekDayViewModel();
        }

        protected override void OnAppearing()
        {
            var currentDate = DateTime.Now;
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

#contentDay{
  width:100%;
  height:100%;

}

.hcal{
  font-size:20px;
  font-family:'HelveticaNeue-Light', 'Helvetica Neue Light', 'Helvetica Neue', Helvetica,  arial, sans-serif;
  background:#fff;
  position:relative;
}
.hcal::before{
  content: '';
  width: 2px;
  height: 100%;
  background: rgb(238, 238, 238);
  position: absolute;
  left: 60px;
  z-index: 1;
}
.hcal, .hcal > .hcal-header, .hcal > .hcal-body, .hcal > .hcal-body > .hcal-body-row{
  width:100%;
  
}
.hcal-body{
  MARGIN-TOP: 15PX;
}


.hcal .hcal-header{
  background-color: #F2F2F2;  
  padding:10px 0 0 70px;
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
  margin-top:;
  
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
}

.hcal-body .hcal-body-row-hr{
  margin-top:-8px;
  margin-left:53px;
  border:0;
  
}
.hcal-body-row:not(:nth-child(1)) .hcal-body-row-hr{
  border-bottom:1px solid rgba(226, 226, 226, 1);
}
.hcal .hcal-body-row-item{
  overflow:hidden;
  text-overflow: ellipsis;
  background-color: rgba(100,100,100,0.6);  
  right:0;
  position:absolute;
  left:60px;
  margin-top:7px;  
  height:55px;
  display: flex;
  align-items: center;
  padding-left: 10px;
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
}

.hcal .hcal-body-row-item .hcal-item-nr{
  
  letter-spacing:normal;
}

.hcal .hcal-body-item-color01{background-color: rgba(235, 254, 255, 1);}
.hcal .hcal-body-item-color02{background-color: rgba(255, 212, 202, 1);}
.hcal .hcal-body-item-color03{background-color: rgba(196, 223, 155, 1);}
.hcal .hcal-body-item-color04{background-color: rgba(210, 210, 255,1);}

.hcal .hcal-duration-1h{height:55px}
.hcal .hcal-duration-2h{height:110px}
.hcal .hcal-duration-3h{height:165px}
.hcal .hcal-duration-4h{height:220px}
.hcal .hcal-duration-5h{height:275px}
.hcal .hcal-duration-6h{height:330px}
.hcal .hcal-duration-7h{height:385px}
.hcal .hcal-duration-8h{height:440px}
.hcal .hcal-duration-9h{height:495px}
.hcal .hcal-duration-10h{height:550px}
.hcal .hcal-duration-11h{height:605px}
.hcal .hcal-duration-12h{height:660px}
.hcal .hcal-duration-13h{height:715px}
.hcal .hcal-duration-14h{height:770px}
.hcal .hcal-duration-15h{height:825px}
.hcal .hcal-duration-16h{height:880px}
.hcal .hcal-duration-17h{height:935px}
.hcal .hcal-duration-18h{height:990px}
.hcal .hcal-duration-19h{height:1045px}
.hcal .hcal-duration-20h{height:1100px}
.hcal .hcal-duration-21h{height:1155px}
.hcal .hcal-duration-22h{height:1210px}
.hcal .hcal-duration-23h{height:1265px}
.hcal .hcal-duration-24h{height:1320px}
</style>
  <body>
    <div id='contentDay'></div>
    
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
      days = format === 'ger' ? ['S','M', 'D', 'M', 'D', 'F', 'S'] : ['SUN','MON', 'TUS', 'WED', 'THU', 'FRI', 'SAT' ],
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
    
    for (i = starthour; i < 25; i = i + 1) {
      timevalue = format === 'ger' ? i + ':00' : (i % 12) + (i < 12 ? ' am' : ' pm');
      if (format !== 'ger') {
        
        timevalue = i === 0 ? '12 am' : timevalue;
        timevalue = i === 12 ? '12 pm' : timevalue;
        timevalue = i === 24 ? '12 am' : timevalue;
      }
      $row = $('<div class=\'hcal-body-row\'>').appendTo($body);
      $time = $('<div class=\'hcal-body-row-time\'>').text(timevalue).appendTo($row);
      $hr = $('<div class=\'hcal-body-row-hr\'>').appendTo($row);
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
    var $row = $hcalBody.children('.hcal-body-row:nth-child(' + (position + 1) + ')'),
      $item = $('<div class=\'hcal-body-row-item\'>'),
      $headline = $('<h3 class=\'hcal-body-row-item-headline\'>').appendTo($item),
      
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
        var dates = [25];
        var $hcal = $('#contentDay').hcal(dates, 0, '', 'us');
        
        $hcal.addHcalAppointment(0, 1, 'Adam Smith', '', '', 1);
        $hcal.addHcalAppointment(2, 2, 'S Gill', '', '', 2);
        $hcal.addHcalAppointment(5, 1, 'Adam Smith', '', '', 3);
        $hcal.addHcalAppointment(7, 1, 'Adam Smith', '', '', 4);
       
      });

      $(document).ready(function () {
        $('.hcal-header-date-inner').click(function(){                          
          $('.hcal-header-date-inner').removeClass('active');
          $(this).addClass('active');            
        });
      });
    </script>
    
  </body>

</html><!doctype html>

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

#contentDay{
  width:100%;
  height:100%;

}

.hcal{
  font-size:20px;
  font-family:'HelveticaNeue-Light', 'Helvetica Neue Light', 'Helvetica Neue', Helvetica,  arial, sans-serif;
  background:#fff;
  position:relative;
}
.hcal::before{
  content: '';
  width: 2px;
  height: 100%;
  background: rgb(238, 238, 238);
  position: absolute;
  left: 60px;
  z-index: 1;
}
.hcal, .hcal > .hcal-header, .hcal > .hcal-body, .hcal > .hcal-body > .hcal-body-row{
  width:100%;
  
}
.hcal-body{
  MARGIN-TOP: 15PX;
}


.hcal .hcal-header{
  background-color: #F2F2F2;  
  padding:10px 0 0 70px;
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
  margin-top:;
  
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
}

.hcal-body .hcal-body-row-hr{
  margin-top:-8px;
  margin-left:53px;
  border:0;
  
}
.hcal-body-row:not(:nth-child(1)) .hcal-body-row-hr{
  border-bottom:1px solid rgba(226, 226, 226, 1);
}
.hcal .hcal-body-row-item{
  overflow:hidden;
  text-overflow: ellipsis;
  background-color: rgba(100,100,100,0.6);  
  right:0;
  position:absolute;
  left:60px;
  margin-top:7px;  
  height:55px;
  display: flex;
  align-items: center;
  padding-left: 10px;
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
}

.hcal .hcal-body-row-item .hcal-item-nr{
  
  letter-spacing:normal;
}

.hcal .hcal-body-item-color01{background-color: rgba(235, 254, 255, 1);}
.hcal .hcal-body-item-color02{background-color: rgba(255, 212, 202, 1);}
.hcal .hcal-body-item-color03{background-color: rgba(196, 223, 155, 1);}
.hcal .hcal-body-item-color04{background-color: rgba(210, 210, 255,1);}

.hcal .hcal-duration-1h{height:55px}
.hcal .hcal-duration-2h{height:110px}
.hcal .hcal-duration-3h{height:165px}
.hcal .hcal-duration-4h{height:220px}
.hcal .hcal-duration-5h{height:275px}
.hcal .hcal-duration-6h{height:330px}
.hcal .hcal-duration-7h{height:385px}
.hcal .hcal-duration-8h{height:440px}
.hcal .hcal-duration-9h{height:495px}
.hcal .hcal-duration-10h{height:550px}
.hcal .hcal-duration-11h{height:605px}
.hcal .hcal-duration-12h{height:660px}
.hcal .hcal-duration-13h{height:715px}
.hcal .hcal-duration-14h{height:770px}
.hcal .hcal-duration-15h{height:825px}
.hcal .hcal-duration-16h{height:880px}
.hcal .hcal-duration-17h{height:935px}
.hcal .hcal-duration-18h{height:990px}
.hcal .hcal-duration-19h{height:1045px}
.hcal .hcal-duration-20h{height:1100px}
.hcal .hcal-duration-21h{height:1155px}
.hcal .hcal-duration-22h{height:1210px}
.hcal .hcal-duration-23h{height:1265px}
.hcal .hcal-duration-24h{height:1320px}
</style>
  <body>
    <div id='contentDay'></div>
    
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
      days = format === 'ger' ? ['S','M', 'D', 'M', 'D', 'F', 'S'] : ['SUN','MON', 'TUS', 'WED', 'THU', 'FRI', 'SAT' ],
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
    
    for (i = starthour; i < 25; i = i + 1) {
      timevalue = format === 'ger' ? i + ':00' : (i % 12) + (i < 12 ? ' am' : ' pm');
      if (format !== 'ger') {
        
        timevalue = i === 0 ? '12 am' : timevalue;
        timevalue = i === 12 ? '12 pm' : timevalue;
        timevalue = i === 24 ? '12 am' : timevalue;
      }
      $row = $('<div class=\'hcal-body-row\'>').appendTo($body);
      $time = $('<div class=\'hcal-body-row-time\'>').text(timevalue).appendTo($row);
      $hr = $('<div class=\'hcal-body-row-hr\'>').appendTo($row);
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
    var $row = $hcalBody.children('.hcal-body-row:nth-child(' + (position + 1) + ')'),
      $item = $('<div class=\'hcal-body-row-item\'>'),
      $headline = $('<h3 class=\'hcal-body-row-item-headline\'>').appendTo($item),
      
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
        var dates = [25];
        var $hcal = $('#contentDay').hcal(dates, 0, '', 'us');
        
        $hcal.addHcalAppointment(0, 1, 'Adam Smith', '', '', 1);
        $hcal.addHcalAppointment(2, 2, 'S Gill', '', '', 2);
        $hcal.addHcalAppointment(5, 1, 'Adam Smith', '', '', 3);
        $hcal.addHcalAppointment(7, 1, 'Adam Smith', '', '', 4);
       
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
            var htmlSource = new HtmlWebViewSource
            {
                Html = html
            };
            browser.Source = htmlSource;
            base.OnAppearing();
        }

       
    }
}