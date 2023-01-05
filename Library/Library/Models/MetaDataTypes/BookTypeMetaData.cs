using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models.MetaDataTypes
{
    public class BookTypeMetaData
    {
        [Required(ErrorMessage = "Zorunlu Alan")]
        [MaxLength(20, ErrorMessage = "Max 20 karakter girebilirsiniz.")]
        public string Name { get; set; }
    }
}
