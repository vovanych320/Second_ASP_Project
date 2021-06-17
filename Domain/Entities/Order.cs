using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Entities
{
    public class Order
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name ="Ім'я")]
        [Required(ErrorMessage ="Поле Ім'я необхідне")]
        public string Name { get; set; }

        [Display(Name="Прізвище")]
        [Required(ErrorMessage = "Поле Прізвище необхідне")]
        public string Surname { get; set; }

        [Display(Name ="Email")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Поле Email необхідне")]
        public string Email { get; set; }

        [Required]
        [ScaffoldColumn(false)]
        public DateTime OrderTime { get; set; }

        public List<OrderDetails> AllOrderDetails { get; set; }
    }
}
