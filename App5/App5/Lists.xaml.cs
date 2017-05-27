using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App5.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Lists : ContentPage
	{
		public Lists ()
		{
			InitializeComponent ();



		    listView.ItemsSource = new List<ContactGroup>
		    {
                new ContactGroup("A", "A")
                {
                    new Contact {Name = "Aindriu", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                },
                new ContactGroup("J","J")
                {
                    new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!"}
                }
		        

		    };
		}

	    private void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
	    {
	       var contact = e.Item as Contact;
	        DisplayAlert("Tapped", contact.Name, "OK");
	    }

	    private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	    {
	       var contact = e.SelectedItem as Contact;
	        DisplayAlert("Selected", contact.Name, "OK");
	    }
	}
}