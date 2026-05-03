using AutoMapper;
using MediatR;
using Assignment.Application.DTOs;
using Assignment.Domain.Entities;
using Assignment.Domain.Interfaces;

//Hämtar alla produkter från databasen via GetAllAsync()
//AutoMapper omvandlar hela listan från IEnumerable<Product> till IEnumerable<ProductDto>
//Returnerar listan till användaren
namespace Assignment.Application.Features.Products.Queries
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<ProductDto>>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetAllProductsQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDto>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }
    }

}
