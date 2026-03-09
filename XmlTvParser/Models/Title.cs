using System.Xml.Serialization;

namespace XmlTvParser.Models
{
    public class Title
    {
        [XmlAttribute("lang")]
        public string? Lang { get; set; }

        [XmlText]
        public string? Text { get; set; }
    }
}
