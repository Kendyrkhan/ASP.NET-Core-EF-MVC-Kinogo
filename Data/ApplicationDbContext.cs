using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Kinogo.Models;


namespace Kinogo.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<Country> Countries { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Comment> Comments { get; set; }

    }
}
