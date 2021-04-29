using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_Address_Book.Models;

namespace MVC_Address_Book.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MVC_Address_Book.Models.Category> Category { get; set; }
        public DbSet<MVC_Address_Book.Models.Contact> Contact { get; set; }
    }
}
