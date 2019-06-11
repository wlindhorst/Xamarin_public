using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMasterDetail
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : ContentPage
	{
		public ContactsPage ()
		{
			InitializeComponent ();

			listView.ItemsSource = new List<Contact>{
					new Contact{ Name="Bill", ImageUrl="http://lorempixel.com/100/100/people/3", Status="Away"},
					new Contact{ Name="Joe", ImageUrl="http://lorempixel.com/100/100/people/2", Status = "Available"}
			};

		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			var contact = e.SelectedItem as Contact;

			Navigation.PushAsync(new ContactsDetailPage(contact));

			listView.SelectedItem = null;
		}
	}
}