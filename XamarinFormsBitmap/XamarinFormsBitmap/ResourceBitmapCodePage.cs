using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsBitmap
{
    public class ResourceBitmapCodePage : ContentPage
    {
        public ResourceBitmapCodePage()
        {
            /*
             A bitmap is not stretched to fill its container if:
                 it is smaller than the container, and
                 the VerticalOptions and HorizontalOptions properties of the Image element are not set to Fill, or if Image is a child of a StackLayout.
             */
            Content = new Image
            {
                Source = ImageSource.FromResource(
                             "XamarinFormsBitmap.Images.ModernUserInterface256.jpg"),
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center
            };
        }
    }
}
