using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace LogMS.Website.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            //設定Version
            ViewBag.Version = "?" + ConfigHelper.Current.GetSection("CacheVersion").Value;
            base.OnActionExecuting(filterContext);
        }
    }
}
