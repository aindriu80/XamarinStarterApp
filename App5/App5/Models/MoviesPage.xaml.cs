namespace App5
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MoviesPage : ContentPage
	{
	    private int movieLength = 5;
		public MoviesPage ()
		{
			InitializeComponent ();
		}

	    private void SearchBar_OnTextChanged(object sender, TextChangedEventArgs e)
	    {
	        //throw new NotImplementedException();
	        if (e.NewTextValue == null || e.NewTextValue.Length < movieLength)
	            return;
	    }
	}
}