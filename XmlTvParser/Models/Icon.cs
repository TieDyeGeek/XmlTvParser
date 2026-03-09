using System.Xml.Serialization;

namespace XmlTvParser.Models
{
    public class Icon
    {
        [XmlAttribute("src")]
        public string? Src { get; set; }
    }
}
