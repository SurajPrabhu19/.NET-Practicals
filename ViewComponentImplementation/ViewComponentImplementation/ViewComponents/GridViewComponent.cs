using Microsoft.AspNetCore.Mvc;

namespace ViewComponentImplementation.ViewComponents
{
    public class GridViewComponent: ViewComponent
    {
        public IViewComponentResult InvokeAsync()
        {
            // Logic
            return View();  // invokes the Partial view Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
