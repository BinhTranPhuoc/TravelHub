using EntityData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TravelHub.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account account)
        {
            if (ModelState.IsValid)
            {
                using (TravelDBContext db = new TravelDBContext())
                {
                    var identity = db.Accounts.Where(x => x.userName.Equals(account.userName)
                    && x.password.Equals(account.password)).FirstOrDefault();

                    if (identity != null)
                    {
                        Session["userName"] = identity.userName.ToString();
                        return RedirectToAction("AdminDashBoard");
                    }
                }
            }
            return View(account);
        }

        public ActionResult AdminDashBoard()
        {
            if (Session["userName"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}