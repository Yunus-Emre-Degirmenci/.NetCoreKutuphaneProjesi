using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Tbl_Operation : BaseEntity
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int Tbl_StudentID { get; set; }
        public int Tbl_BookID { get; set; }


        public virtual Tbl_Student Tbl_Student { get; set; }
        public virtual Tbl_Book Tbl_Book { get; set; }
    }
}
