using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace JumpAPP.Controls
{
    public class CustomWebView : WebView
    {
        public ICommand PannedCommand
        {
            set { SetValue(PannedCommandProperty, value); }
            get { return (ICommand)GetValue(PannedCommandProperty); }
        }
        public static readonly BindableProperty PannedCommandProperty = BindableProperty.Create(nameof(PannedCommand), typeof(ICommand), typeof(CustomWebView));
    }
    public enum PannedDirection
    {
        Left,
        Right
    }
}
