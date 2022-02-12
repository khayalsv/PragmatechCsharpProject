using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class About
    {
        public int ID { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }
        [Required, StringLength(40)]
        public string Subtitle { get; set; }
        [Required, StringLength(150)]
        public string Description { get; set; }
        [Required, StringLength(40)]
        public string Name { get; set; }
        [Required, StringLength(70)]
        public string Email { get; set; }
        [Required]
        public int Age { get; set; }
        [Required, StringLength(70)]
        public string From { get; set; }


        [Required, StringLength(100)]
        public string IconLogo { get; set; }
        [Required, StringLength(30)]
        public string Servicetitle { get; set; }
        [Required, StringLength(100)]
        public string ServiceDescription { get; set; }
    }
}
