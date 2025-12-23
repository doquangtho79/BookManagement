using BookManagement.Data;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index() => View(BookRepository.GetAll());

        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                BookRepository.Add(book);
                return RedirectToAction("Index");
            }
            return View(book);
        }
    }

}

