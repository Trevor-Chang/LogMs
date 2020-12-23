using System;

namespace LogMS.Domain.Model.Interface
{
    public interface IAdminDTO
    {
        int Id { get; set; }

        string Account { get; set; }

        string Password { get; set; }

        DateTime CreateDate { get; set; }

        int EntityStatus { get; set; }
    }
}
