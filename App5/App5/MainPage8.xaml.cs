using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage8 : ContentPage
	{

		public MainPage8 ()
		{
			InitializeComponent ();
		}

	    void OnAdd(object sender, System.EventArgs e)
	    {
	    }

	    void OnUpdate(object sender, System.EventArgs e)
	    {
	    }

	    void OnDelete(object sender, System.EventArgs e)
	    {
	    }
    }
}