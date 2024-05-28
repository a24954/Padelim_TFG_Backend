using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TFGBackend.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddPostMatch : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 1,
                column: "Tipo_Categoria",
                value: "Palas de Padel");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 2,
                column: "Tipo_Categoria",
                value: "Ropa de Padel");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 3,
                column: "Tipo_Categoria",
                value: "Accesorios de Padel");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 4,
                column: "Tipo_Categoria",
                value: "Pelotas de Padel");

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 5,
                column: "Tipo_Categoria",
                value: "Bolsas de Padel");

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "IdPartido",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "IdPartido",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5933));

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "IdPartido",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "Pista",
                keyColumn: "IdPista",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "Pista",
                keyColumn: "IdPista",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5856));

            migrationBuilder.UpdateData(
                table: "Pista",
                keyColumn: "IdPista",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 1,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "6 Pelotas Xtreme", "100", "Pelota capaz de durar más de 3 partidos, resistente a golpes bruscos, muy ligera", "10" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 2,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "6 Pelotas ProFlight", "100", "Pelota diseñada para un vuelo estable y consistente. Construcción duradera para resistir largos rallies. Ideal para jugadores que buscan precisión en sus golpes.", "12" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 3,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "6 Pelotas AirTech", "100", "Pelota con tecnología de cámara de aire para un rebote uniforme y predecible. Cubierta resistente que garantiza una larga durabilidad. Apta para todo tipo de superficies.", "11" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 4,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "6 Pelotas PowerSpin", "180", "Pelota diseñada para generar mayor efecto en los golpes. Núcleo interno optimizado para aumentar el spin. Duradera y resistente a golpes.", "13" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 5,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "6 Pelotas SpeedX", "250", "Pelota de alta velocidad para rallies rápidos. Superficie texturizada para un mejor agarre en la pista. Apta para jugadores de todos los niveles.", "10" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 6,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Bolsa ProTour", "20", "Bolsa de tamaño mediano con compartimentos para hasta 3 palas, pelotas y accesorios. Diseño ergonómico con correas ajustables para mayor comodidad.", "50" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 7,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Mochila PádelTech", "15", "Mochila resistente al agua con capacidad para 2 palas, pelotas, calzado y otros accesorios. Bolsillos laterales para botellas de agua.", "40" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 8,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Bolsa TravelMaster", "8", "Bolsa de viaje con ruedas para transportar todo el equipo de pádel de forma cómoda. Compartimento especial para palas y ropa.", "80" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 9,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Bolsa Elite Pro", "5", "Bolsa de alta gama con capacidad para 4 palas, compartimentos termoaislados para pelotas y ropa. Diseño elegante con detalles en cuero.", "120" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 10,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Bolsa Junior", "12", "Bolsa diseñada para niños con espacio para 1 pala, pelotas y otros accesorios. Diseño colorido y ligero.", "30" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 11,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Pala Pro Carbon", "25", "Pala de alto rendimiento con núcleo de carbono y forma de lágrima. Perfecta para jugadores avanzados. Potencia y control excepcionales.", "150" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 12,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Pala All-Round", "30", "Pala equilibrada para jugadores de nivel intermedio. Núcleo de goma EVA y forma redonda. Gran versatilidad en el juego.", "100" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 13,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Pala Junior", "15", "Pala diseñada específicamente para jóvenes jugadores. Ligera y fácil de manejar, con tecnología adaptada para el aprendizaje.", "70" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 14,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Pala PowerShot", "20", "Pala de potencia con forma de diamante. Amplio punto dulce y excelente salida de bola. Ideal para jugadores que buscan golpes agresivos.", "120" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 15,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Pala ControlMaster", "18", "Pala diseñada para un control preciso del juego. Forma redonda y balance neutro. Perfecta para jugadores que priorizan la precisión sobre la potencia.", "130" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 16,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Overgrip ProFeel", "50", "Overgrip de alta calidad para mejorar el agarre y absorber el sudor. Material duradero y cómodo. Disponible en varios colores.", "5" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 17,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Muñequera Profesional", "40", "Muñequera ajustable para proteger la muñeca durante el juego. Tejido transpirable que evita la acumulación de sudor. Disponible en diferentes tamaños.", "8" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 18,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Gorra PádelSport", "35", "Gorra deportiva con visera curvada para proteger del sol. Material ligero y transpirable. Diseño moderno con el logo de PádelSport.", "15" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 19,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Protectores de Pala", "60", "Protectores adhesivos para proteger el borde de la pala de golpes y roces. Fácil de colocar y resistente al desgaste. Paquete con 3 unidades.", "10" });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 20,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { "Cinta de Agarre ProFlex", "30", "Cinta adhesiva para mejorar el agarre en el mango de la pala. Material antideslizante y resistente al desgaste. Rollo de 3 metros.", "7" });

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReservation",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReservation",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReservation",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 5, 28, 17, 57, 17, 860, DateTimeKind.Local).AddTicks(5903));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 1,
                column: "Tipo_Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 2,
                column: "Tipo_Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 3,
                column: "Tipo_Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 4,
                column: "Tipo_Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Categoria",
                keyColumn: "IdCategoria",
                keyValue: 5,
                column: "Tipo_Categoria",
                value: null);

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "IdPartido",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "IdPartido",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(763));

            migrationBuilder.UpdateData(
                table: "Partido",
                keyColumn: "IdPartido",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "Pista",
                keyColumn: "IdPista",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Pista",
                keyColumn: "IdPista",
                keyValue: 2,
                column: "Date",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Pista",
                keyColumn: "IdPista",
                keyValue: 3,
                column: "Date",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 1,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 2,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 3,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 4,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 5,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 6,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 7,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 8,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 9,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 10,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 11,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 12,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 13,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 14,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 15,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 16,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 17,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 18,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 19,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProduct",
                keyValue: 20,
                columns: new[] { "Name_Product", "Product_Amount", "Product_Description", "Product_Price" },
                values: new object[] { null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReservation",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(695));

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReservation",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Reserva",
                keyColumn: "IdReservation",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 5, 27, 18, 44, 24, 139, DateTimeKind.Local).AddTicks(699));
        }
    }
}
