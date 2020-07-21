using ProjectASPCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectASPCore.Repository
{
    public interface IBookRepository
    {
        public IEnumerable<Book> GetAllBooks();
        public Book GetBookById(int id);

    }
}
