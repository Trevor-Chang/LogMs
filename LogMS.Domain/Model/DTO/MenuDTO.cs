using LogMS.Domain.Model.Interface;
using System;

namespace LogMS.Domain.Model.DTO
{
    public class MenuDTO : IMenuDTO
    {
        /// <summary>
        /// 資料編號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Key
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 名稱
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 路徑
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 父層編號
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// 建立日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 建立人員
        /// </summary>
        public int Creator { get; set; }

        /// <summary>
        /// 編輯日期
        /// </summary>
        public DateTime? EditDate { get; set; }

        /// <summary>
        /// 編輯人員
        /// </summary>
        public int? Editor { get; set; }
    }
}
