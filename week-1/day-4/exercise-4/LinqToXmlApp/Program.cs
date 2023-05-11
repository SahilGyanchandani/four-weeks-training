using System;
using System.Linq;
using System.Xml.Linq;
class Program
{
    static void Main(string[] args)
    {
        XDocument xmlDocument = new XDocument(
            new XElement("Books",
                new XElement("Book",
                    new XElement("Title", "The Monk"),
                    new XElement("Author", "Jay Shetty"),
                    new XElement("Genre", "Motivation")
                ),
                new XElement("Book",
                    new XElement("Title", "Ramayan"),
                    new XElement("Author", "Valmiki ji"),
                    new XElement("Genre", "Devotees")
                ),
               new XElement("Book",
                    new XElement("Title", "Mahabharat"),
                    new XElement("Author", "Ved Vyas ji"),
                    new XElement("Genre", "Devotees")
                )
            )
        );
        string genre = "Classics";
        var booksInGenre = xmlDocument.Descendants("Book")
                                      .Where(b => b.Element("Genre").Value == genre);
        Console.WriteLine($"Books in the genre '{genre}':");
        foreach (var book in booksInGenre)
        {
            Console.WriteLine($"Title: {book.Element("Title").Value}, Author: {book.Element("Author").Value}");
        }
        Console.WriteLine();
        XElement newBook = new XElement("Book",
                                new XElement("Title", "Pride and Prejudice"),
                                new XElement("Author", "Jane Austen"),
                                new XElement("Genre", "Classics")
                            );
        xmlDocument.Root.Add(newBook);
        XElement existingBook = xmlDocument.Descendants("Book")
                                           .FirstOrDefault(b => b.Element("Title").Value == "The Alchemist");
        if (existingBook != null)
        {
            existingBook.Element("Author").Value = "Paulo Coelho (Updated)";
        }
        Console.WriteLine("Modified XML document:");
        Console.WriteLine(xmlDocument);
    }
}