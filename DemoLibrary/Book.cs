namespace DemoLibrary;

/// <summary>
/// Object that our collection contains
/// </summary>
public class Book
{
    public string Title { get; }
    public string Author { get; }
    public int Year { get; }

    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}
