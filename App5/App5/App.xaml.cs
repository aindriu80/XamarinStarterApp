
using App5.Models;
using Xamarin.Forms;

namespace App5
{
    public partial class App : Application
	{
	    //private const string Titlekey = "Name";
	    //private const string NotificationsEnabledKey = "NotificationsEnabled";

        public App ()
		{

			InitializeComponent();

		    MainPage = new NavigationPage(new MoviesPage());
            
           //   MainPage = new MainPage9();
            //{
            //    BarBackgroundColor = Color.Gray,
            //             BarTextColor = Color.White
            //};
        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

	    //public string Title
	    //{
	    //    get
	    //    {
	    //        if (Properties.ContainsKey(Titlekey))
	    //         return  Properties[Titlekey].ToString();

	    //        return"";
	    //    }
	    //    set
	    //    {
	    //        Properties[Titlekey] = value;
	    //    }
	    //}

	    //public bool NotificationsEnabled
	    //{
	    //    get
	    //    {
	    //        if (Properties.ContainsKey(NotificationsEnabledKey))
	    //            return (bool) Properties[NotificationsEnabledKey];

	    //        return false;
	    //    }
	    //    set
	    //    {
	    //        Properties[NotificationsEnabledKey] = value;
	    //    }
	    //}
	}
}
