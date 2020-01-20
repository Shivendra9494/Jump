using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JumpAPP.Controls
{
   public class EntryCustom : Entry
    {
        public static readonly BindableProperty BorderColorProperty =
      BindableProperty.Create(nameof(BorderColor),
          typeof(Color), typeof(CustomEntry), Color.Gray);
        // Gets or sets BorderColor value  
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
    }
}
