using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Tbl_Operation>
    {
        public void Configure(EntityTypeBuilder<Tbl_Operation> builder)
        {
            builder.Ignore(x => x.ID); // ID alanın ignore ettik.
            builder.HasKey(x => new { x.Tbl_StudentID, x.Tbl_BookID });
            builder.ToTable("Operasyon");
            builder.Property(x => x.StartDate).HasColumnType("datetime");
            builder.HasOne(o => o.Tbl_Book).WithMany(b => b.Tbl_Operations).HasForeignKey(o => o.Tbl_BookID);
            builder.HasOne(o => o.Tbl_Student).WithMany(b => b.Tbl_Operations).HasForeignKey(o => o.Tbl_StudentID);
        }
    }
}
