using CommunityToolkit.Mvvm.ComponentModel;
using Newtonsoft.Json;
using SimplePOS.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace SimplePOS.ViewModels
{
    public partial class MonkeyViewModel : ObservableObject
    {



        [ObservableProperty]
        public string name;




        public MonkeyViewModel()
        {
            this.LoadMauiAssetAsync();
        }

        public void LoadMauiAssetAsync()
        {


        }
    }
}
