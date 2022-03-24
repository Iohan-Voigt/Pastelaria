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

        public virtual string Insert(T register)
        {
            try
            {
                dbSet.Add(register);
                db.SaveChanges();
                return "Sucess";
            }
            catch (Exception)
            {
                return ("Error");
            }
        }

        public virtual string Update(T register)
        {
            try
            {
                dbSet.Update(register);
                db.SaveChanges();
                return "Sucess";
            }
            catch (Exception)
            {
                return ("Error");
            }
        }

        public virtual string Remove(T register)
        {
            try
            {
                dbSet.Remove(register);
                db.SaveChanges();
                return "Sucess";
            }
            catch (Exception)
            {
                return ("Error");
            }
        }

        public virtual string RemoveById(Guid id)
        {         

            try
            {
                T register = GetById(id);
                dbSet.Remove(register);
                db.SaveChanges();
                return "Sucess";
            }
            catch (Exception ex)
            {
                return ("Error : " + ex.Message);
            }
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
