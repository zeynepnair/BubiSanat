﻿using Bubisanat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bubisanat.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //public DbSet<Category> Categories { get; set; }
        //public DbSet<Post> Posts { get; set; }
        //public DbSet<Comment> Comments { get; set; }
        //public DbSet<TopCategory> TopCategories { get; set; }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TopCategory> TopCategories { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}