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
	public partial class FormsAndSettingPages : ContentPage
	{
	    private ObservableCollection<ContactDetail> _contacts;


	    public FormsAndSettingPages ()
		{
            InitializeComponent();

		    _contacts = new ObservableCollection<ContactDetail>
		    {
		        new ContactDetail { Id = 1, FirstName = "John", LastName = "Smith", Email = "john@smith.com", Phone = "1111" },
		        new ContactDetail { Id = 2, FirstName = "Mary", LastName = "Johnson", Email = "mary@johnson.com", Phone = "2222" }
		    };

		    contacts.ItemsSource = _contacts;
        }


	    async void MenuDelete_OnClicked(object sender, EventArgs e)
	    {
	        var contact = (sender as MenuItem).CommandParameter as ContactDetail;

	        if (await DisplayAlert("Warning", $"Are you sure you want to delete {contact.FullName}?", "Yes", "No"))
	            _contacts.Remove(contact);
        }

	    async void Add_OnClicked(object sender, EventArgs e)
	    {
	      var page = new FormsAndSettingDetailsPages(new ContactDetail());
	        page.ContactAdded += (source, contact) =>
	        {
	            _contacts.Add(contact);
	        };
	        await Navigation.PushAsync(page);
	    }

	   async void Contact_Selected(object sender, SelectedItemChangedEventArgs e)
	   {
	       if (contacts.SelectedItem == null)
	           return;

	       var selectedContact = e.SelectedItem as ContactDetail;

	       contacts.SelectedItem = null;
            var page = new FormsAndSettingDetailsPages(selectedContact);
	       page.ContactUpdated += (source, contact) =>
	       {
	           selectedContact.Id = contact.Id;
	           selectedContact.FirstName = contact.FirstName;
	           selectedContact.LastName = contact.LastName;
	           selectedContact.Phone = contact.Phone;
	           selectedContact.Email = contact.Email;
	           selectedContact.IsBlocked = contact.IsBlocked;
           };
	       await Navigation.PushAsync(page);

	   }
	}
}