using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SampleTemplate.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Required,StringLength(255)]
        public string Image { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }

        [Required]
        public int Count { get; set; }
    }
}
