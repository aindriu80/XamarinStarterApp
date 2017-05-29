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
	public partial class MainPage5 : ContentPage
	{
		public MainPage5 ()
		{
			InitializeComponent ();
		}

	    private void Switch_OnToggled(object sender, ToggledEventArgs e)
	    {
	        label.IsVisible = e.Value;
	    }

	    private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        var go = e.OldValue;
	    }
	}
}