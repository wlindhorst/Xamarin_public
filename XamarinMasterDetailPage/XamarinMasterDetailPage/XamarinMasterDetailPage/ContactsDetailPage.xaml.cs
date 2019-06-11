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
	public partial class ContactsDetailPage : ContentPage
	{
        public ContactsDetailPage(Contact contact)
        {
            if (contact == null)
                throw new ArgumentNullException();

            BindingContext = contact;

            InitializeComponent();
		}
	}
}