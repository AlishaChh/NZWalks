using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repos
{
    public interface IRegionRepo
    {
        Task<IEnumerable<Regions>> GetAll(); 
    }
}
