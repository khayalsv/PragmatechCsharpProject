using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Testimonials
    {
        public int ID { get; set; }

        [StringLength(150)]
        public string Text { get; set; }

        [StringLength(25)]
        public string Name { get; set; }


        [StringLength(45)]
        public string Company { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
