using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RestSharp;
using SimplePOS.Models.PartnerMenu;
using SimplePOS.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SimplePOS.ViewModels
{
    public partial class DashViewModel : ObservableObject
    {

        public DashViewModel()
        {
            this.LoadResponse();

        }

        [RelayCommand]
        public async void OnOrderTypClick()
        {
            await Shell.Current.GoToAsync(nameof(OrderDetails));
        }

        public async void LoadResponse()
        {
            GlobalUsings link = new();
            var client = new RestClient();

            GetPartnerItemListToUploadReqModel reqmodel = new()
            {
                RequestId = "7ee53650-37b8-464c-90e9-85d89f8ab12a",
                IntegrationId = "7ee53650-37b8-464c-90e9-85d89f8ab12a",
                Apikey = "5b9f7f95a73c1b8270ef7cbe664324aac2e9f981f906ad366c64f2b107c90be7",
                UID =
                {
                    UserKey=301848,
                    CompanyKey = 51,
                    LocationKey = 80916,
                    EnvironmentName ="Live",
                    IsUrbanPiper = false
                },
                company =
                {
                    CompanyId=51
                }

            };

            try
            {
                var request = new RestRequest(link.apilinkpub + "api/PartnerMenu/GetPartnerItemListToUpload").AddJsonBody(reqmodel);
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
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

        }
    }
}