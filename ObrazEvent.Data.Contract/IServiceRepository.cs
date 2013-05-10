using ObrazEvent.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObrazEvent.Data.Contract
{
    public interface IServiceRepository: IRepository<Service>
    {
        IQueryable<Photo> GetPhotos(int serviceId);
        IQueryable<Video> GetVideos(int serviceId);
    }
}
