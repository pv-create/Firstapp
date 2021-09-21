using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Firstapp.Models
{
    public class BookDbInitializer: DropCreateDatabaseAlways<BookContext>
    {
        protected override void Seed(BookContext db)
        {
            db.Books.Add(new Book {Date = new DateTime(2008, 6, 1, 7, 47, 0), Pages=1200, Name = "Война и мир", Author = "Л. Толстой", Price = 220 });
            db.Books.Add(new Book {Date = new DateTime(2010, 6, 1, 7, 47, 0),Pages =800, Name = "Отцы и дети", Author = "И. Тургенев", Price = 180 });
            db.Books.Add(new Book {Date = new DateTime(2009, 6, 1, 7, 47, 0), Pages =100, Name = "Чайка", Author = "А. Чехов", Price = 150 });

            base.Seed(db);
        }
    }
}