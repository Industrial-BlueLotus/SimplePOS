using CommunityToolkit.Maui.Views;
using RestSharp;
using SimplePOS.Pages;
using SimplePOS.ViewModels;
using System.Net;

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

