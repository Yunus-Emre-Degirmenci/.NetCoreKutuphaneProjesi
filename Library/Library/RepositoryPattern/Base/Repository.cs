﻿using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Base
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        MyDbContext _context;
        protected DbSet<T> table;
        public Repository(MyDbContext context)
        {
            _context = context;
            table = context.Set<T>();
        }
        private void Save()
        {
            _context.SaveChanges();
        }
        public void Add(T item)
        {
            table.Add(item);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return table.Any(exp);
        }

        public int Count()
        {
            return table.Count();
        }

        public void Delete(int id)
        {
            T item = GetById(id);
            item.Status = Enums.DataStatus.Deleted;
            item.ModifiedDate = DateTime.Now;
            table.Update(item);
            Save();
        }

        public List<T> GetActives()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).ToList();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> exp)
        {
            return table.Where(exp).ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public List<T> SelectActivesByLimit(int count)
        {
            return table.Where(x => x.Status != Enums.DataStatus.Deleted).Take(count).ToList();
        }

        public void SpecialDelete(int id)
        {
            T item = GetById(id);
            table.Remove(item);
            Save();
        }

        public void Update(T item)
        {
            item.Status = Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            table.Update(item);
            Save();
        }

        public T Default(Expression<Func<T, bool>> exp)
        {
            return table.FirstOrDefault(exp);
        }
    }
}
