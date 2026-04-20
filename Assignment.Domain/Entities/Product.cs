using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty
        public decimal Price { get; set; }

        //Relation till Category
        public int CategoryId { get; set; }// Det är en foreign key som pekar på vilken kategori produkten tillhör.

        public Category Category { get; set; } = null!;
    }
}