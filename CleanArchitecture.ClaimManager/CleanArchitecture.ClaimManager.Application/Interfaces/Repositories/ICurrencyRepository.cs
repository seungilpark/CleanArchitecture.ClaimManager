using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Application.Interfaces.Repositories
{
    public interface ICurrencyRepository : IGenericRepositoryAsync<Currency>
    {
    }
}
