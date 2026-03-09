using Microsoft.AspNetCore.Mvc;
using XmlTvParser.Services;
using System.Xml.Serialization;
using XmlTvParser.Models;

namespace XmlTvParser.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TvGuideController : ControllerBase
    {
        private readonly TvGuideService _tvGuideService = new();
      
        [HttpGet(Name = "Local")]
        [Produces("application/xml")]
        public async Task<IActionResult> Get()
        {
            var guide = await _tvGuideService.GetTvGuideAsync();
            var serializer = new XmlSerializer(typeof(Tv));
            using var stringWriter = new StringWriter();
            serializer.Serialize(stringWriter, guide);
            var xml = stringWriter.ToString();
            return Content(xml, "application/xml");
        }
    }
}
