using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.ViewModels
{
    public class CustomerVM
    {
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string ProductName { get; set; }
    }
}
