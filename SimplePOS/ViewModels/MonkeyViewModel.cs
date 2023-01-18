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
using System.Text.Json;

namespace SimplePOS.ViewModels
{
    public partial class MonkeyViewModel : ObservableObject
    {

        [ObservableProperty]
        ObservableCollection<Monkey> _LItems;

        [ObservableProperty]
        public string name;

        

        public async MonkeyViewModel()
        {
            var json = await LoadMauiAssetAsync();
            await DisplayAlert("", json, "OK");
        }

        public async void LoadMauiAssetAsync()
        {
            string responseContent = File.ReadAllText(@"./monkeydata.json");
            //var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");




            //string responseContent = stream.ToString();
            if (responseContent != null)
            {
                List<Monkey> array = JsonConvert.DeserializeObject<List<Monkey>>(responseContent);

                LItems = new ObservableCollection<Monkey>(array);

                Name = LItems[1].Name.ToString();

            }

        }
    }
}
