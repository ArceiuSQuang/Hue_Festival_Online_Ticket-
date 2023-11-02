using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hue_Festival_Online_Ticket.Migrations
{
    public partial class CreateDb_V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lichdien");

            migrationBuilder.AddColumn<int>(
                name: "Doan_id",
                table: "Chuongtrinh",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fdate",
                table: "Chuongtrinh",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Nhom_id",
                table: "Chuongtrinh",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tdate",
                table: "Chuongtrinh",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Chuongtrinh",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DiaDiemYeuThichDb",
                columns: table => new
                {
                    ID_diadiem_yeuthich = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsWish = table.Column<bool>(type: "bit", nullable: true),
                    User_id = table.Column<int>(type: "int", nullable: true),
                    Diadiem_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiaDiemYeuThichDb", x => x.ID_diadiem_yeuthich);
                    table.ForeignKey(
                        name: "FK_DiaDiemYeuThichDb_Diadiem",
                        column: x => x.Diadiem_id,
                        principalTable: "Diadiem",
                        principalColumn: "ID_diadiem",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DiaDiemYeuThichDb_User",
                        column: x => x.User_id,
                        principalTable: "User",
                        principalColumn: "ID_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chuongtrinh_Doan_id",
                table: "Chuongtrinh",
                column: "Doan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Chuongtrinh_Nhom_id",
                table: "Chuongtrinh",
                column: "Nhom_id");

            migrationBuilder.CreateIndex(
                name: "IX_DiaDiemYeuThichDb_Diadiem_id",
                table: "DiaDiemYeuThichDb",
                column: "Diadiem_id");

            migrationBuilder.CreateIndex(
                name: "IX_DiaDiemYeuThichDb_User_id",
                table: "DiaDiemYeuThichDb",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChuongTrinhDb_Doan",
                table: "Chuongtrinh",
                column: "Doan_id",
                principalTable: "Doan",
                principalColumn: "ID_doan",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChuongTrinhDb_Nhom",
                table: "Chuongtrinh",
                column: "Nhom_id",
                principalTable: "Nhom",
                principalColumn: "ID_nhom",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChuongTrinhDb_Doan",
                table: "Chuongtrinh");

            migrationBuilder.DropForeignKey(
                name: "FK_ChuongTrinhDb_Nhom",
                table: "Chuongtrinh");

            migrationBuilder.DropTable(
                name: "DiaDiemYeuThichDb");

            migrationBuilder.DropIndex(
                name: "IX_Chuongtrinh_Doan_id",
                table: "Chuongtrinh");

            migrationBuilder.DropIndex(
                name: "IX_Chuongtrinh_Nhom_id",
                table: "Chuongtrinh");

            migrationBuilder.DropColumn(
                name: "Doan_id",
                table: "Chuongtrinh");

            migrationBuilder.DropColumn(
                name: "Fdate",
                table: "Chuongtrinh");

            migrationBuilder.DropColumn(
                name: "Nhom_id",
                table: "Chuongtrinh");

            migrationBuilder.DropColumn(
                name: "Tdate",
                table: "Chuongtrinh");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Chuongtrinh");

            migrationBuilder.CreateTable(
                name: "Lichdien",
                columns: table => new
                {
                    ID_lichdien = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Chuongtrinh_id = table.Column<int>(type: "int", nullable: true),
                    Doan_id = table.Column<int>(type: "int", nullable: true),
                    Nhom_id = table.Column<int>(type: "int", nullable: true),
                    Fdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Tdate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lichdien", x => x.ID_lichdien);
                    table.ForeignKey(
                        name: "FK_LichDienDb_Chuongtrinh",
                        column: x => x.Chuongtrinh_id,
                        principalTable: "Chuongtrinh",
                        principalColumn: "ID_chuongtrinh",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichDienDb_Doan",
                        column: x => x.Doan_id,
                        principalTable: "Doan",
                        principalColumn: "ID_doan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LichDienDb_Nhom",
                        column: x => x.Nhom_id,
                        principalTable: "Nhom",
                        principalColumn: "ID_nhom",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lichdien_Chuongtrinh_id",
                table: "Lichdien",
                column: "Chuongtrinh_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lichdien_Doan_id",
                table: "Lichdien",
                column: "Doan_id");

            migrationBuilder.CreateIndex(
                name: "IX_Lichdien_Nhom_id",
                table: "Lichdien",
                column: "Nhom_id");
        }
    }
}
