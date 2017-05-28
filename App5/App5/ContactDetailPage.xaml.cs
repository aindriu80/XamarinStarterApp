 
using System;
using App5.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactDetailPage : ContentPage
	{
		public ContactDetailPage(Contact contact )
		{
		    if (contact == null)
		        throw new ArgumentNullException();

		    BindingContext = contact;

		   
           
            
             InitializeComponent();
           
        }

	  
	}
}