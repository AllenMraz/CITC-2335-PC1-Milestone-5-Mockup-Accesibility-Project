using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Milestone_5_Mockup.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatabaseItems",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ItemVersion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextbookOrSoftware = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Publisher = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VpatStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClassRequesting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IndividualRequesting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VpatRequestDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VpatLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VpatOutreachDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutsideRiskAssessment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalRiskAssessment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FinalApproval = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdditionalNotes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatabaseItems", x => x.ItemId);
                });

            migrationBuilder.InsertData(
                table: "DatabaseItems",
                columns: new[] { "ItemId", "AdditionalNotes", "ClassRequesting", "FinalApproval", "IndividualRequesting", "InternalRiskAssessment", "ItemName", "ItemVersion", "OutsideRiskAssessment", "Publisher", "TextbookOrSoftware", "VpatLink", "VpatOutreachDate", "VpatRequestDate", "VpatStatus" },
                values: new object[] { 1, "", "CITC 1310/1311", "Pending", "Meili Charles", "Pending", "Apache NetBeans", "Latest", "Pending", "Apache Software Foundation", "Software", "", "11-15-2026", "11-15-2026", "Yes" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatabaseItems");
        }
    }
}
