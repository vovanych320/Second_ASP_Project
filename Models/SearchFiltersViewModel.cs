using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Podcast.Domain.Entities;


namespace Podcast.Models
{
    public class SearchFiltersViewModel
    {
        public List<PodcastItem> Podcasts { get; set; }

        public string SearchString { get; set; }

        public string PodcastCategory { get; set; }

        public string PodcastPrice { get; set; }
    }
}
