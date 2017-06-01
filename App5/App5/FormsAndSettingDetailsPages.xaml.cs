using App5.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FormsAndSettingDetailsPages : ContentPage
	{
	    public event EventHandler<ContactDetail> ContactAdded;
	    public event EventHandler<ContactDetail> ContactUpdated;

        public FormsAndSettingDetailsPages (ContactDetail contact)
		{
			 
		    if (contact == null)
		        throw new ArgumentException(nameof(contact));

		    InitializeComponent();

		    BindingContext = new ContactDetail
		    {
		        Id = contact.Id,
		        FirstName = contact.FirstName,
		        LastName = contact.LastName,
		        Phone = contact.Phone,
		        Email = contact.Email,
		        IsBlocked = contact.IsBlocked
		    };
        }

	    async void Save_OnClicked(object sender, EventArgs e)
	    {
	        var contact = BindingContext as ContactDetail;

	        if (String.IsNullOrWhiteSpace(contact.FullName))
	        {
	            await DisplayAlert("Error", "Please enter the name.", "OK");
	            return;
	        }

	        if (contact.Id == 0)
	        {
	            contact.Id = 1;
	            ContactAdded?.Invoke(this, contact);
	        }
	        else
	        {
	            ContactUpdated?.Invoke(this, contact);
	        }
	        await Navigation.PopAsync();

	    }
    }
}