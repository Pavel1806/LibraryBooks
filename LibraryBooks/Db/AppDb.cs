using LibraryBooks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Db
{
    public class AppDb : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public AppDb()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"строка подключения");
        }
    }
}
