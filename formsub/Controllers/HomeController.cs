using System.Collections.Generic;
using System.Diagnostics;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using formsub.Models;

namespace formsub.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("method")]
        public IActionResult Success(string firstname, string lastname, string email, string age, string password)
        {
            User NewUser = new User
            {
                firstname = firstname,
                lastname = lastname,
                email = email,
                age = age,
                password = password,
            };
            TryValidateModel(NewUser);
            ViewBag.errors = ModelState.Values;
            return View();
        }
    }
}
