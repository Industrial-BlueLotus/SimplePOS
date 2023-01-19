namespace SimplePOS.Pages;

public partial class AlertPop : ContentPage
{
    public AlertPop()
    {
        InitializeComponent();
        DisplayAlert("Unable to dial", "Phone number was not valid.", "OK");
    }
}