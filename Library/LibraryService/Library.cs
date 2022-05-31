using Library.Models;

namespace Library.LibraryService
{
    static public class LibraryService
    {
        static int Id = 3;
        static string? Name { get; set; }
        static List<Book>? Books { get; }


        static LibraryService()
        {
            Books = new List<Book>()
            {
                new Book() { Id = 1, Name = "NotBadBook", IsAutographFree = true, Price = 5000.0M, Genre = Genre.Сomedy },
                new Book() { Id = 2, Name = "SeriusSam", IsAutographFree = true, Price = 1000.0M, Genre = Genre.Melodrama },
                new Book() { Id = 3, Name = "NetworkProgrammingC#", IsAutographFree = true, Price = 5000.0M, Genre = Genre.Сomedy },
            };
        }

        public static List<Book> GetAll() => Books;
        public static Book? GetBook(int id) => Books.FirstOrDefault(b => b.Id == id);
        
        public static void AddBook(Book book)
        {
            book.Id = Id++;
            Books.Add(book);
        }
        public static void Delete(int id)
        {
            var book = GetBook(id);
            if(book is null)
            {
                return;
            }
            Books.Remove(book);
        }
        public static void Update(Book book)
        {
            var index = Books.FindIndex(x => x.Id == book.Id);

            if(index == -1)
            {
                return;
            }
            Books[index] = book;
        }

    }
}
