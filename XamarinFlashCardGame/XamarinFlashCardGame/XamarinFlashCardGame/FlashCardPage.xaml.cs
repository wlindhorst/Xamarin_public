using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFlashCardGame
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlashCardPage : ContentPage
	{
		public FlashCardPage ()
		{
			InitializeComponent ();

			//imgLine.Source= ImageSource.FromResource("FlashCardPage.Images.line.png");
		}
	}
}