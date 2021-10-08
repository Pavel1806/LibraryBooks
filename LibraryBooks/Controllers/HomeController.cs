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
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (AppDb db = new AppDb())
            {
                var u = db.Books.ToList();
                return View(u);
            }
        }

    }
}
