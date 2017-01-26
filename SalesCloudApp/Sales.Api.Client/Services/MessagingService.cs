using Sales.Api.Client.Interfaces;
using System.Windows;

namespace Sales.Api.Client.Services
{
    public class MessagingService : IMessagingService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
