using System.Xml.Serialization;

namespace XmlTvParser.Models
{
    public class Programme
    {
        [XmlAttribute("channel")]
        public string? Channel { get; set; }

        [XmlAttribute("start")]
        public string? Start { get; set; }

        [XmlAttribute("stop")]
        public string? Stop { get; set; }

        [XmlElement("title")]
        public Title? Title { get; set; }

        [XmlElement("desc")]
        public Desc? Desc { get; set; }

        public void AdjustTime(TimeSpan offset)
        {
            var timeFormat = "yyyyMMddHHmmss zzz";

            if (DateTime.TryParseExact(Start, timeFormat, null, System.Globalization.DateTimeStyles.None, out var startTime))
            {
                startTime = startTime.Add(offset);
                Start = startTime.ToString(timeFormat).Replace(":", "");
            }

            if (DateTime.TryParseExact(Stop, timeFormat, null, System.Globalization.DateTimeStyles.None, out var stopTime))
                Stop = stopTime.Add(offset).ToString(timeFormat).Replace(":", "");
        }
    }
}
