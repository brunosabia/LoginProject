using LoginProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.Data
{
    public class LoginProjectContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public LoginProjectContext(DbContextOptions<LoginProjectContext> options)
            : base(options)
        {
        }

    }
}
