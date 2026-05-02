using AutoMapper;
using MediatR;
using Assignment.Application.DTOs;
using Assignment.Domain.Entities;
using Assignment.Domain.Interfaces;
using Assignment.Application.Commands;

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
    }
}