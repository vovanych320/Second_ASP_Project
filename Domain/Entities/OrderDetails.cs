using System;
using System.ComponentModel.DataAnnotations;

namespace Podcast.Domain.Entities
{
    public class OrderDetails
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid OrderId { get; set; }

        [Required]
        public Guid PodcastId { get; set; }

        [Required]
        public string Message { get; set; }

        [Required]
        public string Duration { get; set; }

        [Required]
        public string Period { get; set; }

        [Required]
        public double Price { get; set; }

        public virtual PodcastItem Podcast { get; set;}

        public virtual Order MyOrder { get; set; }

    }
}