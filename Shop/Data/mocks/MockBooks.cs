using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockBooks : IAllBooks
    {
        private readonly IBooksCategory _categoryBooks = new MockCategory();
        public IEnumerable<Book> Books {
            get
            {
                return new List<Book>
                {
                    new Book {
                        name="Голодные игры",
                        author=" Голодные игры",
                        Janr="Фантастика,боевик",
                        Otzyvy="7/10",
                        img="/img/ГИ.PNG",
                        price=3500,
                        isFavourite=true,
                        available=true,
                        Category=_categoryBooks.AllCategories.Last()},
                    new Book
                    {
                        name="Библия комедии. Stand Up",
                        author="Джуди Картер",
                        Janr="Комедия",
                        Otzyvy="9/10",
                        img="/img/БК.PNG",
                        price=2200,
                        isFavourite=true,
                        available=true,
                        Category=_categoryBooks.AllCategories.Last()
                    },
                    new Book
                    {
                        name="Виноваты звезды",
                        author="Грин Дж.",
                        Janr="Love story",
                        Otzyvy="8/10",
                        img="/img/ВЗ.PNG",
                        price=4300,
                        isFavourite=true,
                        available=true,
                        Category=_categoryBooks.AllCategories.First()
                    }
                };
            }
        }
        public IEnumerable<Book> getFavBooks { get; set; }

        public Book getObjectBook(int bookId)
        {
            throw new NotImplementedException();
        }
    }
}
