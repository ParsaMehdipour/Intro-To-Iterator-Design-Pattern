using DemoLibrary.Collections;
using DemoLibrary.IteratorAbstractions;

namespace DemoLibrary.ConcreteIterators;

/// <summary>
/// Forward Iterator - traverses from first to last
/// </summary>
public class ForwardBookIterator : IBookIterator
{
    private readonly Library library;
    private int currentPosition;

    public ForwardBookIterator(Library library)
    {
        this.library = library;
        this.currentPosition = 0;
    }

    public bool HasNext()
    {
        var books = library.GetBooks();
        return currentPosition < books.Count;
    }

    public Book GetNext()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more books to iterate");
        }

        var book = library.GetBooks()[currentPosition];
        currentPosition++;
        return book;
    }

    public void Reset()
    {
        currentPosition = 0;
    }
}
