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
	public partial class Demo : ContentPage
	{
        public Demo()
        {
            InitializeComponent();

            //var names = new List<string>
            //{
            //    "Bill",
            //    "John",
            //    "Bob"
            //};


            listView.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup("B", "B")
                {
                    new Contact{ Name="Bill", ImageUrl="http://lorempixel.com/100/100/people/3"},
                },
                new ContactGroup("J", "J")
                {
                    new Contact{ Name="Joe", ImageUrl="http://lorempixel.com/100/100/people/2", Status = "Available"}
                }
            };
		}
	}
}