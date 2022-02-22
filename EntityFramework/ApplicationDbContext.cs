using Microsoft.EntityFrameworkCore;
using PractLoginService3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractLoginService3.EntityFramework
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions opts) : base(opts)
        {

        }
        public DbSet<User> Users {get;set;}
    }
}
