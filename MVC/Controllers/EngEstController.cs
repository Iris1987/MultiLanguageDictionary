using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using BaseEntities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Services;
using Services.Interfaces;

namespace MVC.Controllers
{
    public class EngEstController : Controller
    {

        //private readonly EngEstService engest;
        
        private readonly IGenericTranslate<TranslationEngEst> translation;
        public EngEstController( IGenericTranslate<TranslationEngEst> tr /*EngEstService engest*/)
        {
            //this.engest = engest;
            
            this.translation = tr;

        }

        // GET: EngEst
        [HttpGet]
        public IActionResult Index()
        {
            List<EngEstViewModel> model = new List<EngEstViewModel>();
            translation.GetAll().ToList().ForEach(x =>
            {
                TranslationEngEst trans = translation.GetByID(x.IdTranslation);
                EngEstViewModel vm = new EngEstViewModel();
            
            model.Add(vm);

            });
  
            return View(model);
        }

       
        // GET: EngEst/Create
        [HttpGet]
        public IActionResult Create()
        {
            EngEstViewModel model = new EngEstViewModel();
            return PartialView("_AddĒngEst", model);
        }

        // POST: EngEst/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(EngEstViewModel ee)
        {
            
            try
            {
               if(ModelState.IsValid)
                {
                    TranslationEngEst trans = new TranslationEngEst();
                    translation.Create(trans);
                    //engest.Create(ee);

                    //return RedirectToAction(nameof(Index));
                }
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. " +
            "Try again, and if the problem persists " +
            "see your system administrator.");
                
            }
            return View(ee);
        }

        // GET: EngEst/Edit/5
        public IActionResult Update(int id)
        {
            EngEstViewModel model = new EngEstViewModel();


            return PartialView("_UpdateEngEst", model);
        }

        // POST: EngEst/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Update(EngEstViewModel ee)
        {

            TranslationEngEst trans = new TranslationEngEst();

            translation.Update(trans);

            return View(ee);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Delete(int id)
        {

            translation.Delete(id);

        }
    }
}