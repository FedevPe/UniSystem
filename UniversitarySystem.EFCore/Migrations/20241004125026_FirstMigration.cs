using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversitarySystem.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BloodTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BloodType = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BloodTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailsTypeEntity",
                columns: table => new
                {
                    IdDetailType = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailTypeDescription = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailsTypeEntity", x => x.IdDetailType);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    IdStudent = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DNI = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CUIL = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    NumberPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateRegistry = table.Column<DateOnly>(type: "date", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "TypeCareers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeCareers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Details",
                columns: table => new
                {
                    IdDetail = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    DetailTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details", x => x.IdDetail);
                    table.ForeignKey(
                        name: "FK_Details_DetailsTypeEntity_DetailTypeId",
                        column: x => x.DetailTypeId,
                        principalTable: "DetailsTypeEntity",
                        principalColumn: "IdDetailType",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Psychophysicals",
                columns: table => new
                {
                    IdPsychophysical = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdditionalComments = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    BloodTypeId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Psychophysicals", x => x.IdPsychophysical);
                    table.ForeignKey(
                        name: "FK_Psychophysicals_BloodTypes_BloodTypeId",
                        column: x => x.BloodTypeId,
                        principalTable: "BloodTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Psychophysicals_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    IdTittle = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecondaryDegree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HighSchool = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EgressDate = table.Column<DateOnly>(type: "date", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.IdTittle);
                    table.ForeignKey(
                        name: "FK_Title_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeCareers",
                columns: table => new
                {
                    IdCollegeCareer = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CollegeCareer = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TypeCareersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeCareers", x => x.IdCollegeCareer);
                    table.ForeignKey(
                        name: "FK_CollegeCareers_TypeCareers_TypeCareersId",
                        column: x => x.TypeCareersId,
                        principalTable: "TypeCareers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetailAddress",
                columns: table => new
                {
                    IdAddress = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    StudentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailAddress", x => x.IdAddress);
                    table.ForeignKey(
                        name: "FK_DetailAddress_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DetailAddress_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Details.Psychophysicals",
                columns: table => new
                {
                    PsychophysicalId = table.Column<int>(type: "int", nullable: false),
                    DetailId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Details.Psychophysicals", x => new { x.DetailId, x.PsychophysicalId });
                    table.ForeignKey(
                        name: "FK_Details.Psychophysicals_Details_DetailId",
                        column: x => x.DetailId,
                        principalTable: "Details",
                        principalColumn: "IdDetail",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Details.Psychophysicals_Psychophysicals_PsychophysicalId",
                        column: x => x.PsychophysicalId,
                        principalTable: "Psychophysicals",
                        principalColumn: "IdPsychophysical",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CollegeCareers.Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CollegeCareerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollegeCareers.Students", x => new { x.StudentId, x.CollegeCareerId });
                    table.ForeignKey(
                        name: "FK_CollegeCareers.Students_CollegeCareers_CollegeCareerId",
                        column: x => x.CollegeCareerId,
                        principalTable: "CollegeCareers",
                        principalColumn: "IdCollegeCareer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CollegeCareers.Students_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceId",
                table: "Cities",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeCareers_TypeCareersId",
                table: "CollegeCareers",
                column: "TypeCareersId");

            migrationBuilder.CreateIndex(
                name: "IX_CollegeCareers.Students_CollegeCareerId",
                table: "CollegeCareers.Students",
                column: "CollegeCareerId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailAddress_CityId",
                table: "DetailAddress",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailAddress_StudentId",
                table: "DetailAddress",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Details_DetailTypeId",
                table: "Details",
                column: "DetailTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Details.Psychophysicals_PsychophysicalId",
                table: "Details.Psychophysicals",
                column: "PsychophysicalId");

            migrationBuilder.CreateIndex(
                name: "IX_Psychophysicals_BloodTypeId",
                table: "Psychophysicals",
                column: "BloodTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Psychophysicals_StudentId",
                table: "Psychophysicals",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Title_StudentId",
                table: "Title",
                column: "StudentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollegeCareers.Students");

            migrationBuilder.DropTable(
                name: "DetailAddress");

            migrationBuilder.DropTable(
                name: "Details.Psychophysicals");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "CollegeCareers");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Details");

            migrationBuilder.DropTable(
                name: "Psychophysicals");

            migrationBuilder.DropTable(
                name: "TypeCareers");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "DetailsTypeEntity");

            migrationBuilder.DropTable(
                name: "BloodTypes");

            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
