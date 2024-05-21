﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TFGBackend.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoCategoria = table.Column<string>(name: "Tipo_Categoria", type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Partido",
                columns: table => new
                {
                    IdPartido = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estrellas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partido", x => x.IdPartido);
                });

            migrationBuilder.CreateTable(
                name: "Pista",
                columns: table => new
                {
                    IdPista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Photo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pista", x => x.IdPista);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    IdProduct = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameProduct = table.Column<string>(name: "Name_Product", type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<string>(name: "Product_Price", type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(name: "Product_Description", type: "nvarchar(max)", nullable: false),
                    ProductAmount = table.Column<string>(name: "Product_Amount", type: "nvarchar(max)", nullable: false),
                    IdCategoria = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.IdProduct);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rol = table.Column<int>(type: "int", nullable: false),
                    IdPartido = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Sesion",
                columns: table => new
                {
                    IdSesion = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SesionTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPista = table.Column<int>(type: "int", nullable: false),
                    PistaIdPista = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sesion", x => x.IdSesion);
                    table.ForeignKey(
                        name: "FK_Sesion_Pista_PistaIdPista",
                        column: x => x.PistaIdPista,
                        principalTable: "Pista",
                        principalColumn: "IdPista");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    IdReservation = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserEmail = table.Column<string>(name: "User_Email", type: "nvarchar(max)", nullable: false),
                    ReservationPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSesion = table.Column<int>(type: "int", nullable: false),
                    SesionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    IdPista = table.Column<int>(type: "int", nullable: false),
                    UsuarioIdUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva", x => x.IdReservation);
                    table.ForeignKey(
                        name: "FK_Reserva_Usuarios_UsuarioIdUser",
                        column: x => x.UsuarioIdUser,
                        principalTable: "Usuarios",
                        principalColumn: "IdUser");
                });

            migrationBuilder.InsertData(
                table: "Categoria",
                columns: new[] { "IdCategoria", "Tipo_Categoria" },
                values: new object[,]
                {
                    { 1, "Palas de Padel" },
                    { 2, "Ropa de Padel" },
                    { 3, "Accesorios de Padel" },
                    { 4, "Pelotas de Padel" },
                    { 5, "Bolsas de Padel" }
                });

            migrationBuilder.InsertData(
                table: "Partido",
                columns: new[] { "IdPartido", "Date", "Duration", "Estrellas", "IdUser", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8917), "2 horas", "5", 1, "Partido 1", "photo1", 50m },
                    { 2, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8921), "1 hora y 30 minutos", "4", 2, "Partido 2", "photo2", 40m },
                    { 3, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8923), "2 horas", "4.5", 3, "Partido 3", "photo3", 60m }
                });

            migrationBuilder.InsertData(
                table: "Pista",
                columns: new[] { "IdPista", "Date", "Description", "Duration", "Name", "Photo", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8774), "Pista 1", "1 hora y 30 minutos", "Pista 1", "photo1", 10m },
                    { 2, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8816), "Pista 2", "1 hora y 30 minutos", "Pista 2", "photo2", 20m },
                    { 3, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8819), "Pista 3", "1 hora y 30 minutos", "Pista 3", "photo3", 30m }
                });

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProduct", "IdCategoria", "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[,]
                {
                    { 1, 4, "6 Pelotas Xtreme", "100", "Pelota capaz de durar más de 3 partidos, resistente a golpes bruscos, muy ligera", "10" },
                    { 2, 4, "6 Pelotas ProFlight", "100", "Pelota diseñada para un vuelo estable y consistente. Construcción duradera para resistir largos rallies. Ideal para jugadores que buscan precisión en sus golpes.", "12" },
                    { 3, 4, "6 Pelotas AirTech", "100", "Pelota con tecnología de cámara de aire para un rebote uniforme y predecible. Cubierta resistente que garantiza una larga durabilidad. Apta para todo tipo de superficies.", "11" },
                    { 4, 4, "6 Pelotas PowerSpin", "180", "Pelota diseñada para generar mayor efecto en los golpes. Núcleo interno optimizado para aumentar el spin. Duradera y resistente a golpes.", "13" },
                    { 5, 4, "6 Pelotas SpeedX", "250", "Pelota de alta velocidad para rallies rápidos. Superficie texturizada para un mejor agarre en la pista. Apta para jugadores de todos los niveles.", "10" },
                    { 6, 5, "Bolsa ProTour", "20", "Bolsa de tamaño mediano con compartimentos para hasta 3 palas, pelotas y accesorios. Diseño ergonómico con correas ajustables para mayor comodidad.", "50" },
                    { 7, 5, "Mochila PádelTech", "15", "Mochila resistente al agua con capacidad para 2 palas, pelotas, calzado y otros accesorios. Bolsillos laterales para botellas de agua.", "40" },
                    { 8, 5, "Bolsa TravelMaster", "8", "Bolsa de viaje con ruedas para transportar todo el equipo de pádel de forma cómoda. Compartimento especial para palas y ropa.", "80" },
                    { 9, 5, "Bolsa Elite Pro", "5", "Bolsa de alta gama con capacidad para 4 palas, compartimentos termoaislados para pelotas y ropa. Diseño elegante con detalles en cuero.", "120" },
                    { 10, 5, "Bolsa Junior", "12", "Bolsa diseñada para niños con espacio para 1 pala, pelotas y otros accesorios. Diseño colorido y ligero.", "30" },
                    { 11, 1, "Pala Pro Carbon", "25", "Pala de alto rendimiento con núcleo de carbono y forma de lágrima. Perfecta para jugadores avanzados. Potencia y control excepcionales.", "150" },
                    { 12, 1, "Pala All-Round", "30", "Pala equilibrada para jugadores de nivel intermedio. Núcleo de goma EVA y forma redonda. Gran versatilidad en el juego.", "100" },
                    { 13, 1, "Pala Junior", "15", "Pala diseñada específicamente para jóvenes jugadores. Ligera y fácil de manejar, con tecnología adaptada para el aprendizaje.", "70" },
                    { 14, 1, "Pala PowerShot", "20", "Pala de potencia con forma de diamante. Amplio punto dulce y excelente salida de bola. Ideal para jugadores que buscan golpes agresivos.", "120" },
                    { 15, 1, "Pala ControlMaster", "18", "Pala diseñada para un control preciso del juego. Forma redonda y balance neutro. Perfecta para jugadores que priorizan la precisión sobre la potencia.", "130" },
                    { 16, 3, "Overgrip ProFeel", "50", "Overgrip de alta calidad para mejorar el agarre y absorber el sudor. Material duradero y cómodo. Disponible en varios colores.", "5" },
                    { 17, 3, "Muñequera Profesional", "40", "Muñequera ajustable para proteger la muñeca durante el juego. Tejido transpirable que evita la acumulación de sudor. Disponible en diferentes tamaños.", "8" },
                    { 18, 3, "Gorra PádelSport", "35", "Gorra deportiva con visera curvada para proteger del sol. Material ligero y transpirable. Diseño moderno con el logo de PádelSport.", "15" },
                    { 19, 3, "Protectores de Pala", "60", "Protectores adhesivos para proteger el borde de la pala de golpes y roces. Fácil de colocar y resistente al desgaste. Paquete con 3 unidades.", "10" },
                    { 20, 3, "Cinta de Agarre ProFlex", "30", "Cinta adhesiva para mejorar el agarre en el mango de la pala. Material antideslizante y resistente al desgaste. Rollo de 3 metros.", "7" }
                });

            migrationBuilder.InsertData(
                table: "Reserva",
                columns: new[] { "IdReservation", "IdPista", "IdSesion", "IdUser", "ReservationDate", "ReservationPrice", "SesionTime", "User_Email", "UsuarioIdUser" },
                values: new object[,]
                {
                    { 1, 0, 0, 0, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8891), "10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hola1@gmail.com", null },
                    { 2, 0, 0, 0, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8894), "10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hola2@gmail.com", null },
                    { 3, 0, 0, 0, new DateTime(2024, 5, 21, 18, 6, 16, 938, DateTimeKind.Local).AddTicks(8895), "10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hola3@gmail.com", null }
                });

            migrationBuilder.InsertData(
                table: "Sesion",
                columns: new[] { "IdSesion", "IdPista", "PistaIdPista", "SesionTime" },
                values: new object[,]
                {
                    { 1, 1, null, "10:00" },
                    { 2, 2, null, "12:00" },
                    { 3, 3, null, "14:00" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "IdUser", "Email", "IdPartido", "Password", "Rol", "UserName" },
                values: new object[,]
                {
                    { 1, "hola1@gmail.com", 0, "123", 1, "cosmar" },
                    { 2, "hola2@gmail.com", 0, "123", 2, "cosmari" },
                    { 3, "hola3@gmail.com", 0, "123", 2, "cosmaro" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioIdUser",
                table: "Reserva",
                column: "UsuarioIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Sesion_PistaIdPista",
                table: "Sesion",
                column: "PistaIdPista");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Partido");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Sesion");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Pista");
        }
    }
}
