using Microsoft.AspNetCore.Mvc;
using XmlTvParser.Services;
using XmlTvSharp;

namespace XmlTvParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TvGuideController : ControllerBase
    {
        private readonly TvGuideService _tvGuideService = new();
      
        [HttpGet(Name = "Local")]
        public async Task<XmlTvResult> Get()
        {
            var guide = await _tvGuideService.GetTvGuideAsync();
            return guide;
        }
    }
}
