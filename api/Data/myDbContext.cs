using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class myDbContext : DbContext
    {

        public myDbContext(DbContextOptions<myDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<Post> Post { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}