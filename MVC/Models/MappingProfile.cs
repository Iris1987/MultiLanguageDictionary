using AutoMapper;
using BaseEntities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<Category, CategoryViewModel>();

            CreateMap<EngEstViewModel, TranslationEngEst>();
            CreateMap<TranslationEngEst, EngEstViewModel>();

            CreateMap<EngRusViewModel, TranslationEngRus>();
            CreateMap<TranslationEngRus, EngRusViewModel>();

            CreateMap<RusEstViewModel, TranslationRusEst>();
            CreateMap<TranslationRusEst, RusEstViewModel>();

            CreateMap<EngViewModel, LangEnglish>();
            CreateMap<LangEnglish, EngViewModel>();

            CreateMap<EstViewModel, LangEstonian>();
            CreateMap<LangEstonian, EstViewModel>();

            CreateMap<RusViewModel, LangRussian>();
            CreateMap<LangRussian, RusViewModel>();

            CreateMap<PartOfSpeechViewModel, PartOfSpeech>();
            CreateMap<PartOfSpeech, PartOfSpeechViewModel>();

            CreateMap<SubcategoryViewModel, Subcategory>();
            CreateMap<Subcategory, SubcategoryViewModel>();
        }
    }
}
