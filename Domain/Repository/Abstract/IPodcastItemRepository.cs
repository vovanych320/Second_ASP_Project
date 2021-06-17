using Podcast.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Podcast.Domain.Repository.Abstract
{
    public interface IPodcastItemRepository
    {
        IQueryable<PodcastItem> GetPodcastItems();
        PodcastItem GetPodcastItem(Guid id);
        void SavePodcastItem(PodcastItem entity);
        void DeletePodcastItem(Guid id);

        double GetMaxPrice();
    }
}
