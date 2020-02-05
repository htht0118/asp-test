using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using kdhhome.DateContext;
using kdhhome.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace kdhhome.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        [HttpGet ]
        public IActionResult Login()
        {
            return View();
        }
        //[HttpPost]

        ///<summary>
        ///회원가입
        ///</summary>
        ///<returns><</returns>
       
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new AspnetNoteDbcontext())
                {
                    db.Users.Add(model);
                    db.SaveChanges();
                }
                return RedirectToAction("Index", "Home");
}
            return View(model);

        }
    }
}
