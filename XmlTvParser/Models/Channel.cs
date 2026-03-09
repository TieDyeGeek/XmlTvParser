using System.Xml.Serialization;

namespace XmlTvParser.Models
{
    public class Channel
    {
        [XmlAttribute("id")]
        public string? Id { get; set; }

        [XmlElement("display-name")]
        public string? DisplayName { get; set; }

        [XmlElement("icon")]
        public Icon? Icon { get; set; }
    }
}
