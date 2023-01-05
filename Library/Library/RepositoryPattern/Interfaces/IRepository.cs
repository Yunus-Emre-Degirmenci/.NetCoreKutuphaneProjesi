using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Interfaces
{
    public interface IRepository<T> where T:BaseEntity
    {
        List<T> GetAll();
        List<T> GetActives();
        T GetById(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);
        void SpecialDelete(int id); // hard delete, veritabanından veriyi silme
        List<T> GetByFilter(Expression<Func<T,bool>> exp);  // where sorguları için
        T Default(Expression<Func<T, bool>> exp);   // kullanıcı ve admin giriş işlemleri içiç kullanıcı verisi çekilecek
        int Count();
        bool Any(Expression<Func<T,bool>> exp);          // kayıt varmı yokmu
        List<T> SelectActivesByLimit(int count);    //veritabanın kaç kayıt istiyorsun
    }
}
