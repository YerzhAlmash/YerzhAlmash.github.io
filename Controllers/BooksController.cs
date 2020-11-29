using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class BooksController : Controller
    {
        private readonly IAllBooks _allBooks;
        private readonly IBooksCategory _allCategories;

        public BooksController(IAllBooks iAllBooks,IBooksCategory iBooksCat)
        {
            _allBooks = iAllBooks;
            _allCategories = iBooksCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "page with books";
            BooksListViewModel obj = new BooksListViewModel();
            obj.allBooks = _allBooks.Books;
            obj.currCategory = "Книги";

            return View();
        }
    }
}
