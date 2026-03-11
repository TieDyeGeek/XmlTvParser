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
            new ("468013", "KLJB-DT", "18.1", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/us-local/fox-18-kljb-us.png"),
            new ("496615", "DEFY", "18.3", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/defy-us.png"),
            new ("468665", "TEAM", "19.1"),
            new ("465085", "Charge!", "19.2", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/charge-us.png"),
            new ("465305", "Comet", "19.3", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/comet-us.png"),
            new ("464991", "ROAR", "19.5", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/roar-us.png"),
            new ("465323", "MeTV", "19.6", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/me-tv-us.png"),
            new ("468486", "WEEKDT", "25.1", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/nbc-25-week-us.png"),
            new ("484291", "WEEKABC", "25.2", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/abc-us.png"),
            new ("465036", "WEEKCW", "25.3", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/cw-us.png"),
            new ("465354", "WEEKION", "25.4", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/ion-television-us.png"),
            new ("466643", "KGCW-DT", "26.1", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/cw-us.png"),
            new ("464994", "CBS", "26.4", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/cbs-logo-white-us.png"),
            new ("468996", "WMBD", "31.1", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/cbs-logo-white-us.png"),
            new ("465292", "Bounce", "31.2", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/bounce-us.png"),
            new ("496614", "LAFF", "31.3", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/laff-us.png"),
            new ("492942", "Mystery", "31.4", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/ion-mystery-us.png"),
            new ("466158", "WTVP-HD", "47.1", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/pbs-us.png"),
            new ("464925", "WTVP-KD", "47.2", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/pbs-kids-dash-icon-us.png"),
            new ("472382", "World", "47.3", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/world-pbs-us.png"),
            new ("496617", "Create", "47.4", "https://raw.githubusercontent.com/tv-logo/tv-logos/refs/heads/main/countries/united-states/create-us.png"),
            new ("465151", "RTV", "51.2"),
            new ("496603", "REVN", "51.3"),
            new ("496600", "Action", "51.4")
        };
    }
}
