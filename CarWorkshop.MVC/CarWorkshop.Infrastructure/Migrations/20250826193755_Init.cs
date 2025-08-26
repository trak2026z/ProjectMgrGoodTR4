using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CarWorkshop.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarWorkshops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ContactDetailsPhoneNumber = table.Column<string>(name: "ContactDetails_PhoneNumber", type: "text", nullable: true),
                    ContactDetailsStreet = table.Column<string>(name: "ContactDetails_Street", type: "text", nullable: true),
                    ContactDetailsCity = table.Column<string>(name: "ContactDetails_City", type: "text", nullable: true),
                    ContactDetailsPostalCode = table.Column<string>(name: "ContactDetails_PostalCode", type: "text", nullable: true),
                    About = table.Column<string>(type: "text", nullable: true),
                    EncodedName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarWorkshops", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarWorkshops");
        }
    }
}
