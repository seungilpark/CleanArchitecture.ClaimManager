using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Application.Interfaces
{
    public interface IClaimUnitOfWork : IDisposable
    {
        IExpenseClaimRepositoryAsync ClaimRepository { get; }
        // IExpenseClaimItemRepositoryAsync ClaimItems { get; }
        int Complete();

    }
}
