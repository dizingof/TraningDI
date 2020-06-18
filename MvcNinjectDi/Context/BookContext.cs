using MvcNinjectDi.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcNinjectDi.Context
{
    public class BookContext : DbContext
    {
        public BookContext() : base("MvcNinjectDi.Properties.Settings.Setting") { }

        public DbSet<Book> Books { get; set; }
    }
}