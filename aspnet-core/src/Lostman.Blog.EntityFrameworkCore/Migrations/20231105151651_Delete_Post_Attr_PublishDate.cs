﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lostman.Blog.Migrations
{
    /// <inheritdoc />
    public partial class DeletePostAttrPublishDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishDate",
                table: "AppPosts");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "PublishDate",
                table: "AppPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
