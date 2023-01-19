using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repos;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("controller")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepo repo;
        public RegionsController(IRegionRepo repo)
        {
            this.repo = repo;
        }
        [HttpGet("Regions")]
        public async Task<IActionResult> GetAllRegions()
        {
           var regions =  await repo.GetAll();
           
            return Ok(regions);
        }
    }
}
