using Android.Graphics.Drawables;
using AndroidX.AppCompat.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndroidEntryBackgroundChangeSample.Handlers
{
    public partial class CustomEntryHandler
    {
        protected override AppCompatEditText CreatePlatformView()
        {
            AppCompatEditText native = base.CreatePlatformView();
            GradientDrawable gd = new GradientDrawable();
            gd.SetCornerRadius(10);
            gd.SetStroke(2, Android.Graphics.Color.Violet);
            native.Background = gd;
            return native;
        }
    }
}
