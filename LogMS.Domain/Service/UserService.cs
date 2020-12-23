using LogMS.Db;
using LogMS.Domain.Helper;
using LogMS.Domain.Model.DTO;
using LogMS.Domain.Model.Interface;
using LogMS.Domain.Service.Interface;
using System.Data;
using System.Linq;

namespace LogMS.Domain.Service
{
    public class UserService : IUserService
    {
        public LogmsContext _logmsContext { get; set; }

        public UserService(LogmsContext context)
        {
            _logmsContext = context;
        }

        public IUserDTO VerifyUser (IUserDTO userDTO)
        {
            if (string.IsNullOrEmpty(userDTO.Account) || string.IsNullOrEmpty(userDTO.Password))
            {
                return null;
            }

            var targetuser = this._logmsContext.Admin
                .Where(o => o.Account == userDTO.Account && o.Password == userDTO.Password && o.Enable == true)
                .Select(o => new UserDTO
                {
                    Id = o.Id,
                    Account = o.Account,
                    Password = o.Password,
                    UserName = o.Name,
                    CreateDate = o.CreateDate,
                    Enable = o.Enable
                })
                .FirstOrDefault();

            if (targetuser == null)
            {
                return null;
            }

            return targetuser;
        }

        /// <summary>
        /// 執行登入
        /// </summary>
        /// <param name="data">使用者登入後的資訊</param>
        /// <returns></returns>
        public void SignIn(IUserDTO data)
        {
            UserAuthHelper.SignIn(data);
        }

        /// <summary>
        /// 執行登出
        /// </summary>
        public void SignOut()
        {
            UserAuthHelper.SignOut();
        }
    }
}
