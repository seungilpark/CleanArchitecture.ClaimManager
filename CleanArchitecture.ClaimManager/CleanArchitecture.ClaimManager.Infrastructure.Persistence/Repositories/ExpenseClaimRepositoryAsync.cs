using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Contexts;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repositories
{
    public class ExpenseClaimRepositoryAsync:GenericRepositoryAsync<ExpenseClaim>, IExpenseClaimRepositoryAsync
    {

        private readonly DbSet<ExpenseClaim> _claims;
        public ExpenseClaimRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _claims = dbContext.Set<ExpenseClaim>();
        }

        public async Task<List<ExpenseClaim>> GetSubmissionsAsync()
        {
            var submitted = 
                _claims
                .Where(ex => ex.Status == ExpenseClaimStatus.Submitted)
                .AsNoTracking()
                .ToListAsync();

            return await submitted;
        }

        public Task MarkApprovedAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task MarkProcessedAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task MarkQueriedAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task MarkRejectedAsync(int id)
        {
            throw new NotImplementedException();
        }

        //public Task<bool> IsUniqueBarcodeAsync(string barcode)
        //{
        //    return _products
        //        .AllAsync(p => p.Barcode != barcode);
        //}
    }
}   
