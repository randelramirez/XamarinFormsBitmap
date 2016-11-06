using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsBitmap
{
    public class WebBitmapCodePage : ContentPage
    {
        public WebBitmapCodePage()
        {
            string uri = "http://developer.xamarin.com/demo/IMG_1415.JPG";

            //Content = new Image
            //{
            //    Source = ImageSource.FromUri(new Uri(uri)),
            //};

            //Content = new Image
            //{
            //    Source = new UriImageSource { Uri = new Uri("https://developer.xamarin.com/demo/IMG_1415.JPG") }
            //};

            Content = new Image
            {
                Source = "https://developer.xamarin.com/demo/IMG_1415.JPG"
                //Source = "https://developer.xamarin.com/demo/IMG_1415.JPG?width=25"
            };
        }
    }
}
