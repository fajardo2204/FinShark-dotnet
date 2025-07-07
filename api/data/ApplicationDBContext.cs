using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.data
{
    public class ApplicationDBContext : DbContext // DbContext class for Entity Framework Core
    {
        // Define constructors and DbSets here
        public ApplicationDBContext(DbContextOptions dbContextOptions) //ctor
        : base(dbContextOptions) // Pass options to the base class
        {

        }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Comment> Comments { get; set; }
    }
}