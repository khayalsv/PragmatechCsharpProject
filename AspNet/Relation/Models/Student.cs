using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string Fullname { get; set; }
        public virtual Address Addresses { get; set; }
    }
}
