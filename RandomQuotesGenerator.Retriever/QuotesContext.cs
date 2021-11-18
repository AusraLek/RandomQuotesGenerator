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
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
        //entities
        public DbSet<QuotesEntity> Quotes { get; set; }


    }
}
