using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EComDAL.Migrations
{
    /// <inheritdoc />
    public partial class updatemodel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_SubCategories_SubCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Countries_Country_Id",
                table: "Provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Provinces_ProvinceID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Categories_SubCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Full_Name",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TranscationId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Created_Date",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "SubCategoryId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Updated_Date",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "Created_By",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "Updated_By",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "ProvinceID",
                table: "Users",
                newName: "ProvinceId");

            migrationBuilder.RenameColumn(
                name: "User_Name",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Users",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Profile_Pic",
                table: "Users",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "Users",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Users",
                newName: "CreatedDate");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProvinceID",
                table: "Users",
                newName: "IX_Users_ProvinceId");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "SubCategories",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "SubCategories",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Roles",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Role_Name",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Roles",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Provinces",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Province_Name",
                table: "Provinces",
                newName: "ProvinceName");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Provinces",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Country_Id",
                table: "Provinces",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Provinces_Country_Id",
                table: "Provinces",
                newName: "IX_Provinces_CountryId");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Products",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Stock_Quantity",
                table: "Products",
                newName: "StockQuantity");

            migrationBuilder.RenameColumn(
                name: "Product_Name",
                table: "Products",
                newName: "ProductName");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Products",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Products",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Payments",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Payment_Date",
                table: "Payments",
                newName: "PaymentDate");

            migrationBuilder.RenameColumn(
                name: "Pay_Status",
                table: "Payments",
                newName: "PayStatus");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Payments",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Orders",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Total_Amount",
                table: "Orders",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "orderStatus");

            migrationBuilder.RenameColumn(
                name: "Shipping_Fee",
                table: "Orders",
                newName: "ShippingFee");

            migrationBuilder.RenameColumn(
                name: "Shipping_Address",
                table: "Orders",
                newName: "ShippingAddress");

            migrationBuilder.RenameColumn(
                name: "Order_Date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Orders",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Billing_Address",
                table: "Orders",
                newName: "BillingAddress");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "OrderItems",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "OrderItems",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Total_Price",
                table: "OrderItems",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "OrderItems",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Currencies",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Currencies",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Countries",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Countries",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Country_Name",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "Category_Name",
                table: "Categories",
                newName: "CategoryName");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "Carts",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Total_Amount",
                table: "Carts",
                newName: "TotalAmount");

            migrationBuilder.RenameColumn(
                name: "Discount_Amount",
                table: "Carts",
                newName: "DiscountAmount");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "Carts",
                newName: "CreatedDate");

            migrationBuilder.RenameColumn(
                name: "Updated_Date",
                table: "CartItems",
                newName: "UpdatedDate");

            migrationBuilder.RenameColumn(
                name: "Unit_Price",
                table: "CartItems",
                newName: "UnitPrice");

            migrationBuilder.RenameColumn(
                name: "Total_Price",
                table: "CartItems",
                newName: "TotalPrice");

            migrationBuilder.RenameColumn(
                name: "Created_Date",
                table: "CartItems",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "GenderStatus",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProfilePic",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "SubCategories",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Permissions",
                table: "Roles",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Provinces",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Products",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Payments",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Payments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TransactionId",
                table: "Payments",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "OrderItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Currencies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Countries",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Carts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "CartItems",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UpdatedBy",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Countries_CountryId",
                table: "Provinces",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Provinces_ProvinceId",
                table: "Users",
                column: "ProvinceId",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Provinces_Countries_CountryId",
                table: "Provinces");

            migrationBuilder.DropForeignKey(
                name: "FK_SubCategories_Categories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Provinces_ProvinceId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_SubCategories_CategoryId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "GenderStatus",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "ProfilePic",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "SubCategories");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Provinces");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "TransactionId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Currencies");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "CartItems");

            migrationBuilder.DropColumn(
                name: "UpdatedBy",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "ProvinceId",
                table: "Users",
                newName: "ProvinceID");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "User_Name");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Users",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Users",
                newName: "Profile_Pic");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Users",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Users",
                newName: "Created_Date");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ProvinceId",
                table: "Users",
                newName: "IX_Users_ProvinceID");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "SubCategories",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "SubCategories",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Roles",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "Role_Name");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Roles",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Provinces",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "ProvinceName",
                table: "Provinces",
                newName: "Province_Name");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Provinces",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Provinces",
                newName: "Country_Id");

            migrationBuilder.RenameIndex(
                name: "IX_Provinces_CountryId",
                table: "Provinces",
                newName: "IX_Provinces_Country_Id");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Products",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Products",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "StockQuantity",
                table: "Products",
                newName: "Stock_Quantity");

            migrationBuilder.RenameColumn(
                name: "ProductName",
                table: "Products",
                newName: "Product_Name");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Products",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Payments",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "Payments",
                newName: "Payment_Date");

            migrationBuilder.RenameColumn(
                name: "PayStatus",
                table: "Payments",
                newName: "Pay_Status");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Payments",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "orderStatus",
                table: "Orders",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Orders",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Orders",
                newName: "Total_Amount");

            migrationBuilder.RenameColumn(
                name: "ShippingFee",
                table: "Orders",
                newName: "Shipping_Fee");

            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "Orders",
                newName: "Shipping_Address");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "Order_Date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Orders",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "BillingAddress",
                table: "Orders",
                newName: "Billing_Address");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "OrderItems",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "OrderItems",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "OrderItems",
                newName: "Total_Price");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "OrderItems",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Currencies",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Currencies",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Countries",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Countries",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "Country_Name");

            migrationBuilder.RenameColumn(
                name: "CategoryName",
                table: "Categories",
                newName: "Category_Name");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "Carts",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "TotalAmount",
                table: "Carts",
                newName: "Total_Amount");

            migrationBuilder.RenameColumn(
                name: "DiscountAmount",
                table: "Carts",
                newName: "Discount_Amount");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Carts",
                newName: "Created_Date");

            migrationBuilder.RenameColumn(
                name: "UpdatedDate",
                table: "CartItems",
                newName: "Updated_Date");

            migrationBuilder.RenameColumn(
                name: "UnitPrice",
                table: "CartItems",
                newName: "Unit_Price");

            migrationBuilder.RenameColumn(
                name: "TotalPrice",
                table: "CartItems",
                newName: "Total_Price");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "CartItems",
                newName: "Created_Date");

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Full_Name",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Gender",
                table: "Users",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "SubCategories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "SubCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Permissions",
                table: "Roles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Roles",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Provinces",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Provinces",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Remarks",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TranscationId",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Currencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Currencies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Countries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created_Date",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SubCategoryId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated_Date",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeletedBy",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Created_By",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Updated_By",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_SubCategoryId",
                table: "Categories",
                column: "SubCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_SubCategories_SubCategoryId",
                table: "Categories",
                column: "SubCategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Provinces_Countries_Country_Id",
                table: "Provinces",
                column: "Country_Id",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Provinces_ProvinceID",
                table: "Users",
                column: "ProvinceID",
                principalTable: "Provinces",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
