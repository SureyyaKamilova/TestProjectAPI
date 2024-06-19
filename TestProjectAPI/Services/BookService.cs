using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TestProjectAPI.Concrete;
using TestProjectAPI.Interfaces;
using TestProjectAPI.Models;

namespace TestProjectAPI.Services
{
    public class BookService : IBookService
    {
        private readonly Context _context;

        public BookService(Context context)
        {
            _context = context;
        }

        public void AvailableBooks()
        {
            var availableBooks = _context.Set<BookModel>()
                                       .FromSqlRaw("Select *from AvailableBooks")
                                       .ToList();

            foreach (var book in availableBooks)
            {
                Console.WriteLine($"{book.BookName} - {book.AuthorName}");

            }
        }

        public void BookInsert(string bookName, string authorName, string bookTopic, int coverNumber, string serialNo)
        {
            var bookNameParameter = new SqlParameter("@BookName", bookName);
            var authorNameParameter = new SqlParameter("@AuthorName", authorName);
            var bookTopicParameter = new SqlParameter("@BookTopic", bookTopic);
            var coverNumberParameter = new SqlParameter("@CoverNumber", coverNumber);
            var serialNoParameter = new SqlParameter("@SerialNo", serialNo);

            var creatorId = 1;
            var modifierId = 1;
            var isAvailable = true;
            var arrivalDate = DateTime.Now;
            var endDate = DateTime.Now;

            _context.Database.ExecuteSqlRaw("Exec BookInsert @CreatorId, @ModifierId, @BookName, @AuthorName , @BookTopic, @CoverNumber," +
                "                                            @SerialNo, @IsAvailable , @ArrivalDate, @EndDate",
                                            creatorId, modifierId, bookNameParameter, authorNameParameter, bookTopicParameter, coverNumberParameter,
                                            serialNoParameter, isAvailable, arrivalDate, endDate
                                            );

        }

        public string GetBooks(string bookTopic)
        {
            var bookTopicParameter = new SqlParameter("@BookTopic",bookTopic);

            var getBooks = _context.Books.FromSqlRaw("Select dbo.ShowBooks(N'Dedektiv') As Books", bookTopicParameter)
                                 .AsEnumerable()
                                 .Select(x => x.BookName + "-" + x.AuthorName)
                                 .FirstOrDefault();

            return getBooks;
        }
    }
}
