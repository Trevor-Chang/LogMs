using System;

namespace LogMS.Domain.Model.Interface
{
    public interface IMenuDTO
    {
        int Id { get; set; }

        string Key { get; set; }

        string Name { get; set; }

        string Url { get; set; }

        int Parent { get; set; }

        DateTime CreateDate { get; set; }

        int Creator { get; set; }

        DateTime? EditDate { get; set; }

        int Editor { get; set; }
    }
}
