using System;
using System.Threading.Tasks;
using EventLogin.Entities;
using EventLogin.Interfaces;
using EventLogin.Services;
using Microsoft.AspNetCore.Mvc;
namespace EventLogin.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventController : Controller
    {
        private readonly IEventService eventService;
        public EventController(IEventService eventService)
        {
            this.eventService = eventService;
        }
        
        // CREATE
        [HttpPost]
        public async Task<ActionResult> Add([FromBody]EventEntity eventEntity)
        {
            var entity = await this.eventService.Add(eventEntity);
            return this.Json(entity);
        }
        
        // READ
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var entities = await this.eventService.GetAll();
            return this.Json(entities);
        }
        
        // UPDATE
        [HttpPut("{userId:Guid}/{eventId:Guid}")]
        public ActionResult Update(Guid userId, Guid eventId)
        {
            this.eventService.UserAnmelden(userId, eventId);
            return this.Ok();
        }
        
        // DELETE
        [HttpDelete ("{id:Guid}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await this.eventService.Delete(id);
            return this.Ok();
        }
        
        // GET BY ID
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult> GetById(Guid id)
        {
            var entity = await this.eventService.GetById(id);
            return Ok(entity);
        }

    }
}