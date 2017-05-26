﻿
using Android.App;
using Android.Content.PM;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;


namespace App5.Droid
{
    [Activity (Label = "App5", Icon = "@drawable/icon", Theme="@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar; 

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

		    ImageCircleRenderer.Init();

            LoadApplication (new App5.App ());
		}
	}
}

