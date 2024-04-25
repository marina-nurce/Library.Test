using Library.API.Dto;

namespace Library.API.Services
{
    public interface IBooksService
    {
        List<Models.Books> GetAllBooks();
        Models.Books GetBooksById(int id);
        Models.Books AddBooks(PostLibraryDto books);
        Models.Books UpdateBooks(PutLibraryDto booksData, int id);
        void DeleteBooks(int id);
    }
}
