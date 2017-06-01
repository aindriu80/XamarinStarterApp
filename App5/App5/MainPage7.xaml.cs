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
	public partial class MainPage7 : ContentPage
	{
		public MainPage7 ()
		{
			InitializeComponent ();

            if(Application.Current.Properties.ContainsKey("Name"))
            title.Text = Application.Current.Properties["Name"].ToString();

		    if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
		        notificationsEnabled.On = (bool) Application.Current.Properties["NotificationsEnabled"];
		}

	    private void OnChange(object sender, EventArgs e)
	    {
	        Application.Current.Properties["Name"] = title.Text;
	        Application.Current.Properties["NotificationsEnabled"] = notificationsEnabled.On;

	       
	    }

	    
	}
}