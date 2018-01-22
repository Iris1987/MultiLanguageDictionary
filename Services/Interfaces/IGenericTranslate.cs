using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Interfaces
{
    public interface IGenericTranslate<TEntity> where TEntity: class
    {
        IEnumerable<TEntity> GetByCategory(string word);
        IEnumerable<TEntity> GetBySubcategory(string word);
    }
}
