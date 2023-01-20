using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestSharp;
using SimplePOS.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.ViewModels
{
    public partial class FirstViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _username1;

        [ObservableProperty]
        private string _password1;

        [ObservableProperty]
        private string _environmentName;

        private readonly INavigation _navigation;

        [ObservableProperty]
        bool _IsPopUp = false;

        public FirstViewModel()
        {
        }


        public FirstViewModel(INavigation navigation)
        {
            _navigation = navigation;
        }


        [RelayCommand]
        public async void OnLoginBtnClick()
        {
            GlobalUsings link = new();
            var client = new RestClient();

            LoginObj logobj = new()
            {
                UserName = Username1,
                Password = Password1
            };

            try
            {
                var request = new RestRequest(link.apilinkpub + "api/Login/ValidateLogin").AddJsonBody(logobj);
                request.Method = Method.Post;

                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");

                RestResponse response = await client.PostAsync(request);

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    var responseContent = response.Content.ToString();
                    Console.WriteLine(responseContent);
                    await Shell.Current.GoToAsync(nameof(Dashboard));
                    //ShowPopup();

                }
                else if (response.StatusCode == HttpStatusCode.InternalServerError)
                {
                    Console.WriteLine(response.StatusCode);
                }
                else
                {
                    Console.WriteLine(response.StatusCode);
                    //await _navigation.PushAsync(new AlertPop());


                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                //await _navigation.PushAsync(new AlertPop());

            }


        }
    }
}
