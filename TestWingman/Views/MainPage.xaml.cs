namespace TestWingman;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private async void OnClickedGotoPlayerstatsPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.PlayerStatsPage());
    }
}

