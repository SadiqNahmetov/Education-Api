using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class RemoveColumnThreeTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Sutudent");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Author");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(3150),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 920, DateTimeKind.Utc).AddTicks(1831));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(2940),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 920, DateTimeKind.Utc).AddTicks(1556));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 17, DateTimeKind.Local).AddTicks(9188),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 930, DateTimeKind.Local).AddTicks(3286));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 17, DateTimeKind.Local).AddTicks(8999),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 930, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 10, DateTimeKind.Utc).AddTicks(6734),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 919, DateTimeKind.Utc).AddTicks(3498));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 10, DateTimeKind.Utc).AddTicks(6462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 919, DateTimeKind.Utc).AddTicks(3275));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(9120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 921, DateTimeKind.Utc).AddTicks(1403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(8962),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 921, DateTimeKind.Utc).AddTicks(1153));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 16, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 928, DateTimeKind.Local).AddTicks(753));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 16, DateTimeKind.Local).AddTicks(3775),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 928, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(3038),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(9508));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(2829),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(9258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 12, DateTimeKind.Utc).AddTicks(4800),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 922, DateTimeKind.Utc).AddTicks(972));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 12, DateTimeKind.Utc).AddTicks(4597),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 922, DateTimeKind.Utc).AddTicks(617));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(1912),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(8107));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(1697),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(7857));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 920, DateTimeKind.Utc).AddTicks(1831),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(3150));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 920, DateTimeKind.Utc).AddTicks(1556),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(2940));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 930, DateTimeKind.Local).AddTicks(3286),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 17, DateTimeKind.Local).AddTicks(9188));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 930, DateTimeKind.Local).AddTicks(2994),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 17, DateTimeKind.Local).AddTicks(8999));

            migrationBuilder.AddColumn<byte>(
                name: "Image",
                table: "Sutudent",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 919, DateTimeKind.Utc).AddTicks(3498),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 10, DateTimeKind.Utc).AddTicks(6734));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 919, DateTimeKind.Utc).AddTicks(3275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 10, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 921, DateTimeKind.Utc).AddTicks(1403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(9120));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 921, DateTimeKind.Utc).AddTicks(1153),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 11, DateTimeKind.Utc).AddTicks(8962));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 928, DateTimeKind.Local).AddTicks(753),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 16, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 13, 39, 44, 928, DateTimeKind.Local).AddTicks(407),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 15, 18, 57, 16, DateTimeKind.Local).AddTicks(3775));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(9508),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(3038));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(9258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(2829));

            migrationBuilder.AddColumn<byte>(
                name: "Image",
                table: "Course",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 922, DateTimeKind.Utc).AddTicks(972),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 12, DateTimeKind.Utc).AddTicks(4800));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 922, DateTimeKind.Utc).AddTicks(617),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 12, DateTimeKind.Utc).AddTicks(4597));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(8107),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(1912));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 5, 31, 9, 39, 44, 927, DateTimeKind.Utc).AddTicks(7857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 5, 31, 11, 18, 57, 16, DateTimeKind.Utc).AddTicks(1697));

            migrationBuilder.AddColumn<byte>(
                name: "Image",
                table: "Author",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }
    }
}
