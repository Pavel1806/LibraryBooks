using LibraryBooks.Db;
using LibraryBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddingNewBook(string name, string book, int year, int quantityPage, string genre)
        {
            using (AppDb db = new AppDb())
            {
                Book copyBook = new Book(name, book, year, quantityPage, genre);
                db.Add(copyBook);
                db.SaveChanges();
            }
            //Book newBook = new Book(name, book, year, quantityPage, genre);
            //newBook.AddingBook(newBook);

            return RedirectToAction("Index", "Home");

        }
    }
}
