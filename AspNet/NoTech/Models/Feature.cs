using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Feature
    {
        public int ID { get; set; }
        public string Icon { get; set; }

        [Required,StringLength(30)]
        public string Title { get; set; }

        [StringLength(100)]
        public string Text { get; set; }

        public string Link { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
