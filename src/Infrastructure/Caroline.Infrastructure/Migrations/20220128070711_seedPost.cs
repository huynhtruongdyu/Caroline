using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Caroline.Infrastructure.Migrations
{
    public partial class seedPost : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Content", "CreatedBy", "CreatedDate", "DeleteFlag", "Thumbnail", "Title", "UpdatedBy", "UpdatedDate" },
                values: new object[] { 1, "This is some content", null, new DateTime(2022, 1, 28, 7, 7, 11, 70, DateTimeKind.Utc).AddTicks(354), false, null, "Test 1", null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
