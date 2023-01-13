using SimplePOS.Pages;

namespace SimplePOS;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();
    }

    public async void OnLoginClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(Dashboard));
    }
}

