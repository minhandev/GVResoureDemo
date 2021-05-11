using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.Dashboard.Controllers
{
    public class JobTitleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
