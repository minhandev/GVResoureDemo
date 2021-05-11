using Infrastructure.Utilities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Dashboard.Controllers
{
    public class EmployeeController : Controller
    {

        public string webServices = string.Empty;
        public string webDashboard = string.Empty;
        public EmployeeController(IOptions<Settings> _myOptions)
        {
            webDashboard = _myOptions.Value.webDashboard;
            webServices = _myOptions.Value.webServices;
        }
         
        public IActionResult Index()
        {
            ViewData["webServices"] = webServices;
            return View();
        }
    }
}
