using System;
using System.Threading.Tasks;
using EventLogin.Entities;
using EventLogin.Interfaces;
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

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var entities = await this.eventService.GetAll();
            return this.Json(entities);
        }
        
        
        /// <summary>
        /// Update a model
        /// </summary>
        /// <returns>returns the updated model</returns>
        [HttpPut("{userId:Guid}/{eventId:Guid}")]
        public ActionResult Update(Guid userId, Guid eventId)
        {
            this.eventService.UserAnmelden(userId, eventId);
            return this.Ok();
        }

    }
}