using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KS.Models
{
    public class HomePageM
    {
        public int ID { get; set; }
        [Required, StringLength(255)]
        public string Image { get; set; }

        [Required, StringLength(15)]
        public string Name { get; set; }

        [Required, StringLength(40)]
        public string HeadLine { get; set; }

        [Required, StringLength(255)]
        public string Twitter { get; set; }
        [Required, StringLength(255)]
        public string Facebook { get; set; }
        [Required, StringLength(255)]
        public string Linkedin { get; set; }
        [Required, StringLength(255)]
        public string Github { get; set; }
        [Required, StringLength(255)]
        public string Instagram { get; set; }
    }
}
