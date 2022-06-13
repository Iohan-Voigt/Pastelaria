using Microsoft.EntityFrameworkCore;
using Pastelaria.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Pastelaria.ORM.Shared
{
    public abstract class RepositoryBase<T> where T : EntityBase
    {
        protected readonly PastelariaDBContext db;
        protected readonly DbSet<T> dbSet;

        protected RepositoryBase(PastelariaDBContext db) 
        {        
            this.db = db;
            dbSet = db.Set<T>();
        }

        public virtual bool Insert(T register)
        {
            try
            {
                //register.Id = Guid.NewGuid();
                dbSet.Add(register);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public virtual bool Update(T register)
        {
            try
            {
                dbSet.Update(register);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public virtual bool Remove(Guid id)
        {         

            try
            {
                T register = GetById(id);
                dbSet.Remove(register);
                db.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public virtual List<T> GetAll()
        {
            try
            {
                return dbSet.ToList<T>();
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public virtual T GetById(Guid id)
        {
            try
            {
                return dbSet.FirstOrDefault(x => x.Id.Equals(id));
            }
            catch (Exception ex)
            {

                return null;
            }
        }

    }
}
