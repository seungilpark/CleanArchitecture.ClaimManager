using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanArchitecture.ClaimManager.Infrastructure.Persistence.Migrations
{
    public partial class addedexpenseclaimmodelsrelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.AddColumn<int>(
                name: "ExpenseCategoryId",
                table: "ExpenseClaimLineItems",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaimLineItems_CurrencyId",
                table: "ExpenseClaimLineItems",
                column: "CurrencyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaimLineItems_ExpenseCategoryId",
                table: "ExpenseClaimLineItems",
                column: "ExpenseCategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseClaimLineItems_ExpenseClaimId",
                table: "ExpenseClaimLineItems",
                column: "ExpenseClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaimLineItems_Currencies_CurrencyId",
                table: "ExpenseClaimLineItems",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaimLineItems_ExpenseCategories_ExpenseCategoryId",
                table: "ExpenseClaimLineItems",
                column: "ExpenseCategoryId",
                principalTable: "ExpenseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ExpenseClaimLineItems_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaimLineItems",
                column: "ExpenseClaimId",
                principalTable: "ExpenseClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaimLineItems_Currencies_CurrencyId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaimLineItems_ExpenseCategories_ExpenseCategoryId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.DropForeignKey(
                name: "FK_ExpenseClaimLineItems_ExpenseClaims_ExpenseClaimId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaimLineItems_CurrencyId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaimLineItems_ExpenseCategoryId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.DropIndex(
                name: "IX_ExpenseClaimLineItems_ExpenseClaimId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.DropColumn(
                name: "ExpenseCategoryId",
                table: "ExpenseClaimLineItems");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "ExpenseClaimLineItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
