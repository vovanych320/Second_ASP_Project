using Podcast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Models
{
    public class ShopCartViewModel
    {
        [Display(Name ="Подкаст")]
        public PodcastItem Podcast { get; set; }

        [Display(Name = "Текст реклами")]
        [Required(ErrorMessage ="Введіть текст реклами")]
        public string Message { get; set; }

        [Required(ErrorMessage = "Введіть тривалість реклами")]
        [Display(Name = "Тривалість реклами")]
        public string Duration { get; set; }

        [Required(ErrorMessage = "Введіть період для реклами")]
        [Display(Name = "Період для реклами")]
        public string PremierTime { get; set; }
    }
}
