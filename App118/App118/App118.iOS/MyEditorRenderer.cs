using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App118.iOS;
using Foundation;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(Editor), typeof(MyEditorRenderer))]
namespace App118.iOS
{
    public class MyEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            Control.TintColor = UIColor.White;

        }
    }
}