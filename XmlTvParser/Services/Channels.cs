namespace XmlTvParser.Services
{
    public static class Channels
    {
        public record Channel(
            string Id,
            string Name,
            string Number,
            string? IconUrl = null
        );

        public static readonly Channel[] AllLocal =
        {
            //new ("468013", "KLJB-DT", "18.1"),
            //new ("496615", "DEFY", "18.3"),
            //new ("468665", "TEAM", "19.1"),
            //new ("465085", "Charge!", "19.2"),
            //new ("465305", "Comet", "19.3"),
            //new ("464991", "ROAR", "19.5"),
            //new ("465323", "MeTV", "19.6"),
            //new ("468486", "WEEKDT", "25.1"),
            //new ("484291", "WEEKABC", "25.2"),
            //new ("465036", "WEEKCW", "25.3"),
            //new ("465354", "WEEKION", "25.4"),
            //new ("466643", "KGCW-DT", "26.1"),
            //new ("464994", "CBS-SD", "26.4"),
            new ("468996", "WMBD", "31.1"),
            //new ("465292", "Bounce", "31.2"),
            //new ("496614", "LAFF", "31.3"),
            //new ("492942", "Mystery", "31.4"),
            //new ("466158", "WTVP-HD", "47.1"),
            //new ("464925", "WTVP-KD", "47.2"),
            //new ("472382", "World", "47.3"),
            //new ("496617", "Create", "47.4"),
            //new ("465151", "RTV", "51.2"),
            //new ("496603", "REVN", "51.3"),
            //new ("496600", "Action", "51.4")
        };
    }
}
