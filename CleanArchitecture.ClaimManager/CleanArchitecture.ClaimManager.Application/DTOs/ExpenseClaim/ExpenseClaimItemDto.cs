using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Application.DTOs.ExpenseClaim
{
    class PostExpenseClaimItemDto
    {
        public string Title { get; set; }
        public int Requester { get; set; }
        public int Approver { get; set; }
        public DateTime SubmitDate { get; set; }
        public string RequesterComments { get; set; }
        public List<ExpenseClaimLineItem> ExpenseClaimLineItems { get; set; }
    }
}
