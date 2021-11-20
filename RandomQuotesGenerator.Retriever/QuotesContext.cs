using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomQuotesGenerator.Retriever
{
    public class QuotesContext : DbContext
    {
        public QuotesContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // 127.0.0.1 jeigu neveiks pries commitinant nusiimt
            optionsBuilder.UseSqlServer("Server=DESKTOP-4SKOP0M;Database=QuotesDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<QuotesEntity> Quotes { get; set; }


    }
}
