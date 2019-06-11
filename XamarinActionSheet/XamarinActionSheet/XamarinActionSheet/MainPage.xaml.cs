using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinActionSheet
{
	public partial class MainPage : ContentPage
	{
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			//var response = await DisplayAlert("Warming", "Are you sure", "Yes", "No");
			//if (response)
			//    await DisplayAlert("Done", "Your response will be saved", "OK");

			var response = await DisplayActionSheet("Title", "Cancel", "Delete", "Copy Link", "Message", "Email");
			await DisplayAlert("Response", response, "OK");

		}
		public MainPage()
		{
			InitializeComponent();
		}
	}
}
