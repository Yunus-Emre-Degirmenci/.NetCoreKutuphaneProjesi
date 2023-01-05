using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string pass1 = BCrypt.Net.BCrypt.HashPassword("123");
            string pass2 = BCrypt.Net.BCrypt.HashPassword("1234");

            modelBuilder.Entity<User>().HasData(
                new User() { ID = 1, UserName = "administrator", Password = pass1, Role = Enums.Role.admin },
                new User() { ID = 2, UserName = "yunus", Password = pass2, Role = Enums.Role.user }
            );

            modelBuilder.Entity<Tbl_Student>().HasData(
                new Tbl_Student() { ID = 1, FirstName = "Yunus", LastName = "Değirmenci", Gender = Enums.Gender.Erkek },
                new Tbl_Student() { ID = 2, FirstName = "Serhat", LastName = "Ünver", Gender = Enums.Gender.Erkek },
                new Tbl_Student() { ID = 3, FirstName = "Gözde", LastName = "Sağlam", Gender = Enums.Gender.Kadın },
                new Tbl_Student() { ID = 4, FirstName = "Özlem", LastName = "Yılmaz", Gender = Enums.Gender.Kadın }

             );

            modelBuilder.Entity<StudentDetail>().HasData(
                new StudentDetail() { ID = 1, Tbl_StudentID = 1, SchollNumber = "100", BirthDay = new DateTime(1996, 07, 01) },
                new StudentDetail() { ID = 2, Tbl_StudentID = 2, SchollNumber = "101", BirthDay = new DateTime(1999, 07, 01) },
                new StudentDetail() { ID = 3, Tbl_StudentID = 3, SchollNumber = "102", BirthDay = new DateTime(1995, 07, 01) },
                new StudentDetail() { ID = 4, Tbl_StudentID = 4, SchollNumber = "103", BirthDay = new DateTime(1994, 07, 01) }
              );
        }
    }
}
