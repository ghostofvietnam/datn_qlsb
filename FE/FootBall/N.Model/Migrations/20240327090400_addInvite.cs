using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace N.Model.Migrations
{
    /// <inheritdoc />
    public partial class addInvite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "BookingId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "FieldId",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Matched",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "UserMatch",
                table: "Team",
                newName: "UserId");

            migrationBuilder.AddColumn<string>(
                name: "Age",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Level",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Invite",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InviteTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Accepted = table.Column<bool>(type: "bit", nullable: true),
                    EnviteTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invite", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f4fc3fc-4a83-4d0f-8395-8bd9b039019c", "AQAAAAIAAYagAAAAEHjJGHK2vaYGzWygSdXEIHSkKXwLittGBr5hJYpf09kqbCA7ckUAByG849ojwv2iTA==", "5dcdc284-9c71-472d-90f6-3441069f0032" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invite");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Team");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Team",
                newName: "UserMatch");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Team",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<Guid>(
                name: "BookingId",
                table: "Team",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "Team",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FieldId",
                table: "Team",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Matched",
                table: "Team",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9492db13-6804-40ed-ba67-66fa110c34f6", "AQAAAAIAAYagAAAAEN/1jO2htaB5OuaPIgxI5MkOIcDxHpGQuUrTDpcipPnmY5dykk8eO7t5yliblFbS6Q==", "8abb7862-7c17-470d-ad41-1c820d95caaa" });
        }
    }
}
