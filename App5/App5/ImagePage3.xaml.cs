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
	public partial class ImagePage3 : ContentPage
	{
		public ImagePage3 ()
		{
			InitializeComponent ();

		    btn.Image =(FileImageSource) ImageSource.FromFile(Device.OnPlatform(
                iOS:"clock.png",
                Android:"clock.png",
                WinPhone:"Image/clock.png"
                ));
		}
	}
}