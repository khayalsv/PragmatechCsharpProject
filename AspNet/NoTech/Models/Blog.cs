using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Blog
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string Title { get; set; }


        public DateTime DateTime { get; set; }


        [StringLength(25)]
        public string byFrom { get; set; }



        [StringLength(80)]
        public string Name { get; set; }


        public string Link { get; set; }


        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

    }
}
