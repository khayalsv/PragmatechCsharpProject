using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage ="Adinizi girin")]
        public string Username { get; set; }
      
        [Required(ErrorMessage = "Sifrenizi girin")]
        public string Password { get; set; }
    }
}
