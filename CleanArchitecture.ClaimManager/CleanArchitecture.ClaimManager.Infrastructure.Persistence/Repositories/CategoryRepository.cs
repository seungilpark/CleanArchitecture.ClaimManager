using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Contexts;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repositories
{
    public class CategoryRepository : GenericRepositoryAsync<ExpenseCategory>, IClaimCategoryRepository
    {

        private readonly DbSet<ExpenseCategory> _categories;

        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _categories = dbContext.Set<ExpenseCategory>();
        }
    }
}
