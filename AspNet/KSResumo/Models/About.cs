using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.Models
{
    public class About
    {
        public int ID { get; set; }
        [Required]
        public string Text  { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Birthday { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
