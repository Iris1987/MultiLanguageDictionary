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
    public class RusEstController : Controller
    {
        private readonly IMapper mapper;

        private readonly IGenericTranslate<TranslationRusEst> translation;
        private readonly IGenericService<LangEstonian> langEstonian;
        private readonly IGenericService<LangRussian> langRussian;
        private readonly IGenericService<PartOfSpeech> part;
        private readonly IGenericService<Subcategory> sub;
        public RusEstController(IGenericTranslate<TranslationRusEst> tr, IMapper mapper,
            IGenericService<LangEstonian> langEstonian,
            IGenericService<LangRussian> langRussian,
             IGenericService<PartOfSpeech> part,
             IGenericService<Subcategory> sub)
        {
            //this.engest = engest;
            this.mapper = mapper;
            this.translation = tr;
            this.langEstonian = langEstonian;
            this.langRussian = langRussian;
            this.part = part;
            this.sub = sub;
        }

        // GET: EngEst
        [HttpGet]
        public IActionResult Index()
        {
            List<RusEstViewModel> model = new List<RusEstViewModel>();
            translation.GetAll().ToList().OrderBy(x => x.IdWordRusNavigation.Word).ToList().ForEach(x =>
            {
                //TranslationEngEst trans = translation.GetByID(x.IdTranslation);
                //EngEstViewModel vm = new EngEstViewModel();
                var stuff = mapper.Map<TranslationRusEst, RusEstViewModel>(translation.GetByID(x.IdTranslation));

                model.Add(stuff);

            });
            var wordEst = langEstonian.GetAll().ToList();
            var wordRus = langRussian.GetAll().ToList();
            var parts = part.GetAll().ToList();
            var subs = sub.GetAll();

            ViewBag.WordEng = wordEst;
            ViewBag.WordRus = wordRus;
            ViewBag.Parts = parts;
            ViewBag.Subs = subs;


            return View(model);//model
        }

        // POST: EngEst/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(RusEstViewModel ee)
        {

            try
            {
                if (ModelState.IsValid)
                {
                    translation.Create(mapper.Map<RusEstViewModel, TranslationRusEst>(ee));

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
        public ActionResult Update(RusEstViewModel ee)
        {
            translation.Update(mapper.Map<RusEstViewModel, TranslationRusEst>(ee));

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