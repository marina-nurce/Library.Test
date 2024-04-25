using Library.API.Dto;
using Library.API.Models;

namespace Library.API.Services
{
    public class BooksService : IBooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }


        public List<Models.Books> GetAllBooks()
        {
            var allBooks = _context.Books.ToList();
            return allBooks;
        }

        public Books AddBooks(PostLibraryDto books)
        {

            var newBooks = new Models.Books()
            {
                Title = books.Title,
                Author =books.Author,
                PublicationYear = books.PublicationYear
            };

            _context.Books.Add(newBooks);
            _context.SaveChanges();

            return newBooks;
        }

        public void DeleteBooks(int id)
        {
            var booksDb = _context.Books
               .FirstOrDefault(n => n.Id == id);

            _context.Books.Remove(booksDb);
            _context.SaveChanges();
        }

        public Books GetBooksById(int id)
        {
            var newBooks = _context.Books
              .FirstOrDefault(n => n.Id == id);

            return newBooks;
        }

        public Books UpdateBooks(PutLibraryDto booksData, int id)
        {
            var booksDb = _context.Books
                 .FirstOrDefault(n => n.Id == id);

            booksDb.Title = booksData.Title;
            _context.Books.Update(booksDb);

            _context.SaveChanges();

            return booksDb;
        }
    }
}
