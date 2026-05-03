using MediatR;
using Assignment.Domain.Entities;
using Assignment.Domain.Interfaces;

//Hämtar produkten via GetByIdAsync — kollar att den faktiskt finns
//Finns den inte? → returnerar false
//Finns den? → tar bort den via DeleteAsync → returnerar true
namespace Assignment.Application.Features.Products.Commands
{
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
    {
                private readonly IRepository<Product> _repository;
        public DeleteProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _repository.GetByIdAsync(request.Id);
            if (product == null)
            {
                return false;
            }
            await _repository.DeleteAsync(request.Id);
            return true;
        }
    }
}

