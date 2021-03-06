using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperMarketApi.Migrations
{
    public partial class masoodfriday110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "AutoOrder");

            migrationBuilder.DropTable(
                name: "KOT");

            migrationBuilder.DropTable(
                name: "StockUpdate");

            migrationBuilder.DropTable(
                name: "StockContainer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutoOrder",
                columns: table => new
                {
                    AutoOrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    IsIgnorePendOrd = table.Column<bool>(nullable: true),
                    OrderStoreId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoOrder", x => x.AutoOrderId);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Stores_OrderStoreId",
                        column: x => x.OrderStoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AutoOrder_Contacts_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KOT",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    Instruction = table.Column<string>(nullable: true),
                    KOTGroupId = table.Column<int>(nullable: true),
                    KOTNo = table.Column<string>(nullable: true),
                    KOTStatusId = table.Column<int>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    StoreId = table.Column<int>(nullable: true),
                    Updated = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KOT", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KOT_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KOT_KOTGroups_KOTGroupId",
                        column: x => x.KOTGroupId,
                        principalTable: "KOTGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_KOT_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KOT_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockContainer",
                columns: table => new
                {
                    StockContainerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyId = table.Column<int>(nullable: false),
                    ContainerWight = table.Column<double>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsCompanyLevel = table.Column<bool>(nullable: false),
                    StockContainerName = table.Column<string>(nullable: true),
                    StoreId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockContainer", x => x.StockContainerId);
                    table.ForeignKey(
                        name: "FK_StockContainer_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockContainer_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockContainer_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockUpdate",
                columns: table => new
                {
                    StockUpdateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Actions = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    ContainerCount = table.Column<double>(nullable: true),
                    ContainerWight = table.Column<double>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    GrossQty = table.Column<double>(nullable: true),
                    GrossQtyText = table.Column<string>(nullable: true),
                    IsManual = table.Column<bool>(nullable: true),
                    OldQty = table.Column<double>(nullable: false),
                    OldQtyAct = table.Column<double>(nullable: false),
                    StockBatchId = table.Column<int>(nullable: false),
                    StockContainerId = table.Column<int>(nullable: true),
                    StockUpdDate = table.Column<DateTime>(type: "Date", nullable: true),
                    StockUpdDateTime = table.Column<DateTime>(nullable: true),
                    UpdatedQty = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockUpdate", x => x.StockUpdateId);
                    table.ForeignKey(
                        name: "FK_StockUpdate_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockUpdate_StockBatches_StockBatchId",
                        column: x => x.StockBatchId,
                        principalTable: "StockBatches",
                        principalColumn: "StockBatchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockUpdate_StockContainer_StockContainerId",
                        column: x => x.StockContainerId,
                        principalTable: "StockContainer",
                        principalColumn: "StockContainerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Amount = table.Column<double>(nullable: true),
                    AutoOrderId = table.Column<int>(nullable: true),
                    CancelledQuantity = table.Column<double>(nullable: true),
                    CategoryId = table.Column<int>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    ComplementryQty = table.Column<float>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    CurrentStock = table.Column<double>(nullable: true),
                    DiscAmount = table.Column<double>(nullable: false),
                    DiscPercent = table.Column<double>(nullable: false),
                    DispatchLaterQuantity = table.Column<double>(nullable: true),
                    DispatchedQuantity = table.Column<double>(nullable: true),
                    Extra = table.Column<double>(nullable: true),
                    ItemDiscount = table.Column<double>(nullable: true),
                    KOTId = table.Column<int>(nullable: true),
                    KitchenUserId = table.Column<int>(nullable: true),
                    Message = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OldStock = table.Column<double>(nullable: true),
                    OptionJson = table.Column<string>(nullable: true),
                    OrderDiscount = table.Column<double>(nullable: true),
                    OrderId = table.Column<int>(nullable: true),
                    OrderItemId = table.Column<int>(nullable: false),
                    OrderLevel = table.Column<double>(nullable: true),
                    OrderQuantity = table.Column<double>(nullable: true),
                    PendingQty = table.Column<double>(nullable: true),
                    Price = table.Column<double>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    ReceiveLaterQuantity = table.Column<double>(nullable: true),
                    ReceivedQuantity = table.Column<double>(nullable: true),
                    ReturnedQuantity = table.Column<double>(nullable: true),
                    Status = table.Column<int>(nullable: true),
                    StatusId = table.Column<int>(nullable: false),
                    StockUpdateId = table.Column<int>(nullable: true),
                    Tax1 = table.Column<double>(nullable: true),
                    Tax2 = table.Column<double>(nullable: true),
                    Tax3 = table.Column<double>(nullable: true),
                    Tax4 = table.Column<double>(nullable: true),
                    TaxAmount = table.Column<double>(nullable: true),
                    TaxItemDiscount = table.Column<double>(nullable: true),
                    TaxOrderDiscount = table.Column<double>(nullable: true),
                    TotalAmount = table.Column<double>(nullable: true),
                    Updated = table.Column<bool>(nullable: false),
                    VarianceReasonDesc = table.Column<string>(nullable: true),
                    VarianceReasonStr = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_AutoOrder_AutoOrderId",
                        column: x => x.AutoOrderId,
                        principalTable: "AutoOrder",
                        principalColumn: "AutoOrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Contacts_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "Contacts",
                        principalColumn: "ContactId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_KOT_KOTId",
                        column: x => x.KOTId,
                        principalTable: "KOT",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Users_KitchenUserId",
                        column: x => x.KitchenUserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_StockUpdate_StockUpdateId",
                        column: x => x.StockUpdateId,
                        principalTable: "StockUpdate",
                        principalColumn: "StockUpdateId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItems_EnumVal_VarianceReasonStr",
                        column: x => x.VarianceReasonStr,
                        principalTable: "EnumVal",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_CategoryId",
                table: "AutoOrder",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_CompanyId",
                table: "AutoOrder",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_CreatedBy",
                table: "AutoOrder",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_OrderStoreId",
                table: "AutoOrder",
                column: "OrderStoreId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_ProductId",
                table: "AutoOrder",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AutoOrder_SupplierId",
                table: "AutoOrder",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_CompanyId",
                table: "KOT",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_KOTGroupId",
                table: "KOT",
                column: "KOTGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_OrderId",
                table: "KOT",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_KOT_StoreId",
                table: "KOT",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_AutoOrderId",
                table: "OrderItems",
                column: "AutoOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CategoryId",
                table: "OrderItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CompanyId",
                table: "OrderItems",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CreatedBy",
                table: "OrderItems",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_KOTId",
                table: "OrderItems",
                column: "KOTId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_KitchenUserId",
                table: "OrderItems",
                column: "KitchenUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_StockUpdateId",
                table: "OrderItems",
                column: "StockUpdateId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_VarianceReasonStr",
                table: "OrderItems",
                column: "VarianceReasonStr");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainer_CompanyId",
                table: "StockContainer",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainer_CreatedBy",
                table: "StockContainer",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_StockContainer_StoreId",
                table: "StockContainer",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUpdate_CompanyId",
                table: "StockUpdate",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUpdate_StockBatchId",
                table: "StockUpdate",
                column: "StockBatchId");

            migrationBuilder.CreateIndex(
                name: "IX_StockUpdate_StockContainerId",
                table: "StockUpdate",
                column: "StockContainerId");
        }
    }
}
