using BaseEntities.Models;
using Repository.Interfaces;

using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class EngEstService : IGenericTranslate<TranslationEngEst>, IGenericService<TranslationEngEst>
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
        public IEnumerable<TranslationEngEst> GetByCategory(string word)
        {
            return repository.GetAll().Where(z => z.IdCategoryNavigation.IdCategoryNavigation.Categoryname.Equals(word));
        }

        public TranslationEngEst GetByID(int id)
        { 

            var engest = repository.GetByID(id);
            return engest;
        }

        public IEnumerable<TranslationEngEst> GetBySubcategory(string word)
        {
            return repository.GetAll().Where(y => y.IdCategoryNavigation.Subcategoryname.Equals(word)); 
                
     
        }

        public void Update(TranslationEngEst item)
        {
            repository.Update(item);
        }
    }
}
