using Sales.Api.Client.Interfaces;

namespace Sales.Api.Client.ViewModels
{
    public class Option
    {
        public string Name { get; private set; }

        public IViewModel OptionContentViewModel { get; }

        public Option(string name,IViewModel optionContentViewModel)
        {
            this.Name = name;
            this.OptionContentViewModel = optionContentViewModel;
        }
    }
}
