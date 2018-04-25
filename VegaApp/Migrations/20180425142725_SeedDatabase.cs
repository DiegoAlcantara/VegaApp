using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VegaApp.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Make1')");
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Make2')");
            migrationBuilder.Sql("Insert into Makes (Name) Values ('Make3')");


            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelA - Make1',(select Id From Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelB - Make1',(select Id From Makes where Name='Make1'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelC - Make1',(select Id From Makes where Name='Make1'))");


            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelE - Make2',(select Id From Makes where Name='Make2'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelF - Make2',(select Id From Makes where Name='Make2'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelG - Make2',(select Id From Makes where Name='Make2'))");


            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelH - Make3',(select Id From Makes where Name='Make3'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelI - Make3',(select Id From Makes where Name='Make3'))");
            migrationBuilder.Sql("Insert into Models (Name,MakeId) Values ('ModelJ - Make3',(select Id From Makes where Name='Make3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.Sql("Delete From Makes");
           
        }
    }
}
