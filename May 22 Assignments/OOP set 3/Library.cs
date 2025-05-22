using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool IsAvailable { get; set; }
}

class Library
{
    public List<Book> Books { get; set; } = new List<Book>();

    public void AddBook(Book book)
    {
        Books.Add(book);
    }

    public List<Book> SearchByAuthor(string author)
    {
        return Books.Where(b => b.Author == author).ToList();
    }

    public List<Book> SearchByTitle(string title)
    {
       return Books.Where(b => b.Title == title).ToList();
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        library.Books = new List<Book>
        {
            new Book { Id = 1, Title = "C# Basics", Author = "John", IsAvailable = true },
            new Book { Id = 2, Title = "Advanced C#", Author = "John", IsAvailable = false },
            new Book { Id = 3, Title = "Learn Java", Author = "Jane", IsAvailable = true }
        };

        var byAuthor = library.SearchByAuthor("John");
        var byTitle = library.SearchByTitle("Java");

        Console.WriteLine("Books by John:");
        foreach (var book in byAuthor)
        {
            Console.WriteLine(book.Title);
        }

        Console.WriteLine("Books with 'Java' in title:");
        foreach (var book in byTitle)
        {
            Console.WriteLine(book.Title);
        }
    }
}
