using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class ProjectAbout
    {
        public int ID { get; set; }


        public string Title { get; set; }


        public string Text { get; set; }

        [StringLength(25)]
        public string BoxText { get; set; }


        public string List1 { get; set; }

        public string List2 { get; set; }


        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
