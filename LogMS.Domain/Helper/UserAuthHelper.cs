using LogMS.Domain.Model.DTO;
using LogMS.Domain.Model.Interface;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System;
using System.Security.Claims;

namespace LogMS.Domain.Helper
{
    public static class UserAuthHelper
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <param name="data"></param>
        /// 須提供以下資料 => UserId、帳號、姓名
        public static void SignIn(IUserAuthData data)
        {
            //加入User資訊
            Claim[] claims = new[] { new Claim("Id", data.Id.ToString()), new Claim("Account", data.Account), new Claim("UserName", data.UserName) };
            //Scheme必填
            ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

            //執行登入，相當於以前的FormsAuthentication.SetAuthCookie()
            //從組態讀取登入逾時設定
            int loginExpireMinute = int.Parse(ConfigHelper.Login["ExpireMinute"]);

            HttpContextHelper.Current.SignInAsync(
                principal,
                new AuthenticationProperties()
                {
                    IsPersistent = true, //IsPersistent = false，瀏覽器關閉即刻登出
                    ExpiresUtc = DateTime.UtcNow.AddMinutes(loginExpireMinute), //逾期時間設定
                });
        }

        /// <summary>
        /// 登出
        /// </summary>
        public static void SignOut()
        {
            HttpContextHelper.Current.SignOutAsync();
        }

        public static IUserAuthData GetUserData()
        {
            var userauthdata = new UserAuthData();

            if (HttpContextHelper.Current.User.Identity.IsAuthenticated)
            {
                var id = HttpContextHelper.Current.User.FindFirst(x => x.Type == "Id").Value;
                var account = HttpContextHelper.Current.User.FindFirst(x => x.Type == "Account").Value;
                var username = HttpContextHelper.Current.User.FindFirst(x => x.Type == "UserName").Value;

                userauthdata.Id = int.Parse(id);
                userauthdata.Account = account;
                userauthdata.UserName = username;
            }

            return userauthdata;
        }
    }
}
