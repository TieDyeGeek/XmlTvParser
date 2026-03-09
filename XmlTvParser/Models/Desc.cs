using System.Xml.Serialization;

namespace XmlTvParser.Models
{
    public class Desc
    {
        [XmlText]
        public string? Text { get; set; }
    }
}
