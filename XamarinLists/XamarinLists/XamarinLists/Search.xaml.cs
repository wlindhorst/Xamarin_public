using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinLists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Search : ContentPage
	{
        void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }
        private IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new List<Contact>{
                    new Contact{ Name="Bill", ImageUrl="http://lorempixel.com/100/100/people/3"},
                    new Contact{ Name="Joe", ImageUrl="http://lorempixel.com/100/100/people/2", Status = "Available"}
            };

            if (String.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c => c.Name.StartsWith(searchText));
        }

        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            //listView.IsRefreshing = false; // or EndRefresh
            listView.EndRefresh();


        }
        public Search ()
		{
			InitializeComponent ();

            listView.ItemsSource = GetContacts();
		}
	}
}