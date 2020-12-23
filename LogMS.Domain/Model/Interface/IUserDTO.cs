using System;

namespace LogMS.Domain.Model.Interface
{
    public interface IUserDTO : IUserAuthData
    {
        DateTime CreateDate { get; set; }

        bool Enable { get; set; }
    }
}
