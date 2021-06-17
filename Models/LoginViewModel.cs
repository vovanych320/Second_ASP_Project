using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Поле логін необхідне")]
        [Display(Name = "Логін")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Поле пароль необхідне")]
        [UIHint("password")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [Display(Name = "Запам'ятати мене?")]
        public bool RememberMe { get; set; }
    }
}
