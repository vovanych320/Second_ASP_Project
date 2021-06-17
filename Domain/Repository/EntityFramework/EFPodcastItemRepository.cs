using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Podcast.Domain.Entities;
using Podcast.Domain.Repository.Abstract;

namespace Podcast.Domain.Repository.EntityFramework
{
    public class EFPodcastItemRepository :  IPodcastItemRepository
    {
        private readonly ApplicationDbContext context;

        public EFPodcastItemRepository(ApplicationDbContext context)
        {
            this.context = context;
        }


        public IQueryable<PodcastItem> GetPodcastItems()
        {
            return context.Podcasts;
        }

        public PodcastItem GetPodcastItem(Guid id)
        {
            return context.Podcasts.FirstOrDefault(x => x.Id == id);
        }


        public void SavePodcastItem(PodcastItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeletePodcastItem(Guid id)
        {
            context.Podcasts.Remove(new PodcastItem() { Id = id });
            context.SaveChanges();
        }



       public  double GetMaxPrice()
        {
            return GetPodcastItems().Max<PodcastItem>().PodcastPrice;
        }
    }
}
