using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Book.Any())
            {
                content.AddRange(
                    new Book
                    {
                        name = "Голодные игры",
                        author = "Сьюзен Коллинз",
                        Janr = "Фантастика,боевик",
                        Otzyvy = "7/10",
                        img = "/img/ГИ.PNG",
                        price = 3500,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Knigi"]
                    },
                    new Book
                    {
                        name = "Библия комедии. Stand Up",
                        author = "Джуди Картер",
                        Janr = "Комедия",
                        Otzyvy = "9/10",
                        img = "/img/БК.PNG",
                        price = 2200,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Classic books"]
                    },
                    new Book
                    {
                        name = "Виноваты звезды",
                        author = "Грин Дж.",
                        Janr = "Love story",
                        Otzyvy = "8/10",
                        img = "/img/ВЗ.PNG",
                        price = 4300,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Classic books"]
                    }
                    );
            }

            content.SaveChanges();

        }
        private static Dictionary<string,Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[] {
                    new Category {categoryName="Knigi",desc="Sovremennyi vid knig"},
                    new Category{categoryName="Classic books",desc="Knigi s raznymi zhanrami"
                    }
                 };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
