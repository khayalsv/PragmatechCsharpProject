using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relation.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string BookName { get; set; }
        public int Page { get; set; }
        public int AuthorID { get; set; }
        public virtual Author Authors { get; set; }
    }
}
