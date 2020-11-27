using LoginProject.Data;
using LoginProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace LoginProject.Services
{
    public class UserService
    {
        private readonly LoginProjectContext _context;

        public UserService(LoginProjectContext context)
        {
            _context = context;
        }

        public async Task<List<User>> FindAllAsync()
        {
            return await _context.User.ToListAsync();
        }


        public async Task InsertAsync(User obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }

        public async Task AuthenticationAsync(User obj)
        {

            bool hasAny = await _context.User.AnyAsync(x => x.Username == obj.Username && x.Password == obj.Password);
            if (!hasAny)
            {
                throw new Exception("Login Failed");
            }
            //try catch aqui

                //redireciona para proxima pag
                await _context.SaveChangesAsync();
            
          

        }
    }
}
