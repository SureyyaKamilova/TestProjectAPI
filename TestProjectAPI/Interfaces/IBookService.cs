namespace TestProjectAPI.Interfaces
{
    public interface IBookService
    {
        void AvailableBooks();
        void BookInsert(string bookName, string authorName, string bookTopic, int coverNumber, string serialNo);
        string GetBooks(string bookTopic);
        
    }
}
