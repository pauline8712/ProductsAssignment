using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Application.DTOs
    //DTOs används framförallt för Querys. 
    //Detta är data som användaren kan se. 
    //T.ex det är utifrån de här attributerna användaren får tillbaka data utifrån. 
//T.ex {
//    "id": 1,
//    "name": "Stol",
//    "price": 299,
//    "categoryName": "Möbler"
//}
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}
