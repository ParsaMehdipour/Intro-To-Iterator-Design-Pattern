using DemoLibrary.IteratorAbstractions;

namespace DemoLibrary.IteratableAbstractions;

/// <summary>
/// Defines an interface for a collection of books.
/// This interface allows the creation of various iterators to traverse the book collection 
/// in different ways, such as forward, reverse, or filtered by author.
/// </summary>
public interface IBookCollection
{
    IBookIterator CreateForwardIterator();
    IBookIterator CreateReverseIterator();
    IBookIterator CreateAuthorIterator(string author);
}
