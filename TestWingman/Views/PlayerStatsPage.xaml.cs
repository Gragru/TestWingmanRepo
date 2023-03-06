namespace TestWingman.Views;

public partial class PlayerStatsPage : ContentPage
{
	public PlayerStatsPage()
	{
		InitializeComponent();
        BindingContext = new ViewModels.PlayerStatsPageViewModel();
    }


    bool pageStarted = false;
    protected override void OnAppearing()
    {
        base.OnAppearing();
        if (!pageStarted)
        {
            Task t = (BindingContext as ViewModels.PlayerStatsPageViewModel).GetData("origin/thelindd/segments/legend"); // Metod i ViewModel
            pageStarted = true;
        }
    }

    private async void OnListViewitemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var legend = ((ListView)sender).SelectedItem as Models.Data;
        if (legend != null)
        {
            var page = new LegendDetailsPage();
            page.BindingContext = legend;
            await Navigation.PushAsync(page);
        }
    }
}