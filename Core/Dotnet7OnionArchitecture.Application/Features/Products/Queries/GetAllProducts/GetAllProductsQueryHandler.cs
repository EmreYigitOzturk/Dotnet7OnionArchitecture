using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dotnet7OnionArchitecture.Application.Interfaces.UnitOfWorks;
using Dotnet7OnionArchitecture.Domain.Entities;
using MediatR;

namespace Dotnet7OnionArchitecture.Application.Features.Products.Queries.GetAllProducts
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQueryRequest, IList<GetAllProductsQueryResponse>>
    {
        private readonly IUnitOfWork unitOfWork;

        public GetAllProductsQueryHandler(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IList<GetAllProductsQueryResponse>> Handle(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await unitOfWork.GetReadRepository<Product>().GetAllAsync();
            return products.Select(p => new GetAllProductsQueryResponse
            {
                Title = p.Title,
                Description = p.Description,
                Price = p.Price - (p.Price * p.Discount / 100),
                Discount = p.Discount
            }).ToList();
        }
    }
}
