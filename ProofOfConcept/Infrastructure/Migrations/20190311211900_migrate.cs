using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class migrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "Tenancy",
                schema: "dbo",
                columns: table => new
                {
                    TenancyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20)", nullable: false),
                    Phone = table.Column<string>(type: "varchar(15)", nullable: true),
                    Address = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenancy", x => x.TenancyId);
                });

            migrationBuilder.CreateTable(
                name: "ResidentialManagement",
                schema: "dbo",
                columns: table => new
                {
                    ResidentialManagementId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "varchar(150)", nullable: false),
                    TenancyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResidentialManagement", x => x.ResidentialManagementId);
                    table.ForeignKey(
                        name: "FK_ResidentialManagement_Tenancy_TenancyId",
                        column: x => x.TenancyId,
                        principalSchema: "dbo",
                        principalTable: "Tenancy",
                        principalColumn: "TenancyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ResidentialManagement_TenancyId",
                schema: "dbo",
                table: "ResidentialManagement",
                column: "TenancyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ResidentialManagement",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Tenancy",
                schema: "dbo");
        }
    }
}
