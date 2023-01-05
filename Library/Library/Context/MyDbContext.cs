using Library.Configurations;
using Library.Initializer;
using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=.;database=BookStore;uid=sa;pwd=123");
        //    base.OnConfiguring(optionsBuilder);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            DataInitializer.Seed(modelBuilder);

            modelBuilder.ApplyConfiguration(new OperationConfiguration());
           
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());          

            modelBuilder.ApplyConfiguration(new StudentConfiguration());          

            modelBuilder.ApplyConfiguration(new BookConfiguration());

        }

        public DbSet<Tbl_Author> Tbl_Authors { get; set; }
        public DbSet<Tbl_Book> Tbl_Books { get; set; }
        public DbSet<Tbl_BookType> Tbl_BookTypes { get; set; }
        public DbSet<Tbl_Student> Tbl_Students { get; set; }
        public DbSet<Tbl_Operation> Tbl_Operations { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
