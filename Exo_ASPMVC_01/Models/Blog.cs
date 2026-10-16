namespace Exo_ASPMVC_01.Models
{
    public class Blog
    {
        public required int Id { get; set; }
        public required DateTime CreateDate { get; set; }
        public required string Title { get; set; }
        public required string Slug { get; set; }
        public required string Content { get; set; }
    }
}