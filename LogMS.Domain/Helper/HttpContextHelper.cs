using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace LogMS.Domain.Helper
{
    public static class HttpContextHelper
    {
        private static IHttpContextAccessor accessor;

        public static Microsoft.AspNetCore.Http.HttpContext Current => accessor.HttpContext;

        public static void Configure(IHttpContextAccessor accessor)
        {
            HttpContextHelper.accessor = accessor;
        }
    }
}
