
using JumpAPP.Controls;
using Xamarin.Forms;
using JumpAPP.Droid.Renderers;
using Xamarin.Forms.Platform.Android;
using Android.Content;

[assembly: ExportRenderer(typeof(DatePickerCtrl), typeof(DatePickerCtrlRenderer))]
namespace JumpAPP.Droid.Renderers
{
    public class DatePickerCtrlRenderer : DatePickerRenderer
    {
        public DatePickerCtrlRenderer(Context context) : base(context) { }

        public static void Init()
        {
            //No init needed
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.DatePicker> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;

                var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                layoutParams.SetMargins(0, 0, 0, 0);
                LayoutParameters = layoutParams;
                Control.LayoutParameters = layoutParams;
                Control.SetPadding(0, 0, 0, 0);
                SetPadding(0, 0, 0, 0);
            }
        }

    }
}

