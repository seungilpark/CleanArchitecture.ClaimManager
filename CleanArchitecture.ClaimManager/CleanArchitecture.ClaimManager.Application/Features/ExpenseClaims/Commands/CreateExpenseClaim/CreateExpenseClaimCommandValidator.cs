using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Domain.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Application.Features.ExpenseClaims.Commands.CreateExpenseClaim
{
    public class CreateExpenseClaimCommandValidator: AbstractValidator<CreateExpenseClaimCommand>
    {
        private readonly IExpenseClaimRepositoryAsync expenseClaimRepository;

        public CreateExpenseClaimCommandValidator(IExpenseClaimRepositoryAsync expenseClaimRepository)
        {
            this.expenseClaimRepository = expenseClaimRepository;

            //RuleFor(p => p.Title)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull()
            //    .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.")
            //    .MustAsync(IsUniqueBarcode).WithMessage("{PropertyName} already exists.");

            //RuleFor(p => p.)
            //    .NotEmpty().WithMessage("{PropertyName} is required.")
            //    .NotNull()
            //    .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

        }

        //private async Task<bool> IsUniqueBarcode(string barcode, CancellationToken cancellationToken)
        //{
        //    return await productRepository.IsUniqueBarcodeAsync(barcode);
        //}
    }
}
