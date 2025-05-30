﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace itgsgroup.Migrations
{
    /// <inheritdoc />
    public partial class updateleaveApplymigration2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "status",
                table: "leaveApplies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "status",
                table: "leaveApplies");
        }
    }
}
