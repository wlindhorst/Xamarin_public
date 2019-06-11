using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Selections : ContentPage
	{
        private ObservableCollection<Contact> _contacts;

		public Selections ()
		{
			InitializeComponent ();

             _contacts = new ObservableCollection<Contact>{
                    new Contact{ Name="Bill", ImageUrl="http://lorempixel.com/100/100/people/3"},
                    new Contact{ Name="Joe", ImageUrl="http://lorempixel.com/100/100/people/2", Status = "Available"}
            };

            listView.ItemsSource = _contacts;
        }



        void Call_Clicked(object sender, System.EventArgs e)
        {            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }
        void Delete_Clicked(object sender, System.EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;

            _contacts.Remove(contact);

        }

        void Handle_ItemSelected(Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");

            // To disable selection
            //listview.SelectedItem = null;
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Tapped", contact.Name, "OK");
        }
	}
}