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
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

	   async void Handle_Clicked(object sender, EventArgs e)
	    {
	        await Navigation.PushModalAsync(new ListExercisePage());
	    }

	    protected override bool OnBackButtonPressed()
	    {
	        return true;
	    }
	}
}