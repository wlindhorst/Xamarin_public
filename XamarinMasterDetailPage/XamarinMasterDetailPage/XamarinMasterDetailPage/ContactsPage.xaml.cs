using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinMasterDetailPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactsPage : MasterDetailPage
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
            
            var contact = e.SelectedItem as Contact;
            Detail = new NavigationPage(new ContactsDetailPage(contact));
            IsPresented = false; // IsMasterPresented

        }
    }
}