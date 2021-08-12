using System;
using EventLogin.Database;
using EventLogin.Entities;
using EventLogin.Interfaces;

namespace EventLogin.Services
{
    public class EventService : EntityService<EventEntity>, IEventService
    {
        public EventService(ApplicationDbContext applicationDbContext)
            : base(applicationDbContext)
        {
        }

        public bool UserAnmelden(Guid userId, Guid eventId)
        {
            var userAnmelden = this.ApplicationDbContext.Set<UserEntity>().Find(userId);
            var eventAnmelden = this.ApplicationDbContext.Event.Find(eventId);

            if (eventAnmelden.Users.Count < eventAnmelden.MaxUsers)
            {
                eventAnmelden.Users.Add(userAnmelden);
                this.ApplicationDbContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}