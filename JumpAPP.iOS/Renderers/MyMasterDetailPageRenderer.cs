using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

using Foundation;
using JumpAPP.iOS.Renderers;
using JumpAPP.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(OrganizerPage), typeof(MyMasterDetailPageRenderer))]
namespace JumpAPP.iOS.Renderers
{
    public class MyMasterDetailPageRenderer : MyPhoneMasterDetailRenderer
    {
    }
}