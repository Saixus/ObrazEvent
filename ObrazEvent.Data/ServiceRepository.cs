using ObrazEvent.Data.Contract;
using ObrazEvent.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazEvent.Data
{
    public class ServiceRepository : EFRepository<Service>, IServiceRepository
    {
        public ServiceRepository(DbContext context) : base(context) { }

        public IQueryable<Photo> GetPhotos(int serviceId)
        {
            return DbContext.Set<Photo>().Where(ph => ph.Service.Id == serviceId);
        }

        public IQueryable<Video> GetVideos(int serviceId)
        {
            return DbContext.Set<Video>().Where(v => v.Service.Id == serviceId);
        }
    }
}
