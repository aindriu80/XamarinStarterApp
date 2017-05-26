using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImagePage : ContentPage
	{
		public ImagePage ()
		{
			InitializeComponent ();
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/7/") };
            imageSource.CachingEnabled = false;
            image.Source = imageSource;
            image.Source = ImageSource.FromResource("App5.Droid.Images.background.jpg");

		}
	}
}