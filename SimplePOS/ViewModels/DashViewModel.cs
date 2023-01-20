using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SimplePOS.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.ViewModels
{
    public partial class DashViewModel : ObservableObject
    {

        [RelayCommand]
        public async void OnOrderTypClick()
        {
            await Shell.Current.GoToAsync(nameof(OrderDetails));
        }
    }
}
