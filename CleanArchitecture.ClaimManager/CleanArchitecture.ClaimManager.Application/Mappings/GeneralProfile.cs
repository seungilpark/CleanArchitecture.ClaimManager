using AutoMapper;
using CleanArchitecture.ClaimManager.Application.Features.ExpenseClaims.Commands.CreateExpenseClaim;
using CleanArchitecture.ClaimManager.Application.Features.Products.Commands.CreateProduct;
using CleanArchitecture.ClaimManager.Application.Features.Products.Queries.GetAllProducts;
using CleanArchitecture.ClaimManager.Domain.Entities;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Application.Mappings
{
    public class GeneralProfile : Profile
    {
        public GeneralProfile()
        {
            CreateMap<Product, GetAllProductsViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, Product>();
            CreateMap<GetAllProductsQuery, GetAllProductsParameter>();
            CreateMap<CreateExpenseClaimCommand, ExpenseClaim>();
            
        }
    }
}
