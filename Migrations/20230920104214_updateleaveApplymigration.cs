﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace itgsgroup.Migrations
{
    /// <inheritdoc />
    public partial class updateleaveApplymigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "days",
                table: "leaveApplies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "days",
                table: "leaveApplies");
        }
    }
}
