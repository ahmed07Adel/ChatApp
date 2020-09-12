using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            

        }
       public DbSet<SaveChat>text { get; set; }

       protected override void OnModelCreating(ModelBuilder builder)
       {
           builder.Entity<SaveChat>().HasKey(c => c.Chatid);
           builder.Entity<SaveChat>().Property(c => c.Chatid).ValueGeneratedOnAdd();
           base.OnModelCreating(builder);
       }
    }
}
