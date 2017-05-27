using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	    List<Contact> GetContacts()
	    {
	        return new List<Contact>
	        {
	            new Contact {Name = "Aindriu", ImageUrl = "http://lorempixel.com/100/100/people/1"},
	            new Contact {Name = "John", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hey, let's talk!"}
            };
	    }

	    private ObservableCollection<Contact> _contacts;
		public Lists ()
		{
			InitializeComponent ();
		    listView.ItemsSource = GetContacts();
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

	    private void Call_Clicked(object sender, EventArgs e)
	    {
	        var menuItem = sender as MenuItem;
	        var contact = menuItem.CommandParameter as Contact;

	        DisplayAlert("Call", contact.Name, "OK");

	    }

	    private void Delete_Clicked(object sender, EventArgs e)
	    {
	        var contact = (sender as MenuItem).CommandParameter as Contact;
	        _contacts.Remove(contact);
	    }

	    private void Handle_Refreshing(object sender, EventArgs e)
	    {
	        listView.ItemsSource = GetContacts();
            listView.EndRefresh();
	    }
	}
}