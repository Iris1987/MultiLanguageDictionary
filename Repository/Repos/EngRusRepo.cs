﻿using BaseEntities.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repos
{
    public class EngRusRepo : IGeneric<TranslationEngRus>
    {
        private MyContext db;

        public EngRusRepo(MyContext context)
        {
            this.db = context;
        }

        public void Delete(int id)
        {
            TranslationEngRus translengRus = db.TranslationEngRuss.Find(id);
            if (translengRus != null)
                db.TranslationEngRuss.Remove(translengRus);
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

        public IEnumerable<TranslationEngRus> GetAll()
        {
            return db.TranslationEngRuss.ToList();
        }

        public TranslationEngRus GetByID(int id)
        {
            return db.TranslationEngRuss.Find(id);
        }

        public void Create(TranslationEngRus item)
        {
            db.TranslationEngRuss.Add(item);
        }

        public void Update(TranslationEngRus item)
        {
            db.Entry(item).State = EntityState.Modified;
        }

        
    }
}
