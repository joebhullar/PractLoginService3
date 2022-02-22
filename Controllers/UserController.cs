using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PractLoginService3.Models;
using PractLoginService3.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PractLoginService3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        public readonly IUserRepository iuserRepository;
        public UserController(IUserRepository _iuserRepository)
        {
            iuserRepository = _iuserRepository;
        }
        [HttpPost("LoginUser")]
        public IActionResult LoginValidate([FromBody] User objUser)
        {
                var result = this.iuserRepository.LoginValidate(objUser.UserName, objUser.Password);
                return Ok(result);      
        }
        [HttpPost("RegisterUser")]
        public IActionResult CreateUser([FromBody] User objUser)
        {
            var result = this.iuserRepository.CreateUser(objUser);
            return Ok(result);
        }
    }
}
