using DummyDB_Lab1;
using System;

namespace DummyDB
{
    class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>();
            List<Reader> readers = new List<Reader>();
            List<BookReaderDate> bookReaderDate = new List<BookReaderDate>();
            Book firstBook = new Book
            {
                BookID = 1,
                Author = "М. А. Булгаков",
                BookName = "Мастер и Маргарита",
                PublicYear = 1928,
                BookCaseNumber = 2,
                ShelfNumber = 1,
                IsTaken = false
            };
            books.Add(firstBook);

            Book secondBook = new Book
            {
                BookID = 2,
                Author = "Ф. М. Достоевский",
                BookName = "Преступление и наказание",
                PublicYear = 1866,
                BookCaseNumber = 1,
                ShelfNumber = 2,
                IsTaken = false
            };
            books.Add(secondBook);

            Book thirdBook = new Book
            {
                BookID = 3,
                Author = "Н. В. Гоголь",
                BookName = "Мёртвые Души",
                PublicYear = 1842,
                BookCaseNumber = 3,
                ShelfNumber = 2,
                IsTaken = false
            };
            books.Add(thirdBook);

            Reader firstReader = new Reader
            {
                ReaderID = 1,
                ReaderName = "Иванов И.И.",
                TakeDate = new Dictionary<int, DateTime>
                {
                    {1, new DateTime(2023, 01, 01) }
                },
                ReturnDate = new Dictionary<int, DateTime>
                {
                    {1, new DateTime(2023, 01, 05)}
                }
            };
            readers.Add(firstReader);

            Reader secondReader = new Reader
            {
                ReaderID = 2,
                ReaderName = "Николаев Н.Н.",
                TakeDate = new Dictionary<int, DateTime>
                {
                    {2, new DateTime(2023,02,05)}
                }
            };
            readers.Add(secondReader);


            foreach (Book book in books)
            {
                bool isBookReturned = true;
                foreach (Reader reader in readers)
                {
                    if (!reader.IsBookReturned(book.BookID))
                    {
                        isBookReturned = false;
                        foreach (var date in reader.TakeDate)
                        {
                            Console.WriteLine($"Книга \"{book.BookName}\" находится на руках у читателя {reader.ReaderName} c {date.Value.ToString("dd.MM.yyyy")}");
                        }
                        Console.WriteLine();
                        break;
                    }
                    
                }

                if (isBookReturned)
                {
                    Console.WriteLine($"Книга \"{book.BookName}\" находится в библиотеке ");
                    Console.WriteLine();
                }
            }
        }
    }
}