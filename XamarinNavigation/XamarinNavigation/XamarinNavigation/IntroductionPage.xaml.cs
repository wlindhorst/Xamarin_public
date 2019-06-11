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
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        async protected void Handle_Clicked(object sender, System.EventArgs e)
        {
            // await Navigation.PopModalAsync();  // for modal pages
            await Navigation.PopAsync();
            
        }

        /// <summary>
        /// too keep hardware back button from going back, override onbackbuttonpressed
        /// </summary>
        /// <returns></returns>
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}