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
	    private IList<ContactMethod> _contactMethods;
		public MainPage5 ()
		{
			InitializeComponent ();

		    _contactMethods = GetContactMethods();

		    foreach (var method in _contactMethods)
		    {
		        ContactMethods.Items.Add(method.Name);
		    }
		}

	    private IList<ContactMethod> GetContactMethods()
	    {
	        return new List<ContactMethod>
	        {
                new ContactMethod{ Id = 1, Name ="SMS"},
                new ContactMethod{ Id = 2, Name ="Email"}
	        };
	    }

	    private void Switch_OnToggled(object sender, ToggledEventArgs e)
	    {
	        label.IsVisible = e.Value;
	    }

	    private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
	    {
	        var go = e.OldValue;
	    }

	    private void Entry_OnCompleted(object sender, EventArgs e)
	    {
	        PasswordLabel.Text = "Completed";
	    }

	    private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	        PasswordLabel2.Text = e.NewTextValue;
	    }

	    private void Picker_OnSelectedIndexChanged(object sender, EventArgs e)
	    {
	       var name = ContactMethods.Items[ContactMethods.SelectedIndex];
	       var contactMethod = _contactMethods.Single(cm => cm.Name == name);

            DisplayAlert("Selection",name, "OK");
	    }

	    private void DatePicker_OnDateSelected(object sender, DateChangedEventArgs e)
	    {
	        
	    }
	}
}