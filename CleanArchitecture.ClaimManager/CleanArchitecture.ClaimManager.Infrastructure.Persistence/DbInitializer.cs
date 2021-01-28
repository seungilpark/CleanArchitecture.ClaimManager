using CleanArchitecture.ClaimManager.Domain.Entities.ExpenseClaim;
using CleanArchitecture.ClaimManager.Infrastructure.Persistence.Contexts;
using System;
using System.Linq;

namespace CleanArchitecture.ClaimManager.Infrastructure.Persistence
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.ExpenseClaims.Any())
            {
                return;   // DB has been seeded
            }
            var currencies = new Currency[]
            {
                new Currency { Name="Korean Won", Symbol="KRW" },
                new Currency { Name="Canadian Dollar", Symbol="CAD"},
                new Currency { Name="US Dollar", Symbol="USD"},
            };

            foreach (Currency c in currencies)
            {
                context.Currencies.Add(c);
            }
            context.SaveChanges();

            var categories = new ExpenseCategory[]
            {
                new ExpenseCategory { Code="AAA", Name="Type A"},
                new ExpenseCategory { Code="BBB", Name="Type B"},
                new ExpenseCategory { Code="CCC", Name="Type C"},
            };

            foreach (ExpenseCategory c in categories)
            {
                context.ExpenseCategories.Add(c);
            }
            context.SaveChanges();

            var items1 = new ExpenseClaimLineItem[]
            {
                new ExpenseClaimLineItem { CurrencyId=currencies[2].Id, ExpenseCategoryId=categories[1].Id, Amount=10.99M, Date=new DateTime(2021-01-01),  Description="This is a test item", Image="https://static.nike.com/a/images/w_1536,c_limit/9de44154-c8c3-4f77-b47e-d992b7b96379/image.jpg", Payee= "MazcoMac" },
                new ExpenseClaimLineItem { CurrencyId=currencies[2].Id, ExpenseCategoryId=categories[2].Id, Amount=110.99M, Date=new DateTime(2021-01-03), Description="This is another test item", Payee="Jason Huang", Image="https://media.glamour.com/photos/5d4d8173a8093800088d56f8/16:9/w_3440,h_1935,c_limit/Jackets%20Everyone%20Should%20Own%20River.jpg"},
                new ExpenseClaimLineItem { CurrencyId=currencies[2].Id, ExpenseCategoryId=categories[0].Id, Amount=210.99M, Date=new DateTime(2021-01-05), Description="This is a still yet another test item", Image="https://images2.minutemediacdn.com/image/upload/c_crop,h_1126,w_2000,x_0,y_181/f_auto,q_auto,w_1100/v1554932288/shape/mentalfloss/12531-istock-637790866.jpg", Payee="Carson Xu"},
            };

            var items2 = new ExpenseClaimLineItem[]
            {
                new ExpenseClaimLineItem { CurrencyId=currencies[2].Id, ExpenseCategoryId=categories[1].Id, Amount=12.99M, Date=new DateTime(2021-01-02),  Description="This is a test item", Image="https://static.toiimg.com/photo/msid-67586673/67586673.jpg?3918697", Payee= "MazcoMac" },
                new ExpenseClaimLineItem { CurrencyId=currencies[2].Id, ExpenseCategoryId=categories[2].Id, Amount=50.99M, Date=new DateTime(2021-01-05),  Description="This is another test item", Payee="Jason Huang", Image="https://c.files.bbci.co.uk/EB24/production/_112669106_66030514-b1c2-4533-9230-272b8368e25f.jpg"},
                new ExpenseClaimLineItem { CurrencyId=currencies[2].Id, ExpenseCategoryId=categories[0].Id, Amount=310.99M, Date=new DateTime(2021-01-07),  Description="This is a still yet another test item", Image="https://cdn.mos.cms.futurecdn.net/CxLvbQNp2Y4BQkTkpW5m7b.jpg", Payee="Carson Xu"},
            };

            foreach (ExpenseClaimLineItem i in items1)
            {
                context.ExpenseClaimLineItems.Add(i);
            }

            foreach (ExpenseClaimLineItem i in items2)
            {
                context.ExpenseClaimLineItems.Add(i);
            }
            //context.SaveChanges();

            var claims = new ExpenseClaim[]
            {
                new ExpenseClaim { ExpenseClaimLineItems=items1, Title="test claim title 1", Requester=1, Approver=1, SubmitDate= new DateTime(2021-01-24), RequesterComments="Test Comment 1", },
                new ExpenseClaim { ExpenseClaimLineItems=items2, Title="test claim title 2", Requester=2, Approver=2, SubmitDate= new DateTime(2021-01-20), RequesterComments="Test Comment 2"}
            };

            foreach (ExpenseClaim ec in claims)
            {
                context.ExpenseClaims.Add(ec);
            }
            context.SaveChanges();

        }
    }
}
