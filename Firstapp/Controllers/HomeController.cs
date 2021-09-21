using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Firstapp.Models;

namespace Firstapp.Controllers
{
    public class HomeController : Controller
    {

        BookContext db = new BookContext();

        public ActionResult Index()
        {
            IEnumerable<Purchase> purchases = db.Purchases;

            ViewBag.Purchases = purchases;

            IEnumerable<Book> books = db.Books;

            ViewBag.Books = books;

            return View();
        }
        //public ActionResult BoughtShow()
        //{
        //    IEnumerable<Purchase> purchases = db.Purchases;
        //    ViewBag.Purchases = purchases;
        //    return View();
        //}
        [HttpGet]
        public ActionResult Buy(int? id)
        {
            ViewBag.BookId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
            db.SaveChanges();
            return "Спасибо," + purchase.Person + ", за покупку!";
        }
    }
}