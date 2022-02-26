using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.ViewModels
{
    public class StudentVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Fullname { get; set; }

    }
}
