using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinToolbarItems
{
	public partial class MainPage : ContentPage
	{
        async void Handle_Activated(object sender, System.EventArgs e)
        {
            await DisplayAlert("Activated", "ToolbarItem activated", "OK");
        }
		public MainPage()
		{
			InitializeComponent();
		}
	}
}
