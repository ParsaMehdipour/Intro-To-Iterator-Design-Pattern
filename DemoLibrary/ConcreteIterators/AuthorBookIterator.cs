using DemoLibrary.Collections;
using DemoLibrary.IteratorAbstractions;

namespace DemoLibrary.ConcreteIterators;

/// <summary>
/// Author Iterator - traverses only books by a specific author
/// </summary>
public class AuthorBookIterator : IBookIterator
{
    private readonly Library library;
    private readonly string author;
    private int currentPosition;
    private List<Book> filteredBooks;

    public AuthorBookIterator(Library library, string author)
    {
        this.library = library;
        this.author = author;
        Reset();
    }

    private void FilterBooks()
    {
        filteredBooks = library.GetBooks()
            .Where(book => book.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public bool HasNext()
    {
        return currentPosition < filteredBooks.Count;
    }

    public Book GetNext()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more books to iterate");
        }

        var book = filteredBooks[currentPosition];
        currentPosition++;
        return book;
    }

    public void Reset()
    {
        FilterBooks();
        currentPosition = 0;
    }
}
