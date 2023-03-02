using Microsoft.AspNetCore.Mvc;
using Mission09_haylowry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_haylowry.Controllers
{
    public class HomeController : Controller
    {
        private BookstoreContext Context { get; set; }
        public HomeController (BookstoreContext temp)
        {
            Context = temp;
        }
        public IActionResult Index()
        {
            var books = Context.Books.ToList();
            return View(books);
        }

    }
}
