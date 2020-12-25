using LogMS.Domain.Model;
using LogMS.Domain.Model.Interface;

namespace LogMS.Domain.Service.Interface
{
    public interface IAdminService
    {
        ServiceResult<IAdminDTO> GetCurrentSignInAdminInfo();
    }
}
