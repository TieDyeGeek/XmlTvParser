using XmlTvSharp;

namespace XmlTvParser.Services
{
    public class TvGuideService
    {
        public async Task<XmlTvResult> GetTvGuideAsync()
        {
            var guides = new List<XmlTvResult>();

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

            return new XmlTvResult
            {
                Channels = [.. guides.SelectMany(g => g.Channels)],
                Programmes = [.. guides.SelectMany(g => g.Programmes)]
            };
        }


        private async Task<XmlTvResult?> GetXmlAsync(string id)
        {
            var httpClient = new HttpClient();
            using var response = await httpClient
                .GetAsync($"https://epg.pw/api/epg.xml?lang=en&channel_id={id}")
                .ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            return await response.Content
                .ReadFromJsonAsync<XmlTvResult>();
        }
    }
}
