using EventLogin.Entities;
using EventLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventLogin.Controllers
{
    public class UserController : ControllerBase
    {
        public UserController(IEntityService<UserEntity> service )
        {
            
        }
    }
}