using LibraryBooks.Db;
using LibraryBooks.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryBooks.Controllers
{
    public class EditController : Controller
    {
        public IActionResult Index(string title)
        {
            using (AppDb db = new AppDb())
            {
                var t = db.Books.Where(p => p.Title == title).FirstOrDefault();                

                if (t == null)
                {
                    return RedirectToAction("Error", "Home");
                }
                else
                {
                    ViewBag.Author = t.Author;
                    ViewBag.Title = t.Title;
                    ViewBag.YearOfPublication = t.YearOfPublication;
                    ViewBag.NumberOfPages = t.NumberOfPages;
                    ViewBag.Genre = t.Genre;
                    
                    return View();
                }
            }
        }

        public IActionResult EditBook(string oldTitle, string author, string title, int year, int number, string genre)
        {
            using (AppDb db = new AppDb())
            {
                var t = db.Books.Where(p => p.Title == oldTitle).FirstOrDefault();

                t.Author = author;
                t.Title = title;
                t.YearOfPublication = year;
                t.NumberOfPages = number;
                t.Genre = genre;
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

        }

    }
}
