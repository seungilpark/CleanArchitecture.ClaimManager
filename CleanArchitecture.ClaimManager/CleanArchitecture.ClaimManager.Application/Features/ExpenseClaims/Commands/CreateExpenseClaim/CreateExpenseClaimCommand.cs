using AutoMapper;
using CleanArchitecture.ClaimManager.Application.DTOs.ExpenseClaim;
using CleanArchitecture.ClaimManager.Application.Interfaces;
using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Application.Wrappers;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Application.Features.ExpenseClaims.Commands.CreateExpenseClaim
{
    public partial class CreateExpenseClaimCommand: IRequest<Response<int>>
    {
        public PostExpenseClaimDto ClaimDto { get; set; }
        public List<PostExpenseClaimItemDto> ClaimItems { get; set; }
    }
    public class CreateExpenseclaimCommandHandler : IRequestHandler<CreateExpenseClaimCommand, Response<int>>
    {
        private readonly IClaimUnitOfWork UnitOfWork;
        private readonly IMapper _mapper;
        public CreateExpenseclaimCommandHandler(IClaimUnitOfWork unitOfWork, IMapper mapper)
        {
            UnitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateExpenseClaimCommand request, CancellationToken cancellationToken)
        {
            var claim = _mapper.Map<ExpenseClaim>(request.ClaimDto);
            Console.WriteLine(claim);
            var items = _mapper.Map<ExpenseClaimLineItem[]>(request.ClaimItems);
            claim.ExpenseClaimLineItems = items;
            await UnitOfWork.ClaimRepository.AddAsync(claim);
            UnitOfWork.Complete();
            Console.WriteLine(claim);
            return new Response<int>(claim.Id);
        }
    }
}
