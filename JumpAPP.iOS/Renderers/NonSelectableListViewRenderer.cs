using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using JumpAPP.Controls;
using JumpAPP.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly: ExportRenderer(typeof(NonSelectableListView), typeof(NonSelectableListViewRenderer))]
namespace JumpAPP.iOS.Renderers
{
    public class NonSelectableListViewRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                // Unsubscribe from event handlers and cleanup any resources
            }

            if (e.NewElement != null)
            {
                // Configure the native control and subscribe to event handlers
                Control.AllowsSelection = false;
            }
        }
    }
}