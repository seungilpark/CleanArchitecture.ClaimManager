using CleanArchitecture.ClaimManager.Domain.Entities;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Application.Interfaces.Repositories
{
    public interface IClaimCategoryRepository : IGenericRepositoryAsync<ExpenseCategory>
    {
    }
}
