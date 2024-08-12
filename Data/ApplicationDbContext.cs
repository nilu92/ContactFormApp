﻿using ContactFormApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace ContactFormApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
