using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BaseEntities.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using Services.Interfaces;

namespace MVC.Controllers
{
    public class EngRusController : Controller
    {
        private readonly IMapper mapper;

        private readonly IGenericTranslate<TranslationEngRus> translation;
        private readonly IGenericService<LangEnglish> langEnglish;
        private readonly IGenericService<LangRussian> langRussian;
        private readonly IGenericService<PartOfSpeech> part;
        private readonly IGenericService<Subcategory> sub;
        public EngRusController(IGenericTranslate<TranslationEngRus> tr, IMapper mapper,
            IGenericService<LangEnglish> langEnglish,
            IGenericService<LangRussian> langRussian,
             IGenericService<PartOfSpeech> part,
             IGenericService<Subcategory> sub)
        {
            //this.engest = engest;
            this.mapper = mapper;
            this.translation = tr;
            this.langEnglish = langEnglish;
            this.langRussian = langRussian;
            this.part = part;
            this.sub = sub;
        }

        // GET: EngEst
        [HttpGet]
        public IActionResult Index()
        {
            List<EngRusViewModel> model = new List<EngRusViewModel>();
            translation.GetAll().ToList().OrderBy(x => x.IdWordEngNavigation.Word).ToList().ForEach(x =>
            {
                //TranslationEngEst trans = translation.GetByID(x.IdTranslation);
                //EngEstViewModel vm = new EngEstViewModel();
                var stuff = mapper.Map<TranslationEngRus, EngRusViewModel>(translation.GetByID(x.IdTranslation));

                model.Add(stuff);

            });
            var wordEng = langEnglish.GetAll().ToList();
            var wordRus = langRussian.GetAll().ToList();
            var parts = part.GetAll().ToList();
            var subs = sub.GetAll();

            ViewBag.WordEng = wordEng;
            ViewBag.WordRus = wordRus;
            ViewBag.Parts = parts;
            ViewBag.Subs = subs;


            return View(model);//model
        }

        // POST: EngEst/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(EngRusViewModel ee)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    translation.Create(mapper.Map<EngRusViewModel, TranslationEngRus>(ee));

                }
            }
            catch
            {
                ModelState.AddModelError("", "Unable to save changes. " +
            "Try again, and if the problem persists " +
            "see your system administrator.");

            }
            return RedirectToAction("Index");
        }

        // POST: EngEst/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Update(EngRusViewModel ee)
        {
            translation.Update(mapper.Map<EngRusViewModel, TranslationEngRus>(ee));

            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public void Delete(int id)
        {

            translation.Delete(id);

        }
    }
}