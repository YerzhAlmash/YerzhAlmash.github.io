using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.Models;

namespace Shop.Data.interfaces
{
     public interface IAllBooks
    {
        IEnumerable<Book> Books { get;  }
        IEnumerable<Book> getFavBooks { get;  }
        Book getObjectBook(int bookId);
    }
}
