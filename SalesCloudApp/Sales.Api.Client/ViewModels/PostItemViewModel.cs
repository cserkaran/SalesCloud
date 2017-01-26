using Sales.Api.Client.Interfaces;
using Sales.Api.Client.Services;
using System;
using System.Net.Http;
using System.Text;

namespace Sales.Api.Client.ViewModels
{
    public class PostItemViewModel : IViewModel
    {
        public RelayCommand Action { get; set; }

        public string JsonBody { get; set;}


        public PostItemViewModel()
        {
            Action = new RelayCommand(ExecuteAction);
        }

        private void ExecuteAction()
        {
            using (var httpClient = ClientContext.Instance.CreateClientWithAuth())
            {
                var content = new StringContent(JsonBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = httpClient.PostAsync(new Uri(Constants.HelixLeisureWebApiUrl),
                    content).Result;

                response.EnsureSuccessStatusCode();

            }
        }
    }
}
