using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Base;
using Library.RepositoryPattern.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.RepositoryPattern.Concrete
{
    public class BookRepository : Repository<Tbl_Book>, IBookRepository
    {
        public BookRepository(MyDbContext db) : base(db)
        {

        }
        public List<Tbl_Book> GetBooks()
        {
            return table.Where(b => b.Status != Enums.DataStatus.Deleted).Include(x => x.Tbl_Author).Include(x => x.Tbl_BookType).ToList();
        }
    }
}
