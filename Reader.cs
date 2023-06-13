using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyDB_Lab1
{
    public class Reader
    {
        public int ReaderID;
        public string ReaderName;
        public Dictionary<int, DateTime> TakeDate;
        public Dictionary<int, DateTime> ReturnDate;

        public bool IsBookReturned(int bookID)
        {
            if (TakeDate.ContainsKey(bookID) && (ReturnDate == null || ReturnDate.ContainsKey(bookID) == false))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
