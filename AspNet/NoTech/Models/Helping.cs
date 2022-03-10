using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class Helping
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Icon { get; set; }
        public string SubTitle { get; set; }
        public string SubText { get; set; }

        public string Image { get; set; }

        [NotMapped]
        public IFormFile Photo { get; set; }
    }
}
