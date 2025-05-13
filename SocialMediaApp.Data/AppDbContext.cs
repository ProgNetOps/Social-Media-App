﻿using Microsoft.EntityFrameworkCore;
using SocialMedia.Data.Models;
using SocialMediaApp.Data.Models;

namespace SocialMediaApp.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }

        public DbSet<Post> Posts { get; set; }
        //public DbSet<User> Users { get; set; }
    }
}
