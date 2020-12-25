using System;
using System.Collections.Generic;
using System.Text;

namespace LogMS.Domain.Model
{
    public class ServiceResult
    {
        /// <summary>
        /// 判斷是否執行成功
        /// </summary>
        public bool IsSuccess { get; set; } = true;

        /// <summary>
        /// Exception
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// Pop up window的訊息
        /// </summary>
        public List<ReturnMessage> Messages { get; set; } = new List<ReturnMessage>();
    }

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T">回傳至前端的Model</typeparam>
    public class ServiceResult<T>
    {
        /// <summary>
        /// 判斷是否執行成功
        /// </summary>
        public bool IsSuccess { get; set; } = true;

        /// <summary>
        /// 回傳至前端的資料
        /// </summary>
        public T ResultData { get; set; }

        /// <summary>
        /// Exception
        /// </summary>
        public string Exception { get; set; }

        /// <summary>
        /// Pop up window的訊息
        /// </summary>
        public List<ReturnMessage> Messages { get; set; } = new List<ReturnMessage>();
    }

    public class ReturnMessage
    {
        private string status = "success";
        private string message = "資料更新成功";

        /// <summary>
        /// 執行狀態
        /// 1. success
        /// 2. error
        /// </summary>
        public string Status
        {
            get
            {
                return this.status;
            }

            set
            {
                this.status = value;
            }
        }

        /// <summary>
        /// 回傳訊息
        /// 1. 資料更新成功
        /// 2. 資料更新失敗
        /// </summary>
        public string Message
        {
            get
            {
                return this.message;
            }

            set
            {
                this.message = value;
            }
        }
    }
}
