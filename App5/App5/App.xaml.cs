
using Xamarin.Forms;

namespace App5
{
    public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

		    MainPage = new NavigationPage(new MainPage7());
            
            //  MainPage = new MainPage3();
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
	}
}
