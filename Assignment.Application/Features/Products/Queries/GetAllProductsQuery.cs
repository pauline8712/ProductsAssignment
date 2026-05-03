using Assignment.Application.DTOs;
using MediatR;
using System.Collections.Generic;

//Klassen är tom — vi behöver ingen extra information för att hämta alla produkter
//IRequest < IEnumerable < ProductDto >> — returnerar en lista av ProductDto till användaren
namespace Assignment.Application.Features.Products.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<ProductDto>>
    {
    }
}