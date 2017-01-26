using System.Collections.Generic;

namespace Sales.Api.Client.ViewModels
{
    public class OptionsViewModel
    {
        public IReadOnlyCollection<Option> Options { get; private set; }

        public Option SelectedOption { get; set; }

        public OptionsViewModel()
        {
            Options = new List<Option>(new Option[3] {
            new Option("Post",new PostItemViewModel()),
            new Option("Get All",new GetAllViewModel()),
            new Option("Get Within Time Period",new GetInRangeViewModel())
        });
       }
    }
}
