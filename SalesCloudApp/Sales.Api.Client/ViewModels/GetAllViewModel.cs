using Sales.Api.Client.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sales.Api.Client.Services;

namespace Sales.Api.Client.ViewModels
{
    public class GetAllViewModel : IViewModel
    {
        public RelayCommand Action { get; set; }

        public GetAllViewModel()
        {
            Action = new RelayCommand(ExecuteAction);
        }

        private void ExecuteAction()
        {
            
        }
    }
}
