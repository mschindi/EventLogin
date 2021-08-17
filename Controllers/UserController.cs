using System;
using System.Threading.Tasks;
using EventLogin.Entities;
using EventLogin.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EventLogin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IEntityService<UserEntity> service;

        public UserController(IEntityService<UserEntity> service )
        {
            this.service = service;
        }
        
        
        // CREATE
        [HttpPost]
        public async Task<ActionResult> Add([FromBody] UserEntity userEntity)
        {
            var entity = await this.service.Add(userEntity);
            return Ok(entity);
        }
        
        // READ
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var entities = await this.service.GetAll();
            return this.Json(entities);
        }
        
        // UPDATE
        [HttpPut]
        public  ActionResult Update([FromBody] UserEntity userEntity)
        {
            this.service.Update(userEntity);
            return this.Ok();
        }
        
        // GET BY ID
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var entity = await this.service.GetById(id);
            return Ok(entity);
        }

    }
}