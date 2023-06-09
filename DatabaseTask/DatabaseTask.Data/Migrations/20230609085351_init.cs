using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perenimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Isikukood = table.Column<int>(type: "int", nullable: false),
                    Kontaktaadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontakttelefon = table.Column<int>(type: "int", nullable: false),
                    Kontakt_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tööl_alates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tööl_kuni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ametinimetuse_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Firma_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Harukontor_Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Firmas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Registrinr = table.Column<int>(type: "int", nullable: false),
                    Lühinimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Koduleht = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktnr = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Firmas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Haigusleheds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Õigus_haiguslehele = table.Column<bool>(type: "bit", nullable: false),
                    Haiguspäevi_kokku = table.Column<int>(type: "int", nullable: false),
                    Haiguslehe_algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Haiguslehe_lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kasutatud_haiguspäevi = table.Column<int>(type: "int", nullable: false),
                    Allesolevaid_haiguspäevi = table.Column<int>(type: "int", nullable: false),
                    Aegunud_haiguspäevi = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Haigusleheds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Harukontors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmaId = table.Column<int>(type: "int", nullable: false),
                    Registrinr = table.Column<int>(type: "int", nullable: false),
                    Nimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Koduleht = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktisik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kontaktnr = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Harukontors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laenutused",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Laenutatav_kaup = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Laenutamisekp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tagastamisekp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laenutused", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ametinimetuseds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ametinimetus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ametis_alates = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ametis_kuni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Osakond = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otsese_ülemuse_eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otsese_ülemuse_perenimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Otsese_ülemuse_telefon = table.Column<int>(type: "int", nullable: false),
                    Otsese_ülemuse_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AmetinimetusedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ametinimetuseds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ametinimetuseds_Ametinimetuseds_AmetinimetusedId",
                        column: x => x.AmetinimetusedId,
                        principalTable: "Ametinimetuseds",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ametinimetuseds_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Childrens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TöötajaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Eesnimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perekonnanimi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sünniaeg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vanus = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Childrens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Childrens_Employee_TöötajaId",
                        column: x => x.TöötajaId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ligipääsuloads",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ligipääsuõigus = table.Column<bool>(type: "bit", nullable: false),
                    Ligipääsutase = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ligipääsu_alguskp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ligipääsu_lõppkp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligipääsuloads", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ligipääsuloads_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Puhkuseds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmployeeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Puhkuse_päevi_kokku = table.Column<int>(type: "int", nullable: false),
                    Puhkuse_algus = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Puhkuse_lõpp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kasutatud_puhkusepäevi = table.Column<int>(type: "int", nullable: false),
                    Allesolevaid_puhkusepäevi = table.Column<int>(type: "int", nullable: false),
                    Aegunud_puhkusepäevi = table.Column<int>(type: "int", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Puhkuseds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Puhkuseds_Employee_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tervisekontrolls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tervisekontrolli_vajadus = table.Column<bool>(type: "bit", nullable: false),
                    Eelmise_tervisekontrolli_kp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Uue_tervisekontrolli_kp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Kommentaar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tervisekontrolls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tervisekontrolls_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeFirma",
                columns: table => new
                {
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirmasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeFirma", x => new { x.EmployeesId, x.FirmasId });
                    table.ForeignKey(
                        name: "FK_EmployeeFirma_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeFirma_Firmas_FirmasId",
                        column: x => x.FirmasId,
                        principalTable: "Firmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHaiguslehed",
                columns: table => new
                {
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HaiguslehedsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHaiguslehed", x => new { x.EmployeesId, x.HaiguslehedsId });
                    table.ForeignKey(
                        name: "FK_EmployeeHaiguslehed_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeHaiguslehed_Haigusleheds_HaiguslehedsId",
                        column: x => x.HaiguslehedsId,
                        principalTable: "Haigusleheds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHarukontor",
                columns: table => new
                {
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HarukontorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHarukontor", x => new { x.EmployeesId, x.HarukontorsId });
                    table.ForeignKey(
                        name: "FK_EmployeeHarukontor_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeHarukontor_Harukontors_HarukontorsId",
                        column: x => x.HarukontorsId,
                        principalTable: "Harukontors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FirmaHarukontor",
                columns: table => new
                {
                    FirmasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HarukontorsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FirmaHarukontor", x => new { x.FirmasId, x.HarukontorsId });
                    table.ForeignKey(
                        name: "FK_FirmaHarukontor_Firmas_FirmasId",
                        column: x => x.FirmasId,
                        principalTable: "Firmas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FirmaHarukontor_Harukontors_HarukontorsId",
                        column: x => x.HarukontorsId,
                        principalTable: "Harukontors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeLaenutus",
                columns: table => new
                {
                    EmployeesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LaenutusedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeLaenutus", x => new { x.EmployeesId, x.LaenutusedId });
                    table.ForeignKey(
                        name: "FK_EmployeeLaenutus_Employee_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeLaenutus_Laenutused_LaenutusedId",
                        column: x => x.LaenutusedId,
                        principalTable: "Laenutused",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetuseds_AmetinimetusedId",
                table: "Ametinimetuseds",
                column: "AmetinimetusedId");

            migrationBuilder.CreateIndex(
                name: "IX_Ametinimetuseds_EmployeesId",
                table: "Ametinimetuseds",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Childrens_TöötajaId",
                table: "Childrens",
                column: "TöötajaId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeFirma_FirmasId",
                table: "EmployeeFirma",
                column: "FirmasId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHaiguslehed_HaiguslehedsId",
                table: "EmployeeHaiguslehed",
                column: "HaiguslehedsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeHarukontor_HarukontorsId",
                table: "EmployeeHarukontor",
                column: "HarukontorsId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeLaenutus_LaenutusedId",
                table: "EmployeeLaenutus",
                column: "LaenutusedId");

            migrationBuilder.CreateIndex(
                name: "IX_FirmaHarukontor_HarukontorsId",
                table: "FirmaHarukontor",
                column: "HarukontorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Ligipääsuloads_EmployeeId",
                table: "Ligipääsuloads",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Puhkuseds_EmployeeId",
                table: "Puhkuseds",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tervisekontrolls_EmployeesId",
                table: "Tervisekontrolls",
                column: "EmployeesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ametinimetuseds");

            migrationBuilder.DropTable(
                name: "Childrens");

            migrationBuilder.DropTable(
                name: "EmployeeFirma");

            migrationBuilder.DropTable(
                name: "EmployeeHaiguslehed");

            migrationBuilder.DropTable(
                name: "EmployeeHarukontor");

            migrationBuilder.DropTable(
                name: "EmployeeLaenutus");

            migrationBuilder.DropTable(
                name: "FirmaHarukontor");

            migrationBuilder.DropTable(
                name: "Ligipääsuloads");

            migrationBuilder.DropTable(
                name: "Puhkuseds");

            migrationBuilder.DropTable(
                name: "Tervisekontrolls");

            migrationBuilder.DropTable(
                name: "Haigusleheds");

            migrationBuilder.DropTable(
                name: "Laenutused");

            migrationBuilder.DropTable(
                name: "Firmas");

            migrationBuilder.DropTable(
                name: "Harukontors");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
