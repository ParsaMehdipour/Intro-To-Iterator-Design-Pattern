using DemoLibrary.ConcreteIterators;
using DemoLibrary.IteratableAbstractions;
using DemoLibrary.IteratorAbstractions;

namespace DemoLibrary.Collections;

/// <summary>
/// Represents a collection of books in a library.
/// This class implements the IBookCollection interface, allowing for the addition of books
/// and providing various iterators for traversing the collection in different ways, including 
/// forward, reverse, and by specific authors.
/// </summary>
public class Library : IBookCollection
{
    private List<Book> books;

    public Library()
    {
        books = new List<Book>();
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public IBookIterator CreateForwardIterator()
    {
        return new ForwardBookIterator(this);
    }

    public IBookIterator CreateReverseIterator()
    {
        return new ReverseBookIterator(this);
    }

    public IBookIterator CreateAuthorIterator(string author)
    {
        return new AuthorBookIterator(this, author);
    }

    internal List<Book> GetBooks()
    {
        return books;
    }
}
