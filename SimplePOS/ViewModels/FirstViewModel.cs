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


        private bool ShowPopup()
        {
            var popup = new SortPopup();
            Shell.Current.ShowPopup(popup);
            return true;
        }

        [RelayCommand]
        public async void OnLoginBtnClick()
        {

            //Username = Username;
            //Password = Password;
            //EnvironmentName = EnvironmentName;

            var client = new RestClient();

            LoginObj logobj = new LoginObj();

            logobj.UserName = Username1;
            logobj.Password = Password1;



            try
            {
                var request = new RestRequest("https://bl360x.com/PartnerOrder/api/Login/ValidateLogin").AddJsonBody(logobj);
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
                else
                {
                    Console.WriteLine(response.StatusCode);
                    //await _navigation.PushAsync(new AlertPop());


                }


            }
            catch (Exception ex)
            {
                ShowPopup();
                //await _navigation.PushAsync(new AlertPop());

            }
            //check the status code of the response

        }


    }
}
