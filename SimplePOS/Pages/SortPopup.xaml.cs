using CommunityToolkit.Maui.Views;

namespace SimplePOS.Pages;

public partial class SortPopup : Popup
{
    public SortPopup()
    {
        InitializeComponent();
    }

    async void OnOKButtonClicked(object sender, EventArgs e)
    {

        Close();
        await Shell.Current.GoToAsync("MainPage");
    }

}