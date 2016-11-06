using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormsBitmap
{
    public class App : Application
    {
        public App()
        {
            //MainPage = new WebBitmapCodePage();
            //MainPage = new WebBitmapXaml();
            //MainPage = new ResourceBitmapCodePage();
            MainPage = new ResourceBitmapXamlPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
