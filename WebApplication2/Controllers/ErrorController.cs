using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApplication2.Controllers
{
    public class ErrorController : Controller
    {
        private ILogger<ErrorController> logger;

        public ErrorController(ILogger<ErrorController> logger)
        {
            this.logger = logger;
        }
        [Route("Error/{switch_on}")]
        public IActionResult Index(string switch_on)
        {
            switch (switch_on)
            {
                case "404":
                break;
                       
                default :
                    break;
            }
            return View();
        }
        [Microsoft.AspNetCore.Authorization.AllowAnonymous]
        [Route("Error")]
        public IActionResult Error()
        {
            var data=HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            //data 返回到异常页面中去
            ViewBag.Stack = data.Error.StackTrace;
            return View();
        }
    }
}
