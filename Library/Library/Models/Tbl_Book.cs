using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Tbl_Book:BaseEntity
    {
        public string Name { get; set; }
        public int PageCount { get; set; }

        public int Tbl_AuthorID { get; set; }
        public int Tbl_BookTypeID { get; set; }

        public virtual Tbl_Author Tbl_Author { get; set; }
        public virtual Tbl_BookType Tbl_BookType { get; set; }

        public virtual List<Tbl_Operation> Tbl_Operations { get; set; }
    }
}
