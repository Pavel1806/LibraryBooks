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
    public class DeleteController : Controller
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
                    db.Books.Remove(t);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Home");
                }
            }
        }
    }
}
