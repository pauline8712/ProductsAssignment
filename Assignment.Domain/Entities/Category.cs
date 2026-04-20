using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Domain.Entities
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;

        //En kategori kan ha många produkter
        public ICollection <Product> Products { get; set; } = new List<Product>();
    }
}