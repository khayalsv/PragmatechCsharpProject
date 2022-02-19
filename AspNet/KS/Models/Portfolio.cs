using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class Portfolio
    {
        public int ID { get; set; }
        public string Image { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }

        [NotMapped]
        [Required(ErrorMessage = "Please download image")]
        public IFormFile Photo { get; set; }
    }
}
