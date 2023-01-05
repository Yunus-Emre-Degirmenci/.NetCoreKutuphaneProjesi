using Library.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Tbl_Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }      
        public Gender Gender { get; set; }
       
        public virtual List<Tbl_Operation> Tbl_Operations { get; set; }
        public virtual StudentDetail StudentDetail { get; set; }
    }
}
