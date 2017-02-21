using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalOrm.Migrations
{
    public partial class Upload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Product",
                newName: "ProdId");

            migrationBuilder.AddColumn<int>(
                name: "ProdId",
                table: "Updates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Updates_ProdId",
                table: "Updates",
                column: "ProdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Updates_Product_ProdId",
                table: "Updates",
                column: "ProdId",
                principalTable: "Product",
                principalColumn: "ProdId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Updates_Product_ProdId",
                table: "Updates");

            migrationBuilder.DropIndex(
                name: "IX_Updates_ProdId",
                table: "Updates");

            migrationBuilder.DropColumn(
                name: "ProdId",
                table: "Updates");

            migrationBuilder.RenameColumn(
                name: "ProdId",
                table: "Product",
                newName: "Id");
        }
    }
}
