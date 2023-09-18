using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_App.Migrations
{
    public partial class addTab2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Patients",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Nurses",
                newName: "NurseID");

            migrationBuilder.CreateTable(
                name: "Chronics",
                columns: table => new
                {
                    ChronicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChronicName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chronics", x => x.ChronicID);
                });

            migrationBuilder.CreateTable(
                name: "Contracts",
                columns: table => new
                {
                    ContractID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContractDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WoundDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NurseID = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    SuburbID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contracts", x => x.ContractID);
                    table.ForeignKey(
                        name: "FK_Contracts_Nurses_NurseID",
                        column: x => x.NurseID,
                        principalTable: "Nurses",
                        principalColumn: "NurseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contracts_Suburbs_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreferedSuburbs",
                columns: table => new
                {
                    PreferedSuburbID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NurseID = table.Column<int>(type: "int", nullable: true),
                    NurserID = table.Column<int>(type: "int", nullable: false),
                    SuburbID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferedSuburbs", x => x.PreferedSuburbID);
                    table.ForeignKey(
                        name: "FK_PreferedSuburbs_Nurses_NurseID",
                        column: x => x.NurseID,
                        principalTable: "Nurses",
                        principalColumn: "NurseID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PreferedSuburbs_Suburbs_SuburbID",
                        column: x => x.SuburbID,
                        principalTable: "Suburbs",
                        principalColumn: "SuburbID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    VisitID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VistDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApproxArriTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArriveTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WoundCondition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NurseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.VisitID);
                    table.ForeignKey(
                        name: "FK_Visits_Nurses_NurseID",
                        column: x => x.NurseID,
                        principalTable: "Nurses",
                        principalColumn: "NurseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientChronics",
                columns: table => new
                {
                    PatientChronicID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    ChronicID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientChronics", x => x.PatientChronicID);
                    table.ForeignKey(
                        name: "FK_PatientChronics_Chronics_ChronicID",
                        column: x => x.ChronicID,
                        principalTable: "Chronics",
                        principalColumn: "ChronicID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientChronics_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_NurseID",
                table: "Contracts",
                column: "NurseID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_PatientID",
                table: "Contracts",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_SuburbID",
                table: "Contracts",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientChronics_ChronicID",
                table: "PatientChronics",
                column: "ChronicID");

            migrationBuilder.CreateIndex(
                name: "IX_PatientChronics_PatientID",
                table: "PatientChronics",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_PreferedSuburbs_NurseID",
                table: "PreferedSuburbs",
                column: "NurseID");

            migrationBuilder.CreateIndex(
                name: "IX_PreferedSuburbs_SuburbID",
                table: "PreferedSuburbs",
                column: "SuburbID");

            migrationBuilder.CreateIndex(
                name: "IX_Visits_NurseID",
                table: "Visits",
                column: "NurseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contracts");

            migrationBuilder.DropTable(
                name: "PatientChronics");

            migrationBuilder.DropTable(
                name: "PreferedSuburbs");

            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Chronics");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Patients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "NurseID",
                table: "Nurses",
                newName: "Id");
        }
    }
}
