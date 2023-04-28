using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class deletecolumnslidertable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Slider");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 13, 29, 36, 608, DateTimeKind.Utc).AddTicks(112),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 26, 13, 9, 7, 25, DateTimeKind.Utc).AddTicks(4210));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 4, 26, 13, 9, 7, 25, DateTimeKind.Utc).AddTicks(4210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 4, 26, 13, 29, 36, 608, DateTimeKind.Utc).AddTicks(112));

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Slider",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
