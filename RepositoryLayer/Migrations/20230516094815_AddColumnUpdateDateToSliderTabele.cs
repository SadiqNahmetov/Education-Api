using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class AddColumnUpdateDateToSliderTabele : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 192, DateTimeKind.Utc).AddTicks(4171),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 27, 12, 34, 50, 251, DateTimeKind.Utc).AddTicks(9981));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 192, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 191, DateTimeKind.Utc).AddTicks(4602),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 27, 12, 34, 50, 251, DateTimeKind.Utc).AddTicks(5388));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 191, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.CreateTable(
                name: "Header",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 193, DateTimeKind.Utc).AddTicks(312)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 193, DateTimeKind.Utc).AddTicks(506))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Header", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Header");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "UpdateDate",
                table: "Slider");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 27, 12, 34, 50, 251, DateTimeKind.Utc).AddTicks(9981),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 192, DateTimeKind.Utc).AddTicks(4171));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 27, 12, 34, 50, 251, DateTimeKind.Utc).AddTicks(5388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 16, 9, 48, 15, 191, DateTimeKind.Utc).AddTicks(4602));
        }
    }
}
