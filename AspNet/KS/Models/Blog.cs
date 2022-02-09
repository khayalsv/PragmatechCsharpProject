using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class Blog
    {
        public int ID { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }

        [Required, StringLength(15)]
        public string Title { get; set; }

        [Required, StringLength(40)]
        public string Text { get; set; }

        [Required, StringLength(10)]
        public string Date { get; set; }
    }
}
