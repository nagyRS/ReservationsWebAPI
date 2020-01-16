using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebServices.Models;

namespace WebServices.Controllers
{
    // MVC 5 empty controller
    //Each of the action methods corresponds directly to one of the methods in the repository

        // the controller only adds : model validation, selecting views, and performing redirections
        
        // Action methods are removed as the Web API controller replaced them

        // new commit

    public class HomeController : Controller
    {
       
        // GET: Home
        public ViewResult Index()
        {
            return View();
        }



        //private ReservationRepository repo = new ReservationRepository.Current;

        //public ViewResult Index()
        //{
        //    return View(repo.GetAll());
        //}

        //public ActionResult Add(Reservation item)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        repo.Add(item);
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View("Index");
        //    }
        //}

        //public ActionResult Remove(int id)
        //{
        //    repo.Remove(id);
        //    return RedirectToAction("Index");
        //}

        //public ActionResult Update(Reservation item)
        //{
        //    if (ModelState.IsValid && repo.Update(item))
        //    {
        //        return RedirectToAction("Index");
        //    }
        //    else
        //    {
        //        return View("Index");
        //    }
        //}
    }
}