namespace Exo_ASPMVC_01.Models 
{
    public class Travel
    {
        public required int Id { get; set; }
        public required string Title { get; set; }
        public required string Desc { get; set; }
        public required string? ShortDesc { get; set; }
        public required double Price { get; set; }
        public required string Pays { get; set; }
        public required int Rating { get; set; }
        public required string Image { get; set; }
        public required string Thumbnail { get; set; }
    }
}