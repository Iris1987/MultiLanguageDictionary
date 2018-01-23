using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using AutoMapper;
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
        private readonly IMapper mapper;
        
        private readonly IGenericTranslate<TranslationEngEst> translation;
        public EngEstController( IGenericTranslate<TranslationEngEst> tr /*EngEstService engest*/,IMapper mapper)
        {
            //this.engest = engest;
            this.mapper = mapper;
            this.translation = tr;

        }

        // GET: EngEst
        [HttpGet]
        public IActionResult Index()
        {

            //if (ModelState.IsValid)
            //{
            //    var result = translation.GetByID(); authenticateService.RegisterUser(registerVM);  // implicit   
            //                                                                // conversion from RegisterViewModel to User Model  

            //    RegisterViewModel vm = result; // see implicit conversion   
            //                                   // from User model to RegisterViewModel  

            //    return View(vm);

            //}
            //return View(registerVM);

            List<EngEstViewModel> model = new List<EngEstViewModel>();
            translation.GetAll().ToList().ForEach(x =>
            {
                //TranslationEngEst trans = translation.GetByID(x.IdTranslation);
                //EngEstViewModel vm = new EngEstViewModel();
                var stuff = mapper.Map<TranslationEngEst,EngEstViewModel>(translation.GetByID(x.IdTranslation));
            
            model.Add(stuff);

            });
  
            return View(model);//model
        }

       
        // GET: EngEst/Create
        [HttpGet]
        public IActionResult Create()
        {
            //EngEstViewModel model = new EngEstViewModel();
            //return PartialView("_AddEngEst", model);

            return View();
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
                    translation.Create(mapper.Map<EngEstViewModel,TranslationEngEst>(ee));


                    //TranslationEngEst trans = new TranslationEngEst();
                    //translation.Create(trans);
                    

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
            //EngEstViewModel model = new EngEstViewModel();


            //return PartialView("_UpdateEngEst", model);

            return View();
        }

        // POST: EngEst/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Update(EngEstViewModel ee)
        {

            //TranslationEngEst trans = new TranslationEngEst();

            translation.Update(mapper.Map<EngEstViewModel,TranslationEngEst>(ee));

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