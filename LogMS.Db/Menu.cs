﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

#nullable disable

namespace LogMS.Db
{
    public partial class Menu
    {
        public Menu()
        {
            AdminToMenus = new HashSet<AdminToMenu>();
        }

        /// <summary>
        /// 資料編號
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// KEY
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
        /// 父層menu資料編號
        /// </summary>
        public int? ParentId { get; set; }
        /// <summary>
        /// 建立時間
        /// </summary>
        public DateTime CreateDate { get; set; }
        /// <summary>
        /// 建立人員
        /// </summary>
        public int Creator { get; set; }
        /// <summary>
        /// 編輯持間
        /// </summary>
        public DateTime? EditDate { get; set; }
        /// <summary>
        /// 編輯人員
        /// </summary>
        public int? Editor { get; set; }

        public virtual ICollection<AdminToMenu> AdminToMenus { get; set; }
    }
}