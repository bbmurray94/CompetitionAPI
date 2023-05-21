using Competition.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CompetitionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorsController : ControllerBase
    {
        public CompetitorsController() { }

        [HttpGet("{id}", Name = "GetCompetitorById")]
        public async Task<ActionResult<CompetitorModel>> Get(int id) 
        {
            CompetitorModel model = new CompetitorModel()
            {
                Id = 125,
                Name = "Name",
                Rank = "Blue"
            };
            
            return Ok(model);
        }
    }
}
