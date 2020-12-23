using LogMS.Domain.Model.Interface;
using System;

namespace LogMS.Domain.Model.DTO
{
    public class UserDTO : IUserDTO
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

        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 啟用狀態
        /// </summary>
        public bool Enable { get; set; }
    }
}
