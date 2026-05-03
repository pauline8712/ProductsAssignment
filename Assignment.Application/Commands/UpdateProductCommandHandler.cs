using MediatR;
using Assignment.Domain.Entities;
using Assignment.Domain.Interfaces;

//Hämtar produkten från databasen via GetByIdAsync
//Om den inte finns så returneras false
//Finns den då uppdateras fälten och sparar det kommer då returnera true

namespace Assignment.Application.Features.Products.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, bool>
    {
        private readonly IRepository<Product> _repository;

        public UpdateProductCommandHandler(IRepository<Product> repository)
        {
            _repository = repository;
        }


    }
}