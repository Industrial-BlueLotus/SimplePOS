using SimplePOS.Pages;
using SimplePOS.ViewModels;

namespace SimplePOS;

public partial class MainPage : ContentPage
{


    public MainPage()
    {
        InitializeComponent();

        FirstViewModel model = new();
        this.BindingContext = model;






    }


}

