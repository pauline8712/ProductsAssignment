using MediatR;

namespace Assignment.Application.Features.Products.Commands
{

    //IRequest<bool> istället för IRequest<ProductDto> — vid uppdatering returnerar vi bara true eller false om det lyckades, inte hela produkten
    //Id är med — vi behöver veta vilken produkt som ska uppdateras
    public class UpdateProductCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}