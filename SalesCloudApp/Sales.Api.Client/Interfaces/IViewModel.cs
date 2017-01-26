using Sales.Api.Client.Services;

namespace Sales.Api.Client.Interfaces
{
    public interface IViewModel
    {
        RelayCommand Action { get; set; }
    }
}
