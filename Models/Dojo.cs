using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace dojo_league.Models
{
    public class Dojo : BaseEntity
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Location { get; set; }

        [Required]
        public string Info { get; set; }


        public DateTime created_at { get; set; }


        public DateTime updated_at { get; set; }

        
        public ICollection<Ninja> ninjas { get; set; }


        public Dojo()
        {
            
        }
    }
}