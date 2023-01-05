using Library.Models.MetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    //[ModelMetadataType(typeof(AuthorMetaData))]
    public class Tbl_Author : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual List<Tbl_Book> Tbl_Books { get; set; }
    }
}
