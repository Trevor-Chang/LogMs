using LogMS.Domain.Model.DTO;
using LogMS.Domain.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LogMS.Website.Controllers
{
    public class UserController : Controller
    {
        public IUserService _userService { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// 登入頁
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// 登入
        /// </summary>
        [HttpPost]
        public IActionResult Login(UserDTO userDTO)
        {
            var model = _userService.VerifyUser(userDTO);

            if(model != null)
            {
                _userService.SignIn(model);

                //導至首頁
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        /// <summary>
        /// 登出
        /// </summary>
        public IActionResult SignOut()
        {
            _userService.SignOut();

            return RedirectToAction("Index", "User");
        }
    }
}
