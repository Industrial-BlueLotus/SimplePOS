using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestSharp;
using SimplePOS.ViewModels;
using System.Net;

namespace SimplePOS.Pages;

public partial class Dashboard : ContentPage
{


    public Dashboard()
    {
        InitializeComponent();
        DashViewModel dbvmodel = new();
        this.BindingContext = dbvmodel;
    }


}