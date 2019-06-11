using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinNavigation
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        async protected void Handle_Clicked(object sender, System.EventArgs e)
        {
            // await Navigation.PushModalAsync(new IntroductionPage());
            await Navigation.PushAsync(new IntroductionPage());
        }
	}
}