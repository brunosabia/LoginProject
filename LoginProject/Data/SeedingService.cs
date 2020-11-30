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
            if (_context.Users.Any())
            {
                return;
            }
            

            User u1 = new User(1,"admin", "admin", Status.Offline);
            User u2 = new User(2,"admin1", "admin1", Status.Offline);

            _context.Users.AddRange(u1, u2);

            _context.SaveChanges();
        }

    }
}
