using LogMS.Domain.Model.Interface;
using System.Collections.Generic;

namespace LogMS.Domain.Model.DTO
{
    public class NavDTO : INavDTO
    {
        /// <summary>
        /// 所有選單資料
        /// </summary>
        public IEnumerable<IMenuDTO> AllMenus { get; set; }

        /// <summary>
        /// 當前帳號資料
        /// </summary>
        public IAdminDTO CurrentAdmin { get; set; }

        /// <summary>
        /// 當前選單資料
        /// </summary>
        public IMenuDTO CurrentMenu { get; set; }

        /// <summary>
        /// 當前選單資料(多檔)
        /// </summary>
        public IEnumerable<IMenuDTO> CurrentMenus { get; set; }
    }
}
