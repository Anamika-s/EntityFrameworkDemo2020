using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class BookDbContext : DbContext
    {
        //public List<Book> books { get; set; }
        public DbSet<Book> books { get; set; }
    }
}