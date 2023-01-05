using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class StudentDetail : BaseEntity
    {
        public string SchollNumber { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDay { get; set; }
        public int Tbl_StudentID { get; set; }


        public virtual Tbl_Student Tbl_Student { get; set; }
    }
}
