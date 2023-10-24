using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Data.Migrations
{
    public partial class MigracjaV5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ExerciseStatisticsId",
                table: "ExerciseType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "ExerciseStatistics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExerciseTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SessionsLastFourWeeks = table.Column<int>(type: "int", nullable: false),
                    BestResult = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExerciseStatistics", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExerciseType_ExerciseStatisticsId",
                table: "ExerciseType",
                column: "ExerciseStatisticsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExerciseType_ExerciseStatistics_ExerciseStatisticsId",
                table: "ExerciseType",
                column: "ExerciseStatisticsId",
                principalTable: "ExerciseStatistics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExerciseType_ExerciseStatistics_ExerciseStatisticsId",
                table: "ExerciseType");

            migrationBuilder.DropTable(
                name: "ExerciseStatistics");

            migrationBuilder.DropIndex(
                name: "IX_ExerciseType_ExerciseStatisticsId",
                table: "ExerciseType");

            migrationBuilder.DropColumn(
                name: "ExerciseStatisticsId",
                table: "ExerciseType");
        }
    }
}
