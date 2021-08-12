using System;
using System.ComponentModel.DataAnnotations;

namespace EventLogin.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}