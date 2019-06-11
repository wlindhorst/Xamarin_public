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
	public partial class Refresh : ContentPage
	{
        private ObservableCollection<Contact> _contacts;

        private List<Contact> GetContacts()
        {
            return new List<Contact>{
                    new Contact{ Name="Bill", ImageUrl="http://lorempixel.com/100/100/people/3"},
                    new Contact{ Name="Joe", ImageUrl="http://lorempixel.com/100/100/people/2", Status = "Available"}
            };
        }
        
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            listView.ItemsSource = GetContacts();

            //listView.IsRefreshing = false; // or EndRefresh
            listView.EndRefresh();

            
        }
        public Refresh ()
		{
			InitializeComponent ();

            listView.ItemsSource = GetContacts();
        }
	}
}