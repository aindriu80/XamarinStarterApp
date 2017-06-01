
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App5.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DateCell : ViewCell
	{
        public static readonly BindableProperty LabelProperty = BindableProperty.Create("Label",typeof(string),typeof(DateCell));
	    public string Label
        {
	        get { return(string) GetValue(LabelProperty); }
	        set { SetValue(LabelProperty, value); }
	    }


		public DateCell ()
		{
			InitializeComponent ();

		    BindingContext = this;
		}
	}
}