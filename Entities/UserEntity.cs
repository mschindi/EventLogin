using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace EventLogin.Entities
{
    [Table("User")]
    public class UserEntity : Entity
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }
        
        [Required]
        public int DSize { get; set; }
        
        
        // Erstellt eine Beziehung mit einem PK und FK mit dem EntityFramework
        public ICollection<EventEntity> Events { get; set; }

        
    }
}