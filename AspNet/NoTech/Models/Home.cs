using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Home
    {
        public int ID { get; set; }

        [Required,StringLength(35)]
        public string Title1 { get; set; }


        [Required, StringLength(35)]
        public string Title2 { get; set; }



        public string VideoLink { get; set; }


        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
