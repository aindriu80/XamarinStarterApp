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
	public partial class MainPage3 : CarouselPage
	{
		public MainPage3 ()
		{
			InitializeComponent ();

		}

	    async void Handle_Clicked(object sender, EventArgs e)
	    {
            // simple dialog box

	        //var response = await DisplayAlert("Warning","Are you sure?","Yes","No");
	        //if (response)
	        //    DisplayAlert("Done", "Your response will be saved!", "OK");

            //action sheet
	       var response = await DisplayActionSheet("Title", "Cancel","Delete","Copy Link","Message","Email");
	       await DisplayAlert("Response", response, "OK");

	    }
	}
}