using Microsoft.AspNetCore.Mvc;
using projectclass.Models;

namespace projectclass.Controllers
{
    public class adminController : Controller
    {
        private readonly mydb db;
        public adminController(mydb db)
        {
            this.db= db;
        }
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult login(register r)
        {
            var check=db.registers.Where(a=>a.r_email ==r.r_email & a.r_pass == r.r_pass).FirstOrDefault();
            if(check != null)
            {
                return RedirectToAction("dashboard");

            }
            else
            {
                ViewBag.msg = "not login";
            }
            return View();
        }
        public IActionResult register()
        {
            return View();
        }
        public IActionResult dashboard()
        {
            return View();
        }
    }
}
