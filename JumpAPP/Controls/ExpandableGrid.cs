using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace JumpAPP.Controls
{
    class ExpandableGrid : Grid
    {
        static readonly Thickness IconMargin = new Thickness(9, 0);

        View content;
        public View Content
        {
            get => content;
            set
            {
                content = value;
                Children.Add(value, 0, 1);
            }
        }

        Label lblDesc = new Label();
        Label icon = new Label { Text = "V", FontSize=20,  Margin = IconMargin, HorizontalOptions = LayoutOptions.EndAndExpand };

        public string Caption
        {
            set
            {
                lblDesc.Text = value;
                lblDesc.FontSize = 25;
                lblDesc.FontAttributes = FontAttributes.Bold;
               


            }
        }

        public ExpandableGrid()
        {
            RowDefinitions = new RowDefinitionCollection {
                new RowDefinition { Height = GridLength.Auto },
                new RowDefinition { Height = 0 },
            };
            ColumnDefinitions = new ColumnDefinitionCollection {
                new ColumnDefinition { Width = GridLength.Star },
            };
            Children.Add(lblDesc, 0, 0);
            Children.Add(icon, 0, 0);
            lblDesc.GestureRecognizers.Add(new TapGestureRecognizer { Command = new Command(LabelClick) });
        }

        void LabelClick()
        {
            if (RowDefinitions[1].Height.IsAuto)
            {
                RowDefinitions[1].Height = 0;
                icon.Text = ">";
              
            }
            else
            {
                RowDefinitions[1].Height = GridLength.Auto;
                icon.Text = "^";
            }
        }
    }
}
