using LoginProject.Models;
using LoginProject.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.Data
{
    public class SeedingService
    {
        private LoginProjectContext _context;

        public SeedingService(LoginProjectContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.User.Any())
            {
                return;
            }

            User u1 = new User("admin", "admin", Status.Offline);
            User u2 = new User("admin1", "admin1", Status.Offline);

            _context.User.AddRange(u1, u2);

            _context.SaveChanges();
        }

    }
}
