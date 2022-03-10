using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class ProjectBox
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string TopTitle { get; set; }


        [StringLength(45)]
        public string BoxTitle { get; set; }


        [StringLength(15)]
        public string Name1 { get; set; }
        [StringLength(15)]
        public string Name2 { get; set; }


        public string Link { get; set; }

        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
