using LogMS.Db;
using LogMS.Domain.Model;
using LogMS.Domain.Model.DTO;
using LogMS.Domain.Model.Interface;
using LogMS.Domain.Service.Interface;
using System;
using System.Linq;

namespace LogMS.Domain.Service
{
    public class AdminService : IAdminService
    {
        public LogmsContext _DbContext { get; set; }

        public AdminService(LogmsContext context)
        {
            _DbContext = context;
        }

        public ServiceResult<IAdminDTO> GetCurrentSignInAdminInfo()
        {
            var result = new ServiceResult<IAdminDTO>();

            try
            {
                var query = _DbContext.Admins.
                                Where(x => x.Id.Equals(UserAuthHelper.GetUserData().Id) && x.EntityStatus == (int)EntityStatus.上架).
                                Select(x => new AdminDTO
                                {
                                    Id = x.Id,
                                    Account = x.Account,
                                    Password = x.Password,
                                    Name = x.Name,
                                    CreateDate = x.CreateDate,
                                    EntityStatus = x.EntityStatus
                                }).
                                SingleOrDefault();

                result.ResultData = query;
            }
            catch (Exception)
            {
                result.IsSuccess = false;
                throw;
            }

            return result;
        }
    }
}
