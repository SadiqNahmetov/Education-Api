using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class ChangeHassMaxLengthdefault : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(202));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(9935));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 736, DateTimeKind.Local).AddTicks(1484),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 736, DateTimeKind.Local).AddTicks(1210),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9424));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(3164));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(2932));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Service",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9241));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8414));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8163));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8980));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(7739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(7003));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(6534));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(8272));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(7995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(5246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6447));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(4777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6227));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(6839));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4719));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "About",
                type: "nvarchar(800)",
                maxLength: 800,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4212));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(202),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(9935),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 736, DateTimeKind.Local).AddTicks(1484));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Sutudent",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 409, DateTimeKind.Local).AddTicks(9424),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 736, DateTimeKind.Local).AddTicks(1210));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(3164),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 397, DateTimeKind.Utc).AddTicks(2932),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9463),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Service",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 410, DateTimeKind.Local).AddTicks(9241),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8414),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 398, DateTimeKind.Utc).AddTicks(8163),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8980),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(8462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(7003),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Course",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 406, DateTimeKind.Utc).AddTicks(6534),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(8272),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 411, DateTimeKind.Utc).AddTicks(7995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6447),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 399, DateTimeKind.Utc).AddTicks(6227),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(7347),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 24, 33, 404, DateTimeKind.Utc).AddTicks(6839),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4719),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "About",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(800)",
                oldMaxLength: 800);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 24, 33, 406, DateTimeKind.Local).AddTicks(4212),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5185));
        }
    }
}
