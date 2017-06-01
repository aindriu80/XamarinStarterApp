
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class UserProfilePage : ContentPage
	{
        private UserService _service = new UserService();
        public UserProfilePage (int userId)
        {
            BindingContext = _service.GetUser(userId);
			InitializeComponent ();
		}
	}
}