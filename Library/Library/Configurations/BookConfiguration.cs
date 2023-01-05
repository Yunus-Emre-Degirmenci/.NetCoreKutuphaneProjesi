using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Tbl_Book>
    {
        public void Configure(EntityTypeBuilder<Tbl_Book> builder)
        {
            builder.HasOne(b => b.Tbl_Author).WithMany(a => a.Tbl_Books).HasForeignKey(b => b.Tbl_AuthorID);
            builder.HasOne(b => b.Tbl_BookType).WithMany(bt => bt.Tbl_Books).HasForeignKey(b => b.Tbl_BookTypeID);
        }
    }
}
