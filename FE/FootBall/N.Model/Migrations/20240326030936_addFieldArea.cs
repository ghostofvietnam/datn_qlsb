using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N.Model.Migrations
{
    /// <inheritdoc />
    public partial class addFieldArea : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "FieldAreaId",
                table: "Field",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FieldArea",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FieldArea", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "522bceb8-ccd3-43b2-bd03-b0ebcfd309ec", "AQAAAAIAAYagAAAAEOXaF+jh7USvmNRbTacFi83Ca015Yh0k2bWSW3NCPBfa7KhDk/X7rooNqySERYZniQ==", "8777e27f-96c4-4c5d-bdea-deead385a798" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FieldArea");

            migrationBuilder.DropColumn(
                name: "FieldAreaId",
                table: "Field");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e42f3642-5079-4705-94f4-2f304a7d0cef", "AQAAAAIAAYagAAAAENaWxKK5LAHH4FHU9gwGuYVF8hukGwQbZkb1uvm7L4wZIpxJreC+UoTPoQkQiGn/sw==", "ef45a7c6-5fcc-452c-99f3-24c13c55e2a2" });
        }
    }
}
