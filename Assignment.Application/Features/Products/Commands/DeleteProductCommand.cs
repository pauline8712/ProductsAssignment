using MediatR;

namespace Assignment.Application.Features.Products.Commands
{
    public class DeleteProductCommand : IRequest<bool>
    {
                public int Id { get; set; }
    }
}

// vi behöver bara Id för att veta vilken produkt som ska tas bort
//IRequest<bool> — returnerar true om borttagningen lyckades, false om produkten inte hittades