using CommunityToolkit.Maui.Views;

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

        if (model.IsPopUp)
        {
            var popup1 = new SortPopup();
            this.ShowPopup(popup1);


        }






    }


}

