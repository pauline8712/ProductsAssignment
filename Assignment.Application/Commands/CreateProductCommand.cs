using MediatR;
using Assignment.Application.DTOs;

namespace Assignment.Application.Commands
{

    //En klass av en Command som man senare kan skapa som ett objekt som MediatR ska skicka vidare till Handlern
    public class CreateProductCommand : IRequest<ProductDto>
    {
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

    }
}
