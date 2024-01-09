﻿using System;
using Inventory.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Repository
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
            base(options)
        {
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Bill> Bills { get; set; }
    }
}
