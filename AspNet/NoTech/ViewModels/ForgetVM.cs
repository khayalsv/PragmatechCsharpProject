using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NoTech.ViewModels
{
    public class ForgetVM
    {
        [Required]
        [EmailAddress,StringLength(maximumLength: 45)]
        public string Email { get; set; }
    }
}
