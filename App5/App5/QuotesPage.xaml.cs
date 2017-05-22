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
	public partial class QuotesPage : ContentPage
	{
	    private int _index = 0;
        private string[] _strings = new string[]
        {
         "I changed my password everywhere to 'incorrect.' That way when I forget it, it always reminds me, 'Your password is incorrect.'",
         "People who can fall asleep quickly freak me out... I mean, don't they have thoughts?",
         "Sunglasses: allowing you to stare at people without getting caught. It's like Facebook in real life"
        };
		public QuotesPage ()
		{
			InitializeComponent ();
		    currentQuote.Text = _strings[_index];
		}

	    void Handle_Clicked(object sender, System.EventArgs e)
	    {
	        _index++;
	        if (_index >= _strings.Length)
	            _index = 0;

	        currentQuote.Text = _strings[_index];
	    }
	}
}