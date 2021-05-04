using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web2021.Models;
using Microsoft.Extensions.DependencyInjection;


namespace web2021.Controllers
{
    public class HomeController : Controller
    {
        //PARA CREAR MAS ROLES, HABILITAR LOS CODIGOS COMENTADOS
        //IServiceProvider _serviceProvider;

        public HomeController(IServiceProvider serviceProvider)
        {
            //_serviceProvider = serviceProvider;
        }
            
        public async Task<IActionResult> Index()
        {
            //await CreateRolesAsync(_serviceProvider);

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private async Task CreateRolesAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string[] rolesName = { "Admin", "User" };
            foreach(var item in rolesName)
            {
                var roleExist = await roleManager.RoleExistsAsync(item);
                if (!roleExist)
                {
                    await roleManager.CreateAsync(new IdentityRole(item));
                }
            }
        }
    }
}
