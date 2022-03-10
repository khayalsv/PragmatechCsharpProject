using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.Models
{
    public class ServicesBox
    {
        public int ID { get; set; }


        [StringLength(20)]
        public string Title1 { get; set; }

        [StringLength(20)]
        public string Title2 { get; set; }


        [StringLength(15)]
        public string Text1 { get; set; }

        [StringLength(15)]
        public string Text2 { get; set; }


        public string Icon { get; set; }

    }
}
