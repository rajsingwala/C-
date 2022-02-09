﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1.Model
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }

    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "Vulpate", Author = "Futurum", CoverImage = "Images/1.png" });
            books.Add(new Book { BookId = 2, Title = "Mazim", Author = "Sequiter Que", CoverImage = "Images/2.png" });
            books.Add(new Book { BookId = 3, Title = "Elit", Author = "Tempor", CoverImage = "Images/3.png" });
            books.Add(new Book { BookId = 4, Title = "Etiam", Author = "Option", CoverImage = "Images/4.png" });
            books.Add(new Book { BookId = 5, Title = "Feugait Eros Libex", Author = "Accumsan", CoverImage = "Images/5.png" });
            books.Add(new Book { BookId = 6, Title = "Nonummy Erat", Author = "Legunt Xaepius", CoverImage = "Images/6.png" });
            books.Add(new Book { BookId = 7, Title = "Nostrud", Author = "Eleifend", CoverImage = "Images/7.png" });
            books.Add(new Book { BookId = 8, Title = "Per Modo", Author = "Vero Tation", CoverImage = "Images/8.png" });
            books.Add(new Book { BookId = 9, Title = "Suscipit Ad", Author = "Jack Tibbles", CoverImage = "Images/9.png" });
            books.Add(new Book { BookId = 10, Title = "Decima", Author = "Tuffy Tibbles", CoverImage = "Images/10.png" });
            books.Add(new Book { BookId = 11, Title = "Erat", Author = "Volupat", CoverImage = "Images/11.png" });
            books.Add(new Book { BookId = 12, Title = "Consequat", Author = "Est Possim", CoverImage = "Images/12.png" });
            books.Add(new Book { BookId = 13, Title = "Aliquip", Author = "Magna", CoverImage = "Images/13.png" });

            return books;
        }
    }
}
