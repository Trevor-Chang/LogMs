using Microsoft.AspNetCore.Mvc;

namespace LogMS.Website.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult List()
        {
            return PartialView();
        }
    }
}
