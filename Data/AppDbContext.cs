﻿using CRUDMVCWEB.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVCWEB.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Customer> Customers { get; set; }

    }
}
