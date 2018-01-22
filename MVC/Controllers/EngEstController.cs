using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services;

namespace MVC.Controllers
{
    public class EngEstController : Controller
    {

        private readonly EngEstService engest;
        //private readonly IGeneric<TranslationEngEst> generic;
        //private readonly IGenericTranslate<TranslationEngEst> translation;
        public EngEstController(/*TranslationEngEst generic, TranslationEngEst translation,*/ EngEstService engest)
        {
            this.engest = engest;
            //this.generic = generic;
            //this.translation = translation;

        }

        // GET: EngEst
        public ActionResult Index()
        {
            return View();
        }

        // GET: EngEst/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EngEst/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EngEst/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            try
            {
               if(ModelState.IsValid)
                {
                    engest.                }
            }
            catch
            {
                return View();
            }
        }

        // GET: EngEst/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EngEst/Edit/5
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

        // GET: EngEst/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EngEst/Delete/5
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