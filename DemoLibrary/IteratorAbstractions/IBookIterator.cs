namespace DemoLibrary.IteratorAbstractions;

/// <summary>
/// Provides an interface for iterating over a collection of books.
/// This allows sequential access to books in a collection without exposing the underlying representation.
/// </summary>
public interface IBookIterator
{
    bool HasNext();
    Book GetNext();
    void Reset();
}