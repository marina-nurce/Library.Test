namespace Library.API.Dto
{
    public class PostLibraryDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicationYear { get; internal set; }
    }
}
