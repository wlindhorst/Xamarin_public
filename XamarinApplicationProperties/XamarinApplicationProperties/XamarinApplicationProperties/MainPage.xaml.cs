using Xamarin.Forms;

namespace XamarinApplicationProperties
{
	public partial class MainPage : ContentPage
	{

        //void OnChange(object sender, System.EventArgs e)
        //{
        //    var app = Application.Current as App;
        //    app.Title = title.Text;
        //    app.NotificationEnabled = notificationsEnabled.On;

        //    //Application.Current.Properties[TitleKey] = title.Text;
        //    //Application.Current.Properties[NotificationsEnabledKey] = notificationsEnabled.On;

        //    //Application.Current.SavePropertiesAsync();  -- to save immediately
        //}

        // when a user navigates away from this page
        //protected override void OnDisappearing()
        //{
        //    base.OnDisappearing();)
        //}

        public MainPage()
		{
			InitializeComponent();

            // bind everything so you don't have to bind explicitly
            BindingContext = Application.Current;

            //var app = Application.Current as App;

            //title.Text = app.Title;
            //notificationsEnabled.On = app.NotificationEnabled;

            //if (Application.Current.Properties.ContainsKey(TitleKey))
            //    title.Text = Application.Current.Properties[TitleKey].ToString();

            //if (Application.Current.Properties.ContainsKey(NotificationsEnabledKey))
            //    notificationsEnabled.On = (bool)Application.Current.Properties[NotificationsEnabledKey];

        }
	}
}

