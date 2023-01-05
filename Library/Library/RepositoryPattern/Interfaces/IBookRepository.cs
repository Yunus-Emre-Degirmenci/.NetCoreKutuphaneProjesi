using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Interfaces
{
    public interface IBookRepository:IRepository<Tbl_Book>
    {
        List<Tbl_Book> GetBooks();
    }
}
