using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_Lab1
{
    public class BookReaderDate
    {
        public Reader Reader;

        public Book Book;

        public DateTime TakeDate;

        public DateTime ReturnDate;

        public void TakeBook(Book bookID, Reader readerID, DateTime takeDate)
        {
            Book = bookID;
            Reader = readerID;
            TakeDate = takeDate;
        }

        public void ReturnBook(DateTime dateReturned)
        {
            ReturnDate = dateReturned;
            Book.IsTaken = false;
        }


    }
}
