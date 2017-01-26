using Sales.Api.Client.InfraStructure;
using Sales.Api.Client.Interfaces;
using Sales.Api.Client.ViewModels;
using System;
using System.Net.Http;

namespace Sales.Api.Client.Services
{
    public class ClientContext : SingletonBase<ClientContext>
    {
        //ideally will be provided by user.. but hard coding here for the demo purpose.. 
        private const string BearerToken
            = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJ1bmlxdWVfbmFtZSI6ImFkbWluaXN0cmF0b3IiLCJzdWIiOiJhZG1pbmlzdHJhdG9yIiwicm9sZSI6IkFkbWluaXN0cmF0b3IiLCJpc3MiOiJodHRwOi8vbG9jYWxob3N0LyIsImF1ZCI6IkFueSIsImV4cCI6MTQ5MzE4NzIxMSwibmJmIjoxNDg1NDExMjExfQ.m-4u9kBsnkSJgSFfZbWNebuF7gs6__qtCtJKgEJmo48";

        public MainViewModel MainVm { get; private set; }

        /// <summary>
        /// the messaging service.
        /// </summary>
        public IMessagingService MessageService { get; private set; }

        public void Initialize()
        {
            MainVm = new MainViewModel();
            MessageService = new MessagingService();
        }

        /// <summary>
        /// Creates the client with authentication.
        /// </summary>
        /// <returns></returns>
        public HttpClient CreateClientWithAuth()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Constants.HelixLeisureWebApiUrl);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + BearerToken);
            return client;
        }

    }
}
