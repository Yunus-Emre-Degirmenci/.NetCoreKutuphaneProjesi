using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Tbl_Student>
    {
        public void Configure(EntityTypeBuilder<Tbl_Student> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.LastName).IsRequired();
            builder.HasOne<StudentDetail>(s => s.StudentDetail).WithOne(sd => sd.Tbl_Student)
              .HasForeignKey<StudentDetail>(sd => sd.Tbl_StudentID);
        }
    }
}
