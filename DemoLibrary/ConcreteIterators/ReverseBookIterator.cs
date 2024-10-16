using DemoLibrary.Collections;
using DemoLibrary.IteratorAbstractions;

namespace DemoLibrary.ConcreteIterators;

/// <summary>
/// Reverse Iterator - traverses from last to first
/// </summary>
public class ReverseBookIterator : IBookIterator
{
    private readonly Library library;
    private int currentPosition;

    public ReverseBookIterator(Library library)
    {
        this.library = library;
        Reset();
    }

    public bool HasNext()
    {
        return currentPosition >= 0;
    }

    public Book GetNext()
    {
        if (!HasNext())
        {
            throw new InvalidOperationException("No more books to iterate");
        }

        var book = library.GetBooks()[currentPosition];
        currentPosition--;
        return book;
    }

    public void Reset()
    {
        currentPosition = library.GetBooks().Count - 1;
    }
}
