using System;
using System.ComponentModel.DataAnnotations;

namespace dojo_league.Models
{
    public class Ninja : BaseEntity
    {
        [Key]
        public long id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Level { get; set; }

        [Required]
        public string Description { get; set; }


        public DateTime created_at { get; set; }


        public DateTime updated_at { get; set; }

        
        public Dojo dojo { get; set; }


        public Ninja()
        {
            
        }
    }
}