using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace web2021.Areas.Usuarios.Controllers
{
    [Area("Usuarios")]
    public class UserController : Controller
    {
        public IActionResult User()
        {
            return View();
        }
    }
}
