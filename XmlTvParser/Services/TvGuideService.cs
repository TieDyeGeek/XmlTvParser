using System.Xml.Serialization;
using XmlTvParser.Models;

namespace XmlTvParser.Services
{
    public class TvGuideService
    {
        public async Task<Tv> GetTvGuideAsync()
        {
            var offset = new TimeSpan(); //TimeZoneInfo.Local.GetUtcOffset(DateTime.Now);

            var tasks = Channels.AllLocal
                .Select(async channel => 
                {
                    var data = await GetXmlAsync(channel.Id);

                    data?.Channels.ForEach(c => 
                    { 
                        c.Id = channel.Number;
                        c.DisplayName = channel.Name;
                    });

                    data?.Programmes.ForEach(p => 
                    {
                        p.Channel = channel.Number;
                        p.AdjustTime(offset);
                    });

                    return data;
                });

            var results = await Task.WhenAll(tasks);

            var guides = results.Where(r => r != null).ToList();


            return new Tv
            {
                Date = DateTime.Now.ToString("yyyyMMddHHmmss zzz").Replace(":",""),
                GeneratorInfoName = "XmlTvParser",
                GeneratorInfoUrl = "XmlTvParser",
                SourceInfoName = "epg.pw",
                SourceInfoUrl = "https://epg.pw",
                Channels = [.. guides.SelectMany(g => g.Channels)],
                Programmes = [.. guides.SelectMany(g => g.Programmes)],
            };
        }

        private static async Task<Tv?> GetXmlAsync(string id)
        {
            using var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync($"https://epg.pw/api/epg.xml?lang=en&timezone=QW1lcmljYS9DaGljYWdv&channel_id={id}")
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var stream = await response.Content.ReadAsStreamAsync();
            var serializer = new XmlSerializer(typeof(Tv));
            return (Tv?)serializer.Deserialize(stream);
        }
    }
}
