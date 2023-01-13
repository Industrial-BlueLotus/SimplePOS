namespace SimplePOS.Pages;

public partial class Dashboard : ContentPage
{
	public Dashboard()
	{
		InitializeComponent();
	}

    public async void OnOrderTypClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Dashboard));
    }
}