// Create and populate the library
using DemoLibrary;
using DemoLibrary.Collections;
using DemoLibrary.IteratorAbstractions;

Library library = new Library();
library.AddBook(new Book("1984", "George Orwell", 1949));
library.AddBook(new Book("Animal Farm", "George Orwell", 1945));
library.AddBook(new Book("Pride and Prejudice", "Jane Austen", 1813));
library.AddBook(new Book("Emma", "Jane Austen", 1815));

// Using Forward Iterator
Console.WriteLine("Forward Iteration:");
IBookIterator forwardIterator = library.CreateForwardIterator();
while (forwardIterator.HasNext())
{
    Book book = forwardIterator.GetNext();
    Console.WriteLine($"{book.Title} ({book.Year})");
}

// Using Reverse Iterator
Console.WriteLine("\nReverse Iteration:");
IBookIterator reverseIterator = library.CreateReverseIterator();
while (reverseIterator.HasNext())
{
    Book book = reverseIterator.GetNext();
    Console.WriteLine($"{book.Title} ({book.Year})");
}

// Using Author Iterator
Console.WriteLine("\nAuthor Iteration (George Orwell):");
IBookIterator authorIterator = library.CreateAuthorIterator("George Orwell");
while (authorIterator.HasNext())
{
    Book book = authorIterator.GetNext();
    Console.WriteLine($"{book.Title} ({book.Year})");
}

// Reset and reuse an iterator
Console.WriteLine("\nReusing Forward Iterator after reset:");
forwardIterator.Reset();
Console.WriteLine("Reset ...");
while (forwardIterator.HasNext())
{
    Book book = forwardIterator.GetNext();
    Console.WriteLine($"{book.Title} ({book.Year})");
}