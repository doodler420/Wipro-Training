﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlineBookLibrary.Models;

namespace OnlineBookLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<OnlineBookLibrary.Models.Book> Book { get; set; } = default!;
    }
}
