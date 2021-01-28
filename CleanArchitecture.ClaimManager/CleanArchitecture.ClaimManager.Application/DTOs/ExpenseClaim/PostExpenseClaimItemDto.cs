using CleanArchitecture.ClaimManager.Application.Interfaces.Repositories;
using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.ClaimManager.Application.DTOs.ExpenseClaim
{
    public class PostExpenseClaimItemDto
    {
        public string Payee { get; set;  }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public decimal USDAmount { get; set; }
        public string Image { get; set; }
        public int CurrencyId { get; set; }
        public int ExpenseCategoryId { get; set;  }
    }
}
