using LogMS.Domain.Model;
using LogMS.Domain.Model.Interface;
using System.Collections.Generic;

namespace LogMS.Domain.Service.Interface
{
    public interface INavService
    {
        /// <summary>
        /// 取得選單資料
        /// </summary>
        /// <param name="adminid"></param>
        /// <param name="menukey"></param>
        /// <returns></returns>
        ServiceResult<INavDTO> ListNavData(int adminid);
    }
}
