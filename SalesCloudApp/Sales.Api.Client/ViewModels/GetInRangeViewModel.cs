using Sales.Api.Client.Interfaces;
using Sales.Api.Client.Services;

namespace Sales.Api.Client.ViewModels
{
    public class GetInRangeViewModel : IViewModel
    {
        public RelayCommand Action { get; set; }

        public GetInRangeViewModel()
        {
            Action = new RelayCommand(ExecuteAction);
        }

        private void ExecuteAction()
        {
            
        }
    }
}
