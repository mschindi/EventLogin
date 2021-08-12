using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventLogin.Entities
{
    [Table("Event")]
    public class EventEntity : Entity
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
        
        [Required]
        public string Location { get; set; }
        
        [Required]
        [Range(0, Int32.MaxValue)]
        public int MaxUsers { get; set; }
        
        
        // Erstellt eine Beziehung mit einem PK und FK mit dem EntityFramework
        public ICollection<UserEntity> Users { get; set; }
        
    }
}