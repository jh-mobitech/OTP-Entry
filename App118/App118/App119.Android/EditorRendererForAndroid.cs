using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App119.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Editor), typeof(EditorRendererForAndroid))]
namespace App119.Droid
{
    public class EditorRendererForAndroid : EditorRenderer
    {
        public EditorRendererForAndroid(Context context) : base(context)
        {

        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            Control.SetCursorVisible(false);
            Control.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }
    }
}