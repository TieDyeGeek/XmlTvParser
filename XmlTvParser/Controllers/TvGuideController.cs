using Microsoft.AspNetCore.Mvc;
using XmlTvParser.Services;


namespace XmlTvParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TvGuideController : ControllerBase
    {
        private readonly TvGuideService _tvGuideService = new();

        public async Task<IActionResult> Get()
        {
            var guide = await _tvGuideService.GetTvGuideAsync();
            return Ok(guide);
        }
    }
}
