using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.ViewModels
{
    public class ForgetPasswordVM
    {
        [Required]
        [StringLength(maximumLength:30)]
        public string Email { get; set; }
    }
}
