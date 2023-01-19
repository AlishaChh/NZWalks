using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repos
{
    public class RegionRepo : IRegionRepo
    {
        private readonly NZWalksDBContext nz;


        // create the constructor 
        public RegionRepo(NZWalksDBContext nz) { 

            this.nz = nz;

        }
        public async Task<IEnumerable<Regions>> GetAll()
        {
            // here you can access the regions 
             return await nz.Region.ToListAsync();
        }
    }
}
