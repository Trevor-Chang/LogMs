using System;
using System.Collections.Generic;
using System.Text;

namespace LogMS.Domain.Model.Interface
{
    public interface IUserAuthData
    {
        /// <summary>
        /// 資料編號
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// 帳號
        /// </summary>
        string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// 使用者名稱
        /// </summary>
        string UserName { get; set; }

    }
}
