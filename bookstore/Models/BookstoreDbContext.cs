﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Microsoft.EntityFrameworkCore;

namespace bookstore.Models
{
    public class BookstoreDbContext:DbContext
    {
        public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options):base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
