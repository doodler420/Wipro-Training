using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

public class Program
{
    public static void Main()
    {
        Queue<Book> borrowedBooks = new Queue<Book>();
        borrowedBooks.Enqueue(new Book { Title = "Book 1", Author = "Author 1" });
        borrowedBooks.Enqueue(new Book { Title = "Book 2", Author = "Author 2" });
        borrowedBooks.Enqueue(new Book { Title = "Book 3", Author = "Author 3" });
        borrowedBooks.Enqueue(new Book { Title = "Book 4", Author = "Author 4" });
        borrowedBooks.Enqueue(new Book { Title = "Book 5", Author = "Author 5" });

        Console.WriteLine($"Next book to return: {borrowedBooks.Peek().Title}");
        borrowedBooks.Dequeue();

        Stack<Book> newBooks = new Stack<Book>();
        newBooks.Push(new Book { Title = "New Book 1", Author = "New Author 1" });
        newBooks.Push(new Book { Title = "New Book 2", Author = "New Author 2" });
        newBooks.Push(new Book { Title = "New Book 3", Author = "New Author 3" });

        Console.WriteLine($"Last purchased book: {newBooks.Peek().Title}");
        newBooks.Pop();

        Console.WriteLine("\nRemaining borrowed books:");
        foreach (var book in borrowedBooks)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }

        Console.WriteLine("\nRemaining new books:");
        foreach (var book in newBooks)
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
        }
    }
}