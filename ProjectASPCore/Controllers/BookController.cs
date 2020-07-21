using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectASPCore.Models;
using ProjectASPCore.Repository;

namespace ProjectASPCore.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BookController(IBookRepository bookRepository, ICategoryRepository categoryRepository) {

            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;

        }

        public IActionResult List() {
            var books = _bookRepository.GetAllBooks();

            return View(books);
        }
    }
}
