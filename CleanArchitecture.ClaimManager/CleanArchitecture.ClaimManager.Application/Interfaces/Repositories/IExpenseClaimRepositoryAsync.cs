using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Application.Interfaces.Repositories
{
    public interface IExpenseClaimRepositoryAsync: IGenericRepositoryAsync<ExpenseClaim>
    {
        // Get Claims with Submitted Status
        Task<List<ExpenseClaim>> GetSubmissionsAsync();
        // Query)
        Task MarkQueriedAsync(int id);
        // Reject
        Task MarkRejectedAsync(int id);
        // Approve
        Task MarkApprovedAsync(int id);
        // Process
        Task MarkProcessedAsync(int id);
    }
}
