using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Customer
    {
        public int ID { get; set; }
        [Required]
        public string CustomerName { get; set; }
        public virtual Product Products { get; set; }
    }
}
