using LogMS.Db;
using LogMS.Domain.Model;
using LogMS.Domain.Model.DTO;
using LogMS.Domain.Model.Interface;
using LogMS.Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogMS.Domain.Service
{
    public class NavService : INavService
    {
        public LogmsContext _DbContext { get; set; }

        public NavService(LogmsContext context)
        {
            _DbContext = context;
        }

        /// <summary>
        /// 取得選單資料
        /// </summary>
        /// <param name="adminid"></param>
        /// <param name="menukey"></param>
        /// <returns></returns>
        public ServiceResult<INavDTO> ListNavData(int adminid)
        {
            var result = new ServiceResult<INavDTO>();

            try
            {
                var admin = this._DbContext.Admins.Where(x => x.Id == adminid).FirstOrDefault();

                //取得符合使用者admin權限的選單
                IEnumerable<IMenuDTO> adminmenus = this._DbContext.AdminToMenus.Where(x => x.AdminId == adminid).Select(x => x.Menu).Select(x => new MenuDTO
                {
                    Id = x.Id,
                    Key = x.Key,
                    Name = x.Name,
                    Url = x.Url,
                    Creator = x.Creator,
                    CreateDate = x.CreateDate,
                    Editor = x.Editor.Value,
                    EditDate = x.EditDate,
                    ParentId = x.ParentId
                }).ToList();

                //Set NavData
                INavDTO navdata = new NavDTO();

                navdata.AllMenus = adminmenus;

                result.ResultData = navdata;
            }
            catch (Exception ex)
            {
                result.IsSuccess = false;
                throw;
            }

            return result;
        }
    }
}
