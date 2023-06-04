using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class ChangeMessagedefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 387, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(9935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 387, DateTimeKind.Utc).AddTicks(4957));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 400, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 400, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 386, DateTimeKind.Utc).AddTicks(7076));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(2932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 386, DateTimeKind.Utc).AddTicks(6763));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 401, DateTimeKind.Local).AddTicks(1243));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 401, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 388, DateTimeKind.Utc).AddTicks(4644));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 388, DateTimeKind.Utc).AddTicks(4352));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(7003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 397, DateTimeKind.Utc).AddTicks(2892));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 397, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(8272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 402, DateTimeKind.Utc).AddTicks(3203));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contact",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(7995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 402, DateTimeKind.Utc).AddTicks(2951));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 389, DateTimeKind.Utc).AddTicks(9412));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 389, DateTimeKind.Utc).AddTicks(9097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 396, DateTimeKind.Utc).AddTicks(2566));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 396, DateTimeKind.Utc).AddTicks(2337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(1664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(1405));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 387, DateTimeKind.Utc).AddTicks(5197),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 387, DateTimeKind.Utc).AddTicks(4957),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 400, DateTimeKind.Local).AddTicks(426),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 400, DateTimeKind.Local).AddTicks(38),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 386, DateTimeKind.Utc).AddTicks(7076),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 386, DateTimeKind.Utc).AddTicks(6763),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 401, DateTimeKind.Local).AddTicks(1243),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 401, DateTimeKind.Local).AddTicks(968),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 388, DateTimeKind.Utc).AddTicks(4644),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 388, DateTimeKind.Utc).AddTicks(4352),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(3712),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(3541),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 397, DateTimeKind.Utc).AddTicks(2892),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 397, DateTimeKind.Utc).AddTicks(2732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 402, DateTimeKind.Utc).AddTicks(3203),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.AlterColumn<string>(
                name: "Message",
                table: "Contact",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 402, DateTimeKind.Utc).AddTicks(2951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 389, DateTimeKind.Utc).AddTicks(9412),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 389, DateTimeKind.Utc).AddTicks(9097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 396, DateTimeKind.Utc).AddTicks(2566),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 9, 54, 44, 396, DateTimeKind.Utc).AddTicks(2337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(1664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 54, 44, 397, DateTimeKind.Local).AddTicks(1405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4212));
        }
    }
}
