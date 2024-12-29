using QueryFlow.Models;

namespace QueryFlow.Repositories;

public interface IBookRepository
{
    List<Book> GetAll();
    Book GetById(int id);
    Book AddBook(Book book);
}

public class BookRepository : IBookRepository
{
    private List<Book> _books;

    public BookRepository()
    {
        _books = new List<Book>
        {
            new Book { Id = 1, Title = "GraphQL in Action", Author = "John Doe", Price = 29.99m },
            new Book { Id = 2, Title = "ASP.NET Core", Author = "Jane Smith", Price = 39.99m },
            new Book { Id = 3, Title = "C# Programming Basics", Author = "Michael Green", Price = 24.99m },
            new Book { Id = 4, Title = "Mastering JavaScript", Author = "Sarah Lee", Price = 34.99m },
            new Book { Id = 5, Title = "Python for Data Science", Author = "David Kim", Price = 49.99m },
            new Book { Id = 6, Title = "The Pragmatic Programmer", Author = "Andrew Hunt", Price = 39.99m },
            new Book { Id = 7, Title = "Clean Code", Author = "Robert C. Martin", Price = 44.99m },
            new Book { Id = 8, Title = "Web Development with React", Author = "Chris Parker", Price = 29.99m },
            new Book { Id = 9, Title = "Java: The Complete Reference", Author = "Herbert Schildt", Price = 54.99m },
            new Book { Id = 10, Title = "SQL for Beginners", Author = "Jessica Taylor", Price = 19.99m },
            new Book { Id = 11, Title = "Design Patterns: Elements of Reusable Object-Oriented Software", Author = "Erich Gamma", Price = 59.99m },
            new Book { Id = 12, Title = "Docker for Developers", Author = "Paul Johnson", Price = 44.99m },
            new Book { Id = 13, Title = "Building Microservices", Author = "Sam Newman", Price = 49.99m },
            new Book { Id = 14, Title = "The Mythical Man-Month", Author = "Fred Brooks", Price = 39.99m },
            new Book { Id = 15, Title = "Clean Architecture", Author = "Robert C. Martin", Price = 49.99m },
            new Book { Id = 16, Title = "The Art of Computer Programming", Author = "Donald E. Knuth", Price = 89.99m },
            new Book { Id = 17, Title = "JavaScript: The Good Parts", Author = "Douglas Crockford", Price = 24.99m },
            new Book { Id = 18, Title = "Introduction to Algorithms", Author = "Thomas H. Cormen", Price = 69.99m },
            new Book { Id = 19, Title = "The Clean Coder", Author = "Robert C. Martin", Price = 39.99m },
            new Book { Id = 20, Title = "Practical Object-Oriented Design", Author = "Sandi Metz", Price = 44.99m },
            new Book { Id = 21, Title = "Effective Java", Author = "Joshua Bloch", Price = 54.99m },
            new Book { Id = 22, Title = "Python Crash Course", Author = "Eric Matthes", Price = 34.99m },
            new Book { Id = 23, Title = "Java for Dummies", Author = "Barry Burd", Price = 29.99m },
            new Book { Id = 24, Title = "Learning PHP, MySQL & JavaScript", Author = "Robin Nixon", Price = 39.99m },
            new Book { Id = 25, Title = "The Clean Architecture", Author = "Robert C. Martin", Price = 49.99m },
            new Book { Id = 26, Title = "C++ Primer", Author = "Stanley B. Lippman", Price = 59.99m },
            new Book { Id = 27, Title = "Refactoring: Improving the Design of Existing Code", Author = "Martin Fowler", Price = 44.99m },
            new Book { Id = 28, Title = "You Don't Know JS", Author = "Kyle Simpson", Price = 29.99m },
            new Book { Id = 29, Title = "JavaScript: The Definitive Guide", Author = "David Flanagan", Price = 49.99m },
            new Book { Id = 30, Title = "Learn JavaScript VISUALLY", Author = "Ivelin Demirov", Price = 24.99m },
            new Book { Id = 31, Title = "Web Development with Node & Express", Author = "Ethan Brown", Price = 34.99m },
            new Book { Id = 32, Title = "Algorithms Unlocked", Author = "Thomas H. Cormen", Price = 29.99m },
            new Book { Id = 33, Title = "Game Programming Patterns", Author = "Robert Nystrom", Price = 39.99m },
            new Book { Id = 34, Title = "Agile Estimating and Planning", Author = "Mike Cohn", Price = 49.99m },
            new Book { Id = 35, Title = "Java Performance: The Definitive Guide", Author = "Charlie Hunt", Price = 59.99m },
            new Book { Id = 36, Title = "GraphQL: Getting Started", Author = "Apollo Team", Price = 29.99m },
            new Book { Id = 37, Title = "Learning SQL", Author = "Alan Beaulieu", Price = 39.99m },
            new Book { Id = 38, Title = "HTML & CSS: Design and Build Websites", Author = "Jon Duckett", Price = 29.99m },
            new Book { Id = 39, Title = "CSS: The Missing Manual", Author = "David Sawyer McFarland", Price = 34.99m },
            new Book { Id = 40, Title = "Automate the Boring Stuff with Python", Author = "Al Sweigart", Price = 34.99m },
            new Book { Id = 41, Title = "Learning React", Author = "Alex Banks", Price = 44.99m },
            new Book { Id = 42, Title = "Practical Python Projects", Author = "Laura Cassell", Price = 49.99m },
            new Book { Id = 43, Title = "Head First Java", Author = "Kathy Sierra", Price = 39.99m },
            new Book { Id = 44, Title = "Data Science from Scratch", Author = "Joel Grus", Price = 49.99m },
            new Book { Id = 45, Title = "HTML5: The Missing Manual", Author = "Matthew MacDonald", Price = 29.99m },
            new Book { Id = 46, Title = "Learning Git", Author = "Richard E. Silverman", Price = 29.99m },
            new Book { Id = 47, Title = "The DevOps Handbook", Author = "Gene Kim", Price = 59.99m },
            new Book { Id = 48, Title = "R for Data Science", Author = "Hadley Wickham", Price = 39.99m },
            new Book { Id = 49, Title = "Python for Data Analysis", Author = "Wes McKinney", Price = 44.99m },
            new Book { Id = 50, Title = "JavaScript Design Patterns", Author = "Addy Osmani", Price = 39.99m }
        };
    }

    public List<Book> GetAll() => _books;
    public Book GetById(int id) => _books.FirstOrDefault(b => b.Id == id);
    public Book AddBook(Book book)
    {
        book.Id = _books.Max(b => b.Id) + 1;
        _books.Add(book);
        return book;
    }
}
