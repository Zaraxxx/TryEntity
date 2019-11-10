using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class HolisTechDBContext:DbContext
    {
        public HolisTechDBContext(DbContextOptions<HolisTechDBContext> options) : base(options)
        {

        }

      
        public DbSet<Site> Sites { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
           

        //    optionsBuilder.UseSqlServer("Data Source=FLAVCAT\\SQLEXPRESS;Initial Catalog=TryEntity;Trusted_Connection=True;MultipleActiveResultSets=true;");
        //    base.OnConfiguring(optionsBuilder);
        //}

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
