using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Entities
{
    public class ShopCartItem
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name ="Подкаст")]
        public PodcastItem Podcast { get; set; }

        [Display(Name ="Текст реклами")]
        public string Message { get; set;}
        
        [Display(Name ="Тривалість реклами")]
        public string Duration { get; set; }

        [Display(Name ="Час для реклами")]
        public string PremierTime { get; set; }

        [Display(Name ="Ціна реклами")]
        public double Price { get; set; }

        [Required]
        public string ShopCartId { get; set; }
    }
}
