using LogMS.Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LogMS.Website.Controllers
{
    public class NavController : Controller
    {
        private INavService _navService { get; set; }

        public NavController(INavService navService)
        {
            _navService = navService;
        }

        public IActionResult MenuList()
        {
            var result = _navService.ListNavData(UserAuthHelper.GetUserData().Id);

            return View(result.ResultData);
        }
    }
}
