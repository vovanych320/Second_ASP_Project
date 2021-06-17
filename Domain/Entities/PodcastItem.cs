using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Entities
{
    public class PodcastItem
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Шлях до титульної картинки")]
        public string PathToPhoto { get; set; }

        [Display(Name = "Назва подкасту")]
        public string PodcastName { get; set; }

        [Display(Name = "Автор подкасту")]
        public string PodcastAuthor { get; set; }

        [Display(Name = "Тривалість подкасту")]
        public string PodcastDuration { get; set; }

        [Display(Name = "Дата виходу подкасту")]
        public string PodcastPremierDate { get; set; }

        [Display(Name = "Тема подкасту")]
        public string PodcastTopic { get; set; }

        [Display(Name = "Опис подкасту")]
        public string PodcastDescription { get; set; }

        [Display(Name = "Кількість слухачів подкасту")]
        public string PodcasrListenedAmount { get; set; }

        [Display(Name = "Замовники подкасту")]
        public string PodcastClients { get; set; }

        [Display(Name = "Цільова аудиторія")]
        public string PodcastAudience { get; set; }

        [Display(Name = "Посилання на подкаст")]
        public string PodcastLink { get; set; }


        [Display(Name ="Ціна подкасту")]
        public double PodcastPrice { get; set; }
    }
}
