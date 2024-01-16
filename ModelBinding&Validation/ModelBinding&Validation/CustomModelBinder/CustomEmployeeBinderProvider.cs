using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using ModelBinding_Validation.Models;

namespace ModelBinding_Validation.CustomModelBinder
{
    public class CustomEmployeeBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if(context.Metadata.ModelType == typeof(Employee))
            {
                return new BinderTypeModelBinder(typeof(CustomEmployeeModelBinder));
            }
            return null;
        }
    }
}
