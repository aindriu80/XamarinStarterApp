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
	public partial class MainPage6 : ContentPage
	{
		public MainPage6 ()
		{
			InitializeComponent ();
		}

	    private void Cell_OnTapped(object sender, EventArgs e)
	    {
	        var page = new ContactMethodsPage();
	        page.ContactMetods.ItemSelected += (source, args) =>
	        {
	            contactMethod.Text = args.SelectedItem.ToString();
	            Navigation.PopAsync();
	        };


            Navigation.PushAsync(page);
	    }
	}
}