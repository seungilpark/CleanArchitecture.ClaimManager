using CleanArchitecture.ClaimManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim
{
    public class ExpenseClaimLineItem : BaseEntity
    {
        public int ExpenseCategoryId { get; set;  }
        public string Payee { get; set;  }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public int CurrencyId { get; set; }
        public decimal USDAmount { get; set; }
        public string Image { get; set; }
        public ExpenseClaim ExpenseClaim { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public Currency Currency { get; set; }
    }
}
