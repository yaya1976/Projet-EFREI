using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Presales.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ASSETCLASSES",
                schema: "dbo",
                columns: table => new
                {
                    IdAssetClass = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameClass = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ASSETCLASSES", x => x.IdAssetClass);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTS",
                schema: "dbo",
                columns: table => new
                {
                    IdBdr = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    ClientType = table.Column<string>(type: "text", nullable: false),
                    DateLastRFP = table.Column<DateOnly>(type: "date", nullable: false),
                    SgssProspectionUniverse = table.Column<bool>(type: "boolean", nullable: false),
                    OverviewCustomerActivity = table.Column<string>(type: "text", nullable: false),
                    TotalGlobalFirmAumKeur = table.Column<float>(type: "real", nullable: false),
                    NumberOfFunds = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTS", x => x.IdBdr);
                });

            migrationBuilder.CreateTable(
                name: "PRIORITIES",
                columns: table => new
                {
                    IdPriority = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NameOfPriority = table.Column<string>(type: "text", nullable: false),
                    CustomerNeedDescription = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PRIORITIES", x => x.IdPriority);
                });

            migrationBuilder.CreateTable(
                name: "SGSS_SERVICES",
                columns: table => new
                {
                    IdBdr = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IdService = table.Column<long>(type: "bigint", nullable: false),
                    NameServie = table.Column<string>(type: "text", nullable: false),
                    TypeOfService = table.Column<string>(type: "text", nullable: false),
                    IdCountry = table.Column<string>(type: "text", nullable: false),
                    DepartementBanking = table.Column<string>(type: "text", nullable: false),
                    Outsourced = table.Column<bool>(type: "boolean", nullable: false),
                    ItSystem = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    SgssServiceIdBdr = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SGSS_SERVICES", x => x.IdBdr);
                    table.ForeignKey(
                        name: "FK_SGSS_SERVICES_SGSS_SERVICES_SgssServiceIdBdr",
                        column: x => x.SgssServiceIdBdr,
                        principalTable: "SGSS_SERVICES",
                        principalColumn: "IdBdr");
                });

            migrationBuilder.CreateTable(
                name: "CLIENTS-ASSETCLASSES",
                schema: "dbo",
                columns: table => new
                {
                    IdBdr = table.Column<long>(type: "bigint", nullable: false),
                    IdAssetClass = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTS-ASSETCLASSES", x => new { x.IdAssetClass, x.IdBdr });
                    table.ForeignKey(
                        name: "FK_CLIENTS-ASSETCLASSES_ASSETCLASSES_IdAssetClass",
                        column: x => x.IdAssetClass,
                        principalSchema: "dbo",
                        principalTable: "ASSETCLASSES",
                        principalColumn: "IdAssetClass",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLIENTS-ASSETCLASSES_CLIENTS_IdBdr",
                        column: x => x.IdBdr,
                        principalSchema: "dbo",
                        principalTable: "CLIENTS",
                        principalColumn: "IdBdr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LOCAL_AUM",
                schema: "dbo",
                columns: table => new
                {
                    IdLocalAum = table.Column<long>(type: "bigint", nullable: false),
                    IdBdr = table.Column<long>(type: "bigint", nullable: false),
                    IdCountry = table.Column<string>(type: "text", nullable: false),
                    TotalLocalFirmAumEur = table.Column<bool>(type: "boolean", nullable: false),
                    AmountTotalAssetCustodiedByCountry = table.Column<bool>(type: "boolean", nullable: false),
                    CompetitoresCurrentCustodiensDepositariesFundAdministrators = table.Column<string>(type: "text", nullable: false),
                    AmountLocalAssetCustodiedByCometitores = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LOCAL_AUM", x => x.IdLocalAum);
                    table.ForeignKey(
                        name: "FK_LOCAL_AUM_CLIENTS_IdLocalAum",
                        column: x => x.IdLocalAum,
                        principalSchema: "dbo",
                        principalTable: "CLIENTS",
                        principalColumn: "IdBdr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLIENT_PRIORITIES",
                schema: "dbo",
                columns: table => new
                {
                    IdBdr = table.Column<long>(type: "bigint", nullable: false),
                    IdPriority = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT_PRIORITIES", x => new { x.IdPriority, x.IdBdr });
                    table.ForeignKey(
                        name: "FK_CLIENT_PRIORITIES_CLIENTS_IdBdr",
                        column: x => x.IdBdr,
                        principalSchema: "dbo",
                        principalTable: "CLIENTS",
                        principalColumn: "IdBdr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLIENT_PRIORITIES_PRIORITIES_IdPriority",
                        column: x => x.IdPriority,
                        principalTable: "PRIORITIES",
                        principalColumn: "IdPriority",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CLIENT-SGSSSERVICIES",
                columns: table => new
                {
                    IdService = table.Column<long>(type: "bigint", nullable: false),
                    IdBdr = table.Column<string>(type: "text", nullable: false),
                    SgssServiceIdBdr = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT-SGSSSERVICIES", x => x.IdService);
                    table.ForeignKey(
                        name: "FK_CLIENT-SGSSSERVICIES_CLIENTS_IdService",
                        column: x => x.IdService,
                        principalSchema: "dbo",
                        principalTable: "CLIENTS",
                        principalColumn: "IdBdr",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CLIENT-SGSSSERVICIES_SGSS_SERVICES_SgssServiceIdBdr",
                        column: x => x.SgssServiceIdBdr,
                        principalTable: "SGSS_SERVICES",
                        principalColumn: "IdBdr",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENT_PRIORITIES_IdBdr",
                schema: "dbo",
                table: "CLIENT_PRIORITIES",
                column: "IdBdr");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENT-SGSSSERVICIES_SgssServiceIdBdr",
                table: "CLIENT-SGSSSERVICIES",
                column: "SgssServiceIdBdr");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTS-ASSETCLASSES_IdBdr",
                schema: "dbo",
                table: "CLIENTS-ASSETCLASSES",
                column: "IdBdr");

            migrationBuilder.CreateIndex(
                name: "IX_SGSS_SERVICES_SgssServiceIdBdr",
                table: "SGSS_SERVICES",
                column: "SgssServiceIdBdr");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENT_PRIORITIES",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CLIENT-SGSSSERVICIES");

            migrationBuilder.DropTable(
                name: "CLIENTS-ASSETCLASSES",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "LOCAL_AUM",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PRIORITIES");

            migrationBuilder.DropTable(
                name: "SGSS_SERVICES");

            migrationBuilder.DropTable(
                name: "ASSETCLASSES",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "CLIENTS",
                schema: "dbo");
        }
    }
}
