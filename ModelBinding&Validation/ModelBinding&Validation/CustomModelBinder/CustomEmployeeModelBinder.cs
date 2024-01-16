using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.JSInterop.Implementation;
using ModelBinding_Validation.Models;

namespace ModelBinding_Validation.CustomModelBinder
{
    public class CustomEmployeeModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            Employee employee = new Employee();
            employee.firstName = getValueIfExists(nameof(Employee.firstName), bindingContext) != null ? getValueIfExists(nameof(Employee.firstName), bindingContext):null;
            employee.lastName = getValueIfExists(nameof(Employee.lastName), bindingContext) != null ? getValueIfExists(nameof(Employee.lastName), bindingContext):null;
            employee.email = getValueIfExists(nameof(Employee.email), bindingContext) != null ? getValueIfExists(nameof(Employee.email), bindingContext):null;
            employee.dob = getValueIfExists(nameof(Employee.dob), bindingContext) != null ? Convert.ToDateTime(getValueIfExists(nameof(Employee.dob), bindingContext)):null;
            employee.age = getValueIfExists(nameof(Employee.age), bindingContext)!=null ? Convert.ToInt16(getValueIfExists(nameof(Employee.age), bindingContext)):null;
            bindingContext.Result = ModelBindingResult.Success(employee);
            return Task.CompletedTask;
        }

        public static String getValueIfExists(string attributeName, ModelBindingContext bindingContext)
        {
            if (bindingContext.ValueProvider.GetValue(attributeName).Length > 0)
                return bindingContext.ValueProvider.GetValue(attributeName).First();
            return null;
        }
    }
}
