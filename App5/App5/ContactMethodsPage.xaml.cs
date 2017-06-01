using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMethodsPage : ContentPage
	{
		public ContactMethodsPage ()
		{
			InitializeComponent ();

		    ListView2.ItemsSource = new List<string>
		    {
		        "None",
		        "Email",
		        "SMS"
		    };
        }

        public ListView ContactMetods { get { return ListView2; } }
	}
}