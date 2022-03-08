﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KSResumo.ViewModels
{
    public class ResetPasswordVM
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Token { get; set; }

        [Required]
        [StringLength(maximumLength:30)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [StringLength(maximumLength: 30)]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
