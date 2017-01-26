using Sales.Api.Dtos;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;

namespace Sales.Api.ModelBinders
{
    public class DateRangeModelBinder : IModelBinder
    {
        public bool BindModel(HttpActionContext actionContext, ModelBindingContext bindingContext)
        {
            DateRange range;

            if (bindingContext.ModelType != typeof(DateRange))
            {
                return false;
            }

            var value = bindingContext.ValueProvider.GetValue(bindingContext.ModelName);

            if (value == null)
            {
                return false;
            }

            var text = value.RawValue as string;

            if (DateRange.TryParse(text, out range))
            {
                bindingContext.Model = range;
                return true;
            }

            bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Cannot convert value to a valid .");
            return false;
        }
    }
}