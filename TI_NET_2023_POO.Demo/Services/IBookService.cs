using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_POO.Demo.Models;

namespace TI_NET_2023_POO.Demo.Services
{
    public interface IBookService
    {
        Book Add(Book b);

        List<Book> GetAll();

        Book Get(Func<Book, bool> predicate);

        bool Update(string isbn, Book b);

        bool Delete(string isbn);
    }
}
