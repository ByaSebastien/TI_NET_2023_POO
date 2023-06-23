using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TI_NET_2023_POO.Demo.Models;

namespace TI_NET_2023_POO.Demo.Datas
{
    public static class FakeDb
    {
        public static List<Book> Books = new List<Book>()
        {
            new Book
            {
                ISBN = "9780439708180",
                Title = "Harry Potter and the Philosopher's Stone",
                Description = "The first book in the Harry Potter series."
            },
            new Book
            {
                ISBN = "9780545010221",
                Title = "Harry Potter and the Chamber of Secrets",
                Description = "The second book in the Harry Potter series."
            },
            new Book
            {
                ISBN = "9780439139601",
                Title = "Harry Potter and the Prisoner of Azkaban",
                Description = "The third book in the Harry Potter series."
            }
        };

        public static bool TryParse(this Enum e,int ordinal,out Color color)
        {
            color = Color.a;

            try
            {
                color = (Color)ordinal;
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
    }
}
