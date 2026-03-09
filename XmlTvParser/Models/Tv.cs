using System.Xml.Serialization;

namespace XmlTvParser.Models
{
    [XmlRoot("tv")]
    public class Tv
    {
        [XmlAttribute("date")]
        public string? Date { get; set; }

        [XmlAttribute("generator-info-name")]
        public string? GeneratorInfoName { get; set; }

        [XmlAttribute("generator-info-url")]
        public string? GeneratorInfoUrl { get; set; }

        [XmlAttribute("source-info-name")]
        public string? SourceInfoName { get; set; }

        [XmlAttribute("source-info-url")]
        public string? SourceInfoUrl { get; set; }

        [XmlElement("channel")]
        public List<Channel> Channels { get; set; } = [];

        [XmlElement("programme")]
        public List<Programme> Programmes { get; set; } = [];
    }
}
