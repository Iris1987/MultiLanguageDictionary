using BaseEntities.Models;
using Repository.Interfaces;

using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class EngEstService : IGenericTranslate<TranslationEngEst>
    {
        private readonly IGeneric<TranslationEngEst> repository;
        

        public EngEstService(IGeneric<TranslationEngEst> repository   )
        {

            this.repository = repository;

        }


        public void Create(TranslationEngEst item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
        //
        public IEnumerable<TranslationEngEst> Find(string word)
        {
             return repository.GetAll().Where(x => x.IdWordEngNavigation.Word.Contains(word) || x.IdWordEstNavigation.Word.Contains(word));
        }

        public IEnumerable<TranslationEngEst> GetAll()
        {
            
                return repository.GetAll();
        }
        
        // В таблице перевода idcategory относится к подкатегории (idsubcategory)
        public IEnumerable<TranslationEngEst> GetByCategory(int id)
        {
            return repository.GetAll().Where(z => z.IdCategoryNavigation.IdCategoryNavigation.IdCategory.Equals(id));
        }

        public TranslationEngEst GetByID(int id)
        { 

            return repository.GetByID(id);
             
        }

        public IEnumerable<TranslationEngEst> GetBySubcategory(int id)
        {
            return repository.GetAll().Where(y => y.IdCategoryNavigation.IdSubcategory.Equals(id)); 
                
     
        }

        public void Update(TranslationEngEst item)
        {
            repository.Update(item);
        }
    }
}
