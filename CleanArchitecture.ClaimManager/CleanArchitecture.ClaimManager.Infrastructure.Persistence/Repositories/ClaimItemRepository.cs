using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Contexts;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repositories
{
    public class ClaimItemRepository : GenericRepositoryAsync<ExpenseClaimLineItem>, IClaimItemRepository
    {
        public ClaimItemRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
