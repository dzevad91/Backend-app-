﻿using Lottery.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Lottery.Data
{
    public class Repository<T> : Irepository<T> where T : class, IEntity
    {
        protected DbSet<T> DbSet;

        public Repository(DbContext dbContext)
        {
            DbSet = dbContext.Set<T>();
        }

        public void Delete(T entity)
        {
            DbSet.Remove(entity);
        }

        public IQueryable<T> GetAll()
        {
            return DbSet;
        }

        public T GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Insert(T entity)
        {
            DbSet.Add(entity);
        }
    }
    
  
}
