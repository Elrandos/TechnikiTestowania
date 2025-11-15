using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestAutoryzacji.Models;

namespace TestAutoryzacji.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
