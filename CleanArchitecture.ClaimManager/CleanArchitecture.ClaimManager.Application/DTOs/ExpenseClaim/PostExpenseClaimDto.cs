using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.ClaimManager.Application.DTOs.ExpenseClaim
{
    public class PostExpenseClaimDto
    {
        public string Title { get; set; }
        public int Requester { get; set; }
        public int Approver { get; set; }
        public DateTime SubmitDate { get; set; }
        public string RequesterComments { get; set; }
    }
}
