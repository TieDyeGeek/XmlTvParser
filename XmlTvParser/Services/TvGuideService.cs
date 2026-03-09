using System.Xml.Serialization;
using XmlTvParser.Models;

namespace XmlTvParser.Services
{
    public class TvGuideService
    {
        public async Task<Tv> GetTvGuideAsync()
        {
            var tasks = Channels.AllLocal
                .Select(async channel => await GetXmlAsync(channel.Id));

            var results = await Task.WhenAll(tasks);

            var guides = results.Where(r => r != null).ToList();

            return new Tv
            {
                Date = DateTime.UtcNow.ToString("yyyyMMddHHmmss zzz"),
                Channels = [.. guides.SelectMany(g => g.Channels)],
                Programmes = [.. guides.SelectMany(g => g.Programmes)],
            };
        }

        private static async Task<Tv?> GetXmlAsync(string id)
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync($"https://epg.pw/api/epg.xml?lang=en&channel_id={id}")
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            var serializer = new XmlSerializer(typeof(Tv));
            return (Tv?)serializer.Deserialize(stream);
        }
    }
}
