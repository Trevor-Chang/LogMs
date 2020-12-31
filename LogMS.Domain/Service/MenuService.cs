using LogMS.Db;
using LogMS.Domain.Model;
using LogMS.Domain.Model.DTO;
using LogMS.Domain.Model.Interface;
using LogMS.Domain.Service.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LogMS.Domain.Service
{
    public class MenuService : IMenuService
    {
        public LogmsContext _DbContext { get; set; }

        public MenuService(LogmsContext context)
        {
            _DbContext = context;
        }
    }
}
