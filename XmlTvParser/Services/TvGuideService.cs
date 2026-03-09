using System.Xml.Serialization;
using XmlTvParser.Models;

namespace XmlTvParser.Services
{
    public class TvGuideService
    {
        public async Task<Tv> GetTvGuideAsync()
        {
            var guides = new List<Tv>();

            foreach (var channel in Channels.AllLocal)
            {
                try
                {
                    var guide = await GetXmlAsync(channel.Id) 
                        ?? throw new Exception("guide was null");

                    guides.Add(guide);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Failed to get XML for channel {channel.Name} ({channel.Id}): {ex.Message}");
                }
            }

            return new Tv
            {
                Channels = [.. guides.SelectMany(g => g.Channels)],
                Programmes = [.. guides.SelectMany(g => g.Programmes)]
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
