namespace TestProjectAPI.Models
{
    public class BookModel
    {
        public int Id { get; set; }
        public string? BookName { get; set; }
        public string? AuthorName { get; set; }
        public string? BookTopic { get; set; }
        public int BookCover { get; set; }
        public string? SerialNo { get; set; }
        public bool IsAvailable { get; set; }
    }
}
