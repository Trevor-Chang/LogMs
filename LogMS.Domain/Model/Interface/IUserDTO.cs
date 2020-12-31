using System.Collections.Generic;

namespace LogMS.Domain.Model.Interface
{
    public interface INavDTO
    {
        IEnumerable<IMenuDTO> AllMenus { get; set; }

        IEnumerable<IMenuDTO> CurrentMenus { get; set; }
    }
}
