using Abstraction.Abstract;
using Abstraction.FakeDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Concrete
{
    public class Category : BaseClass
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public override bool IsActive { get; set; }

        public override string Add(object obj)
        {
            Category c = (Category)obj;
            DataBase.categoryList.Add(c);
            return "Catehory eklendi";
        }
    }
}
