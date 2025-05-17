using System;

public abstract class Document
{
    public abstract void PrintContent();
    public void ShowDocumentType(string type) => Console.WriteLine($"Document Type: {type}");
}

public class WordDocument : Document
{
    public override void PrintContent() => Console.WriteLine("Printing Word document");
}

public class PDFDocument : Document
{
    public override void PrintContent() => Console.WriteLine("Printing PDF document");
}

public class Program
{
    public static void Main()
    {
        Document word = new WordDocument();
        Document pdf = new PDFDocument();

        word.ShowDocumentType("Word");
        word.PrintContent();
        pdf.ShowDocumentType("PDF");
        pdf.PrintContent();
    }
}