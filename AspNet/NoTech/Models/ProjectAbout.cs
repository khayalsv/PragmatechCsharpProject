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


        [StringLength(50)]
        public string Title { get; set; }


        [StringLength(70)]
        public string Text { get; set; }

        [StringLength(30)]
        public string BoxText { get; set; }


        [StringLength(40)]
        public string List1 { get; set; }

        [StringLength(35)]
        public string List2 { get; set; }


        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
