using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageExercise : ContentPage
	{
	    private int _currentImageId = 1;

	    public ImageExercise ()
		{
			InitializeComponent ();
		    _currentImageId = 1;

            LoadImage();
		}

	    void LoadImage()
	    {
	        image.Source = new UriImageSource
	        {
	            Uri = new Uri(String.Format("http://lorempixel.com/1920/1080/city/{0}", _currentImageId)),
	            CachingEnabled = false
	        };
	    }

        void PreviousClick()
	    {
	        _currentImageId--;
	        if (_currentImageId == 0)
	            _currentImageId = 10;
            LoadImage();   
	    }

	    void NextClick()
	    {
	        _currentImageId++;
	        if (_currentImageId == 11)
	            _currentImageId = 1;
            LoadImage();
	    }
	}
}