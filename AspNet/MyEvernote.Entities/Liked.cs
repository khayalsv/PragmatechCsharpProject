using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvernote.Entities
{
    public  class Liked
    {
        [Key]
        public int Id { get; set; }
        public Note Note { get; set; }
        public EvernoteUser LikedUser { get; set; }
    }
}
