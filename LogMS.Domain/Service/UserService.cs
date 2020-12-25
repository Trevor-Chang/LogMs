using LogMS.Db;
using LogMS.Domain.Model.DTO;
using LogMS.Domain.Model.Interface;
using LogMS.Domain.Service.Interface;
using System.Data;
using System.Linq;

namespace LogMS.Domain.Service
{
    public class UserService : IUserService
    {
        public LogmsContext _DbContext { get; set; }

        public UserService(LogmsContext context)
        {
            _DbContext = context;
        }

        public IUserDTO VerifyUser (IUserDTO userDTO)
        {
            if (string.IsNullOrEmpty(userDTO.Account) || string.IsNullOrEmpty(userDTO.Password))
            {
                return null;
            }

            var targetuser = this._DbContext.Admins
                .Where(o => o.Account == userDTO.Account && o.Password == userDTO.Password && o.EntityStatus == (int)EntityStatus.上架)
                .Select(o => new UserDTO
                {
                    Id = o.Id,
                    Account = o.Account,
                    Password = o.Password,
                    UserName = o.Name
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
