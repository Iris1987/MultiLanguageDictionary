using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class ControllerEngEstController : Controller
    {
        private Eng
        public ControllerEngEstController()
        {



        }


        // GET: ControllerEngEst
        public ActionResult Index()
        {
            return View();
        }

        // GET: ControllerEngEst/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ControllerEngEst/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ControllerEngEst/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControllerEngEst/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ControllerEngEst/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ControllerEngEst/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ControllerEngEst/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}