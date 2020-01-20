using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JumpAPP.Controls
{
    public class ExtendedViewCell : ViewCell
    {
        public static readonly BindableProperty SelectedItemBackgroundColorProperty = BindableProperty.Create("SelectedItemBackgroundColor", typeof(Color), typeof(ExtendedViewCell));  
        public Color SelectedItemBackgroundColor
        {
            get
            {
                return (Color)GetValue(SelectedItemBackgroundColorProperty);
            }
            set
            {
                SetValue(SelectedItemBackgroundColorProperty, value);
            }
        }
    }
}
