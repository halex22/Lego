using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Lego.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "lego_colors",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    rgb = table.Column<string>(type: "character varying(6)", maxLength: 6, nullable: false),
                    is_trans = table.Column<char>(type: "character(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_colors_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lego_inventories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    version = table.Column<int>(type: "integer", nullable: false),
                    set_num = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_inventories_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lego_inventory_sets",
                columns: table => new
                {
                    inventory_id = table.Column<int>(type: "integer", nullable: false),
                    set_num = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "lego_part_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_part_categories_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "lego_parts",
                columns: table => new
                {
                    part_num = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    part_cat_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_parts_pkey", x => x.part_num);
                });

            migrationBuilder.CreateTable(
                name: "lego_sets",
                columns: table => new
                {
                    set_num = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    year = table.Column<int>(type: "integer", nullable: true),
                    theme_id = table.Column<int>(type: "integer", nullable: true),
                    num_parts = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_sets_pkey", x => x.set_num);
                });

            migrationBuilder.CreateTable(
                name: "lego_themes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    parent_id = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_themes_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LegoInventoryParts",
                columns: table => new
                {
                    inventory_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    part_num = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    color_id = table.Column<int>(type: "integer", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    is_spare = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("lego_inv_part_pkey", x => x.inventory_id);
                    table.ForeignKey(
                        name: "FK_LegoInventoryParts_lego_colors_color_id",
                        column: x => x.color_id,
                        principalTable: "lego_colors",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LegoInventoryParts_color_id",
                table: "LegoInventoryParts",
                column: "color_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "lego_inventories");

            migrationBuilder.DropTable(
                name: "lego_inventory_sets");

            migrationBuilder.DropTable(
                name: "lego_part_categories");

            migrationBuilder.DropTable(
                name: "lego_parts");

            migrationBuilder.DropTable(
                name: "lego_sets");

            migrationBuilder.DropTable(
                name: "lego_themes");

            migrationBuilder.DropTable(
                name: "LegoInventoryParts");

            migrationBuilder.DropTable(
                name: "lego_colors");
        }
    }
}
