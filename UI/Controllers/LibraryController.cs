using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataModel;
using DAL;
using BLL;

namespace UI.Controllers
{
    public class LibraryController : Controller
    {
        LibraryEntities db = new LibraryEntities();
        VisitorVMRepository rebo = new VisitorVMRepository();
        
        // GET: Library

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
       public ActionResult Login()
        {
            return View();
        }     
        public JsonResult AddAccount(VisitorVM visitor)
        {

            if (!db.Visitor.Select(x => x.E_mail).Contains(visitor.E_mail))
            {
                rebo.Add(visitor);
                return Json("success", JsonRequestBehavior.AllowGet);
            }
            else
                return Json("error", JsonRequestBehavior.AllowGet);

        }
        public JsonResult EnterAccount(VisitorVM visitor)
        {
            if (db.Visitor.Select(x => x.E_mail).Contains(visitor.E_mail))
            {
                if (db.Visitor.Where(x => x.E_mail == visitor.E_mail && x.Password == visitor.Password).FirstOrDefault() != null)
                {
                    return Json("success", JsonRequestBehavior.AllowGet);
                }
                else
                {
                    //wrong password
                    return Json("error", JsonRequestBehavior.AllowGet);
                }
            }
            else
                //wrong email
                return Json("failed", JsonRequestBehavior.AllowGet);

        }

    }
}