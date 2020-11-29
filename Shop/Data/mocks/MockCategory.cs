using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Shop.Data.interfaces;
using Shop.Data.Models;

namespace Shop.Data.mocks
{
    public class MockCategory : IBooksCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName="Knigi",desc="Sovremennyi vid knig"},
                    new Category{categoryName="Classic books",desc="Knigi s raznymi zhanrami"}
                };
            }
        }
    }
}
