using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateContactTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 207, DateTimeKind.Utc).AddTicks(1387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 652, DateTimeKind.Utc).AddTicks(9391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 207, DateTimeKind.Utc).AddTicks(777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 652, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 220, DateTimeKind.Local).AddTicks(2502),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 668, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 220, DateTimeKind.Local).AddTicks(1962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 668, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 206, DateTimeKind.Utc).AddTicks(240),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 651, DateTimeKind.Utc).AddTicks(1536));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 205, DateTimeKind.Utc).AddTicks(9787),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 651, DateTimeKind.Utc).AddTicks(1125));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 221, DateTimeKind.Local).AddTicks(7758),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 670, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 221, DateTimeKind.Local).AddTicks(7473),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 670, DateTimeKind.Local).AddTicks(7514));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 208, DateTimeKind.Utc).AddTicks(3640),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 654, DateTimeKind.Utc).AddTicks(7633));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 208, DateTimeKind.Utc).AddTicks(3322),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 654, DateTimeKind.Utc).AddTicks(7105));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 217, DateTimeKind.Local).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 665, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 217, DateTimeKind.Local).AddTicks(4151),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 665, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 217, DateTimeKind.Utc).AddTicks(2955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(9099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 217, DateTimeKind.Utc).AddTicks(2635),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(8663));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 209, DateTimeKind.Utc).AddTicks(5955),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 656, DateTimeKind.Utc).AddTicks(3376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 209, DateTimeKind.Utc).AddTicks(5535),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 656, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 217, DateTimeKind.Utc).AddTicks(368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(6612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 216, DateTimeKind.Utc).AddTicks(9952),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(6093));

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 222, DateTimeKind.Utc).AddTicks(8858)),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 222, DateTimeKind.Utc).AddTicks(9182))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 652, DateTimeKind.Utc).AddTicks(9391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 207, DateTimeKind.Utc).AddTicks(1387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 652, DateTimeKind.Utc).AddTicks(8663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 207, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 668, DateTimeKind.Local).AddTicks(7754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 220, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 668, DateTimeKind.Local).AddTicks(7280),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 220, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 651, DateTimeKind.Utc).AddTicks(1536),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 206, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 651, DateTimeKind.Utc).AddTicks(1125),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 205, DateTimeKind.Utc).AddTicks(9787));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 670, DateTimeKind.Local).AddTicks(8173),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 221, DateTimeKind.Local).AddTicks(7758));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 670, DateTimeKind.Local).AddTicks(7514),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 221, DateTimeKind.Local).AddTicks(7473));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 654, DateTimeKind.Utc).AddTicks(7633),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 208, DateTimeKind.Utc).AddTicks(3640));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 654, DateTimeKind.Utc).AddTicks(7105),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 208, DateTimeKind.Utc).AddTicks(3322));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 665, DateTimeKind.Local).AddTicks(898),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 217, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 38, 4, 665, DateTimeKind.Local).AddTicks(476),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 17, 21, 29, 217, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(9099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 217, DateTimeKind.Utc).AddTicks(2955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(8663),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 217, DateTimeKind.Utc).AddTicks(2635));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 656, DateTimeKind.Utc).AddTicks(3376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 209, DateTimeKind.Utc).AddTicks(5955));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 656, DateTimeKind.Utc).AddTicks(3017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 209, DateTimeKind.Utc).AddTicks(5535));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(6612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 217, DateTimeKind.Utc).AddTicks(368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 38, 4, 664, DateTimeKind.Utc).AddTicks(6093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 2, 13, 21, 29, 216, DateTimeKind.Utc).AddTicks(9952));
        }
    }
}
