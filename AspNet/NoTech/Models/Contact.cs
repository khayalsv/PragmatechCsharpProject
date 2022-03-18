using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Contact
    {
        public int ID { get; set; }
        [Required,StringLength(50)]
        public string Name { get; set; }
        [EmailAddress,StringLength(60)]
        public string Email { get; set; }
        [Required,StringLength(70)]
        public string Message { get; set; }

    }
}
