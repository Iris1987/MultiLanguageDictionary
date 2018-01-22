using BaseEntities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repos
{
    public class EngEstRepo : IGeneric<TranslationEngEst>
    {
        private MyContext db;

        public EngEstRepo(MyContext context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            TranslationEngEst engEst = db.TranslationEngEsts.Find(id);
            if (engEst != null)
                db.TranslationEngEsts.Remove(engEst);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TranslationEngEst> GetAll()
        {
            return db.TranslationEngEsts.ToList();
        }

        public TranslationEngEst GetByID(int id)
        {
            return db.TranslationEngEsts.FirstOrDefault(x => x.IdTranslation == id); /*db.TranslationEngEsts.Find(id);*/
        }

        public void Create(TranslationEngEst item)
        {
            db.TranslationEngEsts.Add(item);
        }

        public void Update(TranslationEngEst item)
        {
            db.Entry(item).State = EntityState.Modified;
            Save();
        }
    }
}
