using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class BookController : Controller
    {
        BookDbContext db = new BookDbContext();
        // GET: Book
        public ActionResult Index()
        {
          
            return View(db.books.ToList());
        }

        public ActionResult Create()
        {
            Book book = new Book();
            return View(book);
        }

        [HttpPost]
        public ActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                book.id = db.books.Count() + 1;
                db.books.Add(book);
                db.SaveChanges();
                return RedirectToAction("Index");

            }
            else
                return View(book);
        }
    }
}