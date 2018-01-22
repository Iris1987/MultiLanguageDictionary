using BaseEntities.Models;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class EngRusService : IGenericTranslate<TranslationEngRus>,IGenericService<TranslationEngRus>
    {
        private readonly IGeneric<TranslationEngRus> repository;


        public EngRusService(IGeneric<TranslationEngRus> repository)
        {

            this.repository = repository;

        }


        public void Create(TranslationEngRus item)
        {
            repository.Create(item);
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }
        //
        public IEnumerable<TranslationEngRus> Find(string word)
        {
            return repository.GetAll().Where(x => x.IdWordEngNavigation.Word.Contains(word) || x.IdWordRusNavigation.Word.Contains(word));
        }

        public IEnumerable<TranslationEngRus> GetAll()
        {

            return repository.GetAll();
        }

        // В таблице перевода idcategory относится к подкатегории (idsubcategory)
        public IEnumerable<TranslationEngRus> GetByCategory(string word)
        {
            return repository.GetAll().Where(z => z.IdCategoryNavigation.IdCategoryNavigation.Categoryname.Equals(word));
        }

        public TranslationEngRus GetByID(int id)
        {

            var engest = repository.GetByID(id);
            return engest;
        }

        public IEnumerable<TranslationEngRus> GetBySubcategory(string word)
        {
            return repository.GetAll().Where(y => y.IdCategoryNavigation.Subcategoryname.Equals(word));


        }

        public void Update(TranslationEngRus item)
        {
            repository.Update(item);
        }
    }
}
