using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim
{
    public enum ExpenseClaimStatus
    {
        Submitted,
        Rejected,
        Queryed,
        Approved,
        Processed
    }
}
