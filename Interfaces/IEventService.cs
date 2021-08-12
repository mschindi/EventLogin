using System;
using EventLogin.Entities;

namespace EventLogin.Interfaces
{
    public interface IEventService : IEntityService<EventEntity>
    {
        bool UserAnmelden( Guid userId, Guid eventId);
    }
    
}