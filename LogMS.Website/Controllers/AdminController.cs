using LogMS.Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LogMS.Website.Controllers
{
    public class AdminController : BaseController
    {
        public IAdminService _adminService { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="adminService"></param>
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        /// <summary>
        /// AdminInfoPartialView
        /// </summary>
        /// <returns></returns>
        public IActionResult AdminInfoPartialView()
        {
            var result = _adminService.GetCurrentSignInAdminInfo();

            return PartialView(result.ResultData);
        }
    }
}
