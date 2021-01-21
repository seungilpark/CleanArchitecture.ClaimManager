using AutoMapper;
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
        public string Title { get; set; }
        public int Requester { get; set; }
        public int Approver { get; set; }
        public DateTime SubmitDate { get; set; }
        public string RequesterComments { get; set; }
        public List<ExpenseClaimLineItem> ExpenseClaimLineItems { get; set; }
    }
    public class CreateExpenseclaimCommandHandler : IRequestHandler<CreateExpenseClaimCommand, Response<int>>
    {
        private readonly IExpenseClaimRepositoryAsync _expenseClaimRepository;
        private readonly IMapper _mapper;
        public CreateExpenseclaimCommandHandler(IExpenseClaimRepositoryAsync expenseClaimRepository, IMapper mapper)
        {
            _expenseClaimRepository = expenseClaimRepository;
            _mapper = mapper;
        }

        public async Task<Response<int>> Handle(CreateExpenseClaimCommand request, CancellationToken cancellationToken)
        {
            var claim = _mapper.Map<ExpenseClaim>(request);

            await _expenseClaimRepository.AddAsync(claim);
            return new Response<int>(claim.Id);

            //var product = _mapper.Map<Product>(request);
            // await _claimRepository.addAsync(claim);
        }
    }
}
