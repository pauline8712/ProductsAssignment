using MediatR;
using Assignment.Application.DTOs;

//Id är med — vi behöver veta vilken produkt användaren vill hämta
//IRequest<ProductDto?> — returnerar en enskild ProductDto, med ? eftersom produkten kanske inte finns
namespace Assignment.Application.Features.Products.Queries
{
    public class GetProductByIdQuery : IRequest<ProductDto?>
    {
        public int Id { get; set; }
    }
}