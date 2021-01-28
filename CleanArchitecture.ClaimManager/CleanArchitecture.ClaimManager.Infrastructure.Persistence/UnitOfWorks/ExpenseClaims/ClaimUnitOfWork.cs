using CleanArchitecture.ClaimManager.Application.Interfaces;
using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Contexts;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Repositories;

namespace CleanArchitecture.ClaimManager.Infrastructure.UnitOfWorks.ExpenseClaims
{
    public class ClaimUnitOfWork : IClaimUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IExpenseClaimRepositoryAsync ClaimRepository { get; set; }
        public IClaimCategoryRepository CategoryRepository { get; set; }
        public ICurrencyRepository CurrencyRepository { get; set; }
        public IClaimItemRepository ClaimItemRepository { get; set; }


        //public IExpenseClaimRepositoryAsync ClaimRepository { get; set; }
        public ClaimUnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ClaimRepository = new ExpenseClaimRepositoryAsync(_context);
            CategoryRepository = new CategoryRepository(_context);
            CurrencyRepository = new CurrencyRepository(_context);
            ClaimItemRepository = new ClaimItemRepository(_context);
        }
        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
