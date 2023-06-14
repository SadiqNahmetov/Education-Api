using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class ChangeIsDeletedColumnValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sutudent");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3683));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Title",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3392));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Title",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Slider",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5458));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Slider",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Service",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3773));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Header",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3468));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "CourseAuthor",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "CourseAuthor",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6847));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Course",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6621));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Course",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(808));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(526));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(5246));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Banner",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(4777));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Banner",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Author",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "Author",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5491));

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "About",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5185));

            migrationBuilder.AddColumn<bool>(
                name: "isDeleted",
                table: "About",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CourseStudent",
                columns: table => new
                {
                    CoursesId = table.Column<int>(type: "int", nullable: false),
                    StudentsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseStudent", x => new { x.CoursesId, x.StudentsId });
                    table.ForeignKey(
                        name: "FK_CourseStudent_Course_CoursesId",
                        column: x => x.CoursesId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseStudent_Student_StudentsId",
                        column: x => x.StudentsId,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseStudent_StudentsId",
                table: "CourseStudent",
                column: "StudentsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseStudent");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Title");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Slider");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Header");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "CourseAuthor");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Contact");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Banner");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "Author");

            migrationBuilder.DropColumn(
                name: "isDeleted",
                table: "About");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3683),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Title",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Title",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 722, DateTimeKind.Utc).AddTicks(3392),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5756),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Slider",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Slider",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 721, DateTimeKind.Utc).AddTicks(5458),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1275),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Service",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Service",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 737, DateTimeKind.Local).AddTicks(1033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3773),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Header",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Header",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 723, DateTimeKind.Utc).AddTicks(3468),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(8013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "CourseAuthor",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "CourseAuthor",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(7739),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6847),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Course",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Course",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 733, DateTimeKind.Utc).AddTicks(6621),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Contact",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Contact",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 738, DateTimeKind.Utc).AddTicks(526),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(5246),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Banner",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Banner",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 724, DateTimeKind.Utc).AddTicks(4777),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4964),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "Author",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Author",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 13, 27, 42, 732, DateTimeKind.Utc).AddTicks(4584),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "SoftDeleted",
                table: "About",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "About",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 733, DateTimeKind.Local).AddTicks(5185),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.CreateTable(
                name: "Sutudent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 736, DateTimeKind.Local).AddTicks(1210)),
                    FullName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Info = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsGraduated = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SoftDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2023, 6, 3, 17, 27, 42, 736, DateTimeKind.Local).AddTicks(1484))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sutudent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sutudent_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sutudent_CourseId",
                table: "Sutudent",
                column: "CourseId");
        }
    }
}
