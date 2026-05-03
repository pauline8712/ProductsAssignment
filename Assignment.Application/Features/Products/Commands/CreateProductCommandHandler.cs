using AutoMapper;
using MediatR;
using Assignment.Application.DTOs;
using Assignment.Domain.Entities;
using Assignment.Domain.Interfaces;

namespace Assignment.Application.Features.Products.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, ProductDto>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public CreateProductCommandHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ProductDto> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Product()
            {
                Name = request.Name,
                Price = request.Price,
                CategoryId = request.CategoryId
            };

            await _repository.AddAsync(product);
            return _mapper.Map<ProductDto>(product);
        }
    }
}