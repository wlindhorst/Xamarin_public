using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPickerWithNavigation
{
	public partial class MainPage : ContentPage
	{
        void Handle_Tapped(Object sender, System.EventArgs e)
        {
            var page = new ContactMethodsPage();
            page.ContactMethods.ItemSelected += (source, args) =>
            {
                contactMethod.Text = args.SelectedItem.ToString();
                Navigation.PopAsync();
            };
            Navigation.PushAsync(page);
        }

		public MainPage()
		{
			InitializeComponent();
		}
	}
}
