using LogMS.Domain.Model.Interface;

namespace LogMS.Domain.Service.Interface
{
    public interface IUserService
    {
        IUserDTO VerifyUser(IUserDTO userDTO);

        void SignIn(IUserDTO userDTO);

        void SignOut();
    }
}
