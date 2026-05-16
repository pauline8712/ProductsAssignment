using AutoMapper;
using MediatR;
using Assignment.Application.DTOs;
using Assignment.Domain.Entities;
using Assignment.Domain.Interfaces;

namespace Assignment.Application.Features.Products.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ProductDto?>
    {
        private readonly IRepository<Product> _repository;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IRepository<Product> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
    }
}