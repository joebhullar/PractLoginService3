using PractLoginService3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractLoginService3.Repository
{
    public interface IUserRepository
    {
        public int CreateUser(User objUser);
        public bool LoginValidate(string username, string password);
    }
}
