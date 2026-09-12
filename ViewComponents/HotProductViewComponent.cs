using Microsoft.AspNetCore.Mvc;

namespace NetCoreMVCLab04.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}