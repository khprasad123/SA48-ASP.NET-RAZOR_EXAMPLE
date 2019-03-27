using Razer_Exercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Razer_Exercise.Controllers
{
    public class BookController : Controller
    {
        // GET: Book
        public ActionResult ListBooks()
        {
            Book b1 = new Book(21,"three mistakes of my life","Hariprasad",2009);
            Book b2 = new Book(22, "three mistakes of my life", "Hariprasad", 2009);
            Book b3 = new Book(23, "three mistakes of my life", "Hariprasad", 2009);

            List<Book> list = new List<Book>();
            list.Add(b1);
            list.Add(b2);
            list.Add(b3);

            ViewData["Books"] = list;
            return View("../Home/About");
        }

       
    }
}