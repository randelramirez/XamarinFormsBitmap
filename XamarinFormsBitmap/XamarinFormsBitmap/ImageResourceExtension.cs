using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsBitmap
{
    /*
        You cannot move this ImageResourceExtension class to a library such as Xama-rin.FormsBook.Toolkit. 
        The class must be part of the same assembly that contains the embedded re-sources you want to load, 
        which is generally the application’s Portable Class Library. 
    */
    [ContentProperty("Source")]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            return ImageSource.FromResource(Source);
        }
    }
}
