using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IGenericTranslate<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetByCategory(string word);
        IEnumerable<TEntity> GetBySubcategory(string word);
        IEnumerable<TEntity> GetAll();
        TEntity GetByID(int id);
        IEnumerable<TEntity> Find(string word);
        void Create(TEntity item);
        void Update(TEntity item);
        void Delete(int id);
    }
}
