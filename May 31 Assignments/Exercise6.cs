using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public bool IsBorrowed { get; set; }
    public string BorrowedBy { get; set; }
    public DateTime? DueDate { get; set; }
}

class Student
{
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        var books = new List<Book>
        {
            new Book { Title = "C# Basics" },
            new Book { Title = "LINQ Essentials" }
        };

        var student = new Student { Name = "Alice" };

        // Borrow a book (simulate)
        var bookToBorrow = books[0];
        if (!bookToBorrow.IsBorrowed)
        {
            bookToBorrow.IsBorrowed = true;
            bookToBorrow.BorrowedBy = student.Name;
            bookToBorrow.DueDate = DateTime.Now.AddDays(14);
        }
        // Display status
        foreach (var book in books)
        {
            Console.WriteLine($"{book.Title} - {(book.IsBorrowed ? $"Borrowed by {book.BorrowedBy}, Due: {book.DueDate?.ToShortDateString()}" : "Available")}");
        }
    }
}
