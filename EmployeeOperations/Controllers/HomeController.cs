using EmployeeOperations.BLL;
using EmployeeOperations.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeOperations.Controllers
{
    public class HomeController : Controller
    {
        EmployeeRegistrationSave empSave = new EmployeeRegistrationSave();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration(Employee emp)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View();
                }
                else
                {
                    if (empSave.EmployeeRegistration(emp))
                    {
                        ViewBag.Name = "Success";
                        return View("~/Views/Home/ErrorSuccess.cshtml");
                    }
                    else
                    {
                        ViewBag.Name = "NotSuccess";
                        return View("~/Views/Home/ErrorSuccess.cshtml");
                    }

                }
            }
            catch (Exception ex)
            {
                ViewBag.Name = "Error";
                return View("~/Views/Home/ErrorSuccess.cshtml");
            }
        }
    }
}