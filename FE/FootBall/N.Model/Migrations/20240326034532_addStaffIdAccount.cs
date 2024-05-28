using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N.Model.Migrations
{
    /// <inheritdoc />
    public partial class addStaffIdAccount : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "StaffId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp", "StaffId" },
                values: new object[] { "503658d8-73c9-47dc-a322-4574a6fddc16", "AQAAAAIAAYagAAAAEBtL3Ij/iOm73b/i7mnX00E4+G64zhycgXcReGpxWTcLXia7zOR1ZuHuFnwlhiSJhg==", "70e42cfe-b014-4e1d-a871-2aad4e8b24e7", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "522bceb8-ccd3-43b2-bd03-b0ebcfd309ec", "AQAAAAIAAYagAAAAEOXaF+jh7USvmNRbTacFi83Ca015Yh0k2bWSW3NCPBfa7KhDk/X7rooNqySERYZniQ==", "8777e27f-96c4-4c5d-bdea-deead385a798" });
        }
    }
}
