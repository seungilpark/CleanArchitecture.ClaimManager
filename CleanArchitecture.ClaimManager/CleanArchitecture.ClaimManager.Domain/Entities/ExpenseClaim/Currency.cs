using CleanArchitecture.ClaimManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim
{
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public ExpenseClaimLineItem ExpenseClaimLineItem { get; set; }
    }
}
