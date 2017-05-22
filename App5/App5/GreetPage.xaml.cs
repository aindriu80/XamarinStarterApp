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
	public partial class GreetPage : ContentPage
	{
	    public GreetPage()
	    {
	        InitializeComponent();
	        slider.Value = 0.5;

	        var x = new OnPlatform<Thickness>
	        {
                Android = new Thickness(),
                iOS = new Thickness(0,20,0,0)
	        };

	    }


	}
}