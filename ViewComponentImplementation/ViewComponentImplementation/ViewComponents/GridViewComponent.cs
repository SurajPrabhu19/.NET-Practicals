using Microsoft.AspNetCore.Mvc;

namespace ViewComponentImplementation.ViewComponents
{
    public class GridViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Logic
            return View("Index");  // invokes the Partial view Views/Shared/Components/Grid/Index.cshtml
            //return View();  // invokes the Partial view Views/Shared/Components/Grid/Default.cshtml
        }
    }
}
