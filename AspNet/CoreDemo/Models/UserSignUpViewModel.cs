using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Models
{
    public class UserSignUpViewModel
    {
        [Display(Name ="Ad Soyad")]
        [Required(ErrorMessage="Ad Soyad girin")]
        public string NameSurname { get; set; }
      
        [Display(Name = "Sifre")]
        [Required(ErrorMessage = "Ad Soyad girin")]
        public string Password { get; set; }

        [Display(Name = "Sifre Tekrar")]
        [Compare("Password",ErrorMessage ="Sifreler uygun deyil!")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Mail")]
        [Required(ErrorMessage = "Mail girin")]
        public string Mail { get; set; }

        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username girin")]
        public string Username { get; set; }
    }
}
