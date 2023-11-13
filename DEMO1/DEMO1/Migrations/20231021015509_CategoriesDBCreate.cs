using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DEMO1.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesDBCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCategory = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Description = table.Column<string>(type: "Varchar(100)", nullable: false),
                    Icon = table.Column<string>(type: "Varchar(50)", nullable: false),
                    Status = table.Column<int>(type: "Integer", nullable: false),
                    CreateAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdateAt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeleteAt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
