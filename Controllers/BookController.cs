using Microsoft.AspNetCore.Mvc;
using NetCoreMVCLab04.Models;

namespace NetCoreMVCLab04.Controllers
{
    public class BookController : Controller
    {
        protected Book book = new Book();

        public IActionResult Index()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;

            var books = book.GetBookList();
            return View(books);
        }

        public PartialViewResult PopularBook()
        {
            var books = book.GetBookList();
            return PartialView(books);
        }
    }
}