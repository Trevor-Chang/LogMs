using LogMS.Domain.Model.Interface;
using System;

namespace LogMS.Domain.Model.DTO
{
    public class UserDTO : IUserDTO, IUserAuthData
    {
        /// <summary>
        /// 資料編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }
    }
}
