using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Counter
    {
        public int ID { get; set; }
     
        [StringLength(10)]
        public string Odometer { get; set; }


        [StringLength(25)]
        public string Title { get; set; }


        [StringLength(25)]
        public string Text { get; set; }


        public string Icon { get; set; }


        //public string Image { get; set; }

        //[NotMapped]
        //public IFormFile Photo { get; set; }
    }
}
