using PractLoginService3.EntityFramework;
using PractLoginService3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractLoginService3.Repository
{
    public class UserRepository :IUserRepository
    {
        public readonly ApplicationDbContext applicationDbContext;
        public UserRepository(ApplicationDbContext _applicationDbContext)
        {
            this.applicationDbContext = _applicationDbContext;
        }

        public int CreateUser(User objUser)
        {
            try
            {
                this.applicationDbContext.Add(objUser);
                this.applicationDbContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public bool LoginValidate(string username, string password)
        {
            var temp = applicationDbContext.Users.Where(s => s.UserName == username && s.Password == password).FirstOrDefault();
            if(temp == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
