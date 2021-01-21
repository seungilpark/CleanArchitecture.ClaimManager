using CleanArchitecture.ClaimManager.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim
{
    public class ExpenseClaim : AuditableBaseEntity
    {
        public string Title { get; set; }
        public int Requester { get; set; }
        public int Approver { get; set; }
        public DateTime SubmitDate { get; set; }
        public DateTime ApprovalDate { get; set; }
        public DateTime ProcessedDate { get; set; }
        public decimal TotalAmount { get; set; }
        public ExpenseClaimStatus Status { get; set; } = ExpenseClaimStatus.Submitted;
        public string RequesterComments { get; set; }
        public string ApproverComments { get; set; }
        public string FinanceComments { get; set; }
        public ICollection<ExpenseClaimLineItem> ExpenseClaimLineItems { get; set; }
    }
}
