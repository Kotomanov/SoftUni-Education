using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetCoreTemplate.Data.Migrations
{
    public partial class UpdateCopuntryDistrict : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Districts_DistrictId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Districts_Countries_CountryId",
                table: "Districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Districts",
                table: "Districts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.RenameTable(
                name: "Districts",
                newName: "District");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_IsDeleted",
                table: "District",
                newName: "IX_District_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_Districts_CountryId",
                table: "District",
                newName: "IX_District_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_IsDeleted",
                table: "Country",
                newName: "IX_Country_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_District",
                table: "District",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_District_DistrictId",
                table: "Cities",
                column: "DistrictId",
                principalTable: "District",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_District_Country_CountryId",
                table: "District",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_District_DistrictId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_District_Country_CountryId",
                table: "District");

            migrationBuilder.DropPrimaryKey(
                name: "PK_District",
                table: "District");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "District",
                newName: "Districts");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameIndex(
                name: "IX_District_IsDeleted",
                table: "Districts",
                newName: "IX_Districts_IsDeleted");

            migrationBuilder.RenameIndex(
                name: "IX_District_CountryId",
                table: "Districts",
                newName: "IX_Districts_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Country_IsDeleted",
                table: "Countries",
                newName: "IX_Countries_IsDeleted");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Districts",
                table: "Districts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Districts_DistrictId",
                table: "Cities",
                column: "DistrictId",
                principalTable: "Districts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Districts_Countries_CountryId",
                table: "Districts",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
