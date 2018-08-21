using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tomorowland.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Імя")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Прізвище")]
        public string Last_name { get; set; }

        [Required]
        [Display(Name = "Рік народження")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        [DataType(DataType.Password)]
        [Display(Name = "Підтвердити пароль")]
        public string PasswordConfirm { get; set; }
    }
}
