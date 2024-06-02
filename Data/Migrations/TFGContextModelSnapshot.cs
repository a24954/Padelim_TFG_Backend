﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TFGBackend.Data;

#nullable disable

namespace TFGBackend.Data.Migrations
{
    [DbContext(typeof(TFGContext))]
    partial class TFGContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TFGBackend.Models.Categoria", b =>
                {
                    b.Property<int>("IdCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCategoria"));

                    b.Property<string>("Tipo_Categoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoria");

                    b.ToTable("Categoria");

                    b.HasData(
                        new
                        {
                            IdCategoria = 1,
                            TipoCategoria = "Palas de Padel"
                        },
                        new
                        {
                            IdCategoria = 2,
                            TipoCategoria = "Ropa de Padel"
                        },
                        new
                        {
                            IdCategoria = 3,
                            TipoCategoria = "Accesorios de Padel"
                        },
                        new
                        {
                            IdCategoria = 4,
                            TipoCategoria = "Pelotas de Padel"
                        },
                        new
                        {
                            IdCategoria = 5,
                            TipoCategoria = "Bolsas de Padel"
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.Compra", b =>
                {
                    b.Property<int>("IdCompra")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCompra"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<decimal>("PrecioTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdCompra");

                    b.HasIndex("IdProducto");

                    b.HasIndex("IdUser");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("TFGBackend.Models.Partido", b =>
                {
                    b.Property<int>("IdPartido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPartido"));

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estrellas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("IdPartido");

                    b.ToTable("Partido");

                    b.HasData(
                        new
                        {
                            IdPartido = 1,
                            Date = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(7033),
                            Duration = "2 horas",
                            Estrellas = "5",
                            IdUser = 1,
                            Name = "Partido 1",
                            Photo = "photo1",
                            Position = 0
                        },
                        new
                        {
                            IdPartido = 2,
                            Date = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(7037),
                            Duration = "1 hora y 30 minutos",
                            Estrellas = "4",
                            IdUser = 2,
                            Name = "Partido 2",
                            Photo = "photo2",
                            Position = 0
                        },
                        new
                        {
                            IdPartido = 3,
                            Date = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(7039),
                            Duration = "2 horas",
                            Estrellas = "4.5",
                            IdUser = 3,
                            Name = "Partido 3",
                            Photo = "photo3",
                            Position = 0
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.Pista", b =>
                {
                    b.Property<int>("IdPista")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPista"));

                    b.Property<DateTime?>("Date")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdPista");

                    b.ToTable("Pista");

                    b.HasData(
                        new
                        {
                            IdPista = 1,
                            Date = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(6904),
                            Description = "Pista 1",
                            Duration = "1 hora y 30 minutos",
                            Name = "Pista 1",
                            Photo = "photo1",
                            Price = 10m
                        },
                        new
                        {
                            IdPista = 2,
                            Date = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(6950),
                            Description = "Pista 2",
                            Duration = "1 hora y 30 minutos",
                            Name = "Pista 2",
                            Photo = "photo2",
                            Price = 20m
                        },
                        new
                        {
                            IdPista = 3,
                            Date = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(6953),
                            Description = "Pista 3",
                            Duration = "1 hora y 30 minutos",
                            Name = "Pista 3",
                            Photo = "photo3",
                            Price = 30m
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.Producto", b =>
                {
                    b.Property<int>("IdProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProduct"));

                    b.Property<int>("IdCategoria")
                        .HasColumnType("int");

                    b.Property<string>("Name_Product")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Amount")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Product_Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Product_Price")
                        .HasColumnType("float");

                    b.HasKey("IdProduct");

                    b.ToTable("Producto");

                    b.HasData(
                        new
                        {
                            IdProduct = 1,
                            IdCategoria = 4,
                            NameProduct = "6 Pelotas Xtreme",
                            Photo = "https://example.com/photos/pelotas_xtreme.jpg",
                            ProductAmount = "100",
                            ProductDescription = "Pelota capaz de durar más de 3 partidos, resistente a golpes bruscos, muy ligera",
                            ProductPrice = 10.0
                        },
                        new
                        {
                            IdProduct = 2,
                            IdCategoria = 4,
                            NameProduct = "6 Pelotas ProFlight",
                            Photo = "https://example.com/photos/pelotas_proflight.jpg",
                            ProductAmount = "100",
                            ProductDescription = "Pelota diseñada para un vuelo estable y consistente. Construcción duradera para resistir largos rallies. Ideal para jugadores que buscan precisión en sus golpes.",
                            ProductPrice = 12.0
                        },
                        new
                        {
                            IdProduct = 3,
                            IdCategoria = 4,
                            NameProduct = "6 Pelotas AirTech",
                            Photo = "https://example.com/photos/pelotas_airtech.jpg",
                            ProductAmount = "100",
                            ProductDescription = "Pelota con tecnología de cámara de aire para un rebote uniforme y predecible. Cubierta resistente que garantiza una larga durabilidad. Apta para todo tipo de superficies.",
                            ProductPrice = 11.0
                        },
                        new
                        {
                            IdProduct = 4,
                            IdCategoria = 4,
                            NameProduct = "6 Pelotas PowerSpin",
                            Photo = "https://example.com/photos/pelotas_powerspin.jpg",
                            ProductAmount = "180",
                            ProductDescription = "Pelota diseñada para generar mayor efecto en los golpes. Núcleo interno optimizado para aumentar el spin. Duradera y resistente a golpes.",
                            ProductPrice = 13.0
                        },
                        new
                        {
                            IdProduct = 5,
                            IdCategoria = 4,
                            NameProduct = "6 Pelotas SpeedX",
                            Photo = "https://example.com/photos/pelotas_speedx.jpg",
                            ProductAmount = "250",
                            ProductDescription = "Pelota de alta velocidad para rallies rápidos. Superficie texturizada para un mejor agarre en la pista. Apta para jugadores de todos los niveles.",
                            ProductPrice = 10.0
                        },
                        new
                        {
                            IdProduct = 6,
                            IdCategoria = 5,
                            NameProduct = "Bolsa ProTour",
                            Photo = "https://www.ikea.com/es/es/images/bolsa-de-padel-pro-tour__0964485_PE817502_S4.JPG?f=xs",
                            ProductAmount = "20",
                            ProductDescription = "Bolsa de tamaño mediano con compartimentos para hasta 3 palas, pelotas y accesorios. Diseño ergonómico con correas ajustables para mayor comodidad.",
                            ProductPrice = 50.0
                        },
                        new
                        {
                            IdProduct = 7,
                            IdCategoria = 5,
                            NameProduct = "Mochila PádelTech",
                            Photo = "https://example.com/photos/mochila_padeltech.jpg",
                            ProductAmount = "15",
                            ProductDescription = "Mochila resistente al agua con capacidad para 2 palas, pelotas, calzado y otros accesorios. Bolsillos laterales para botellas de agua.",
                            ProductPrice = 40.0
                        },
                        new
                        {
                            IdProduct = 8,
                            IdCategoria = 5,
                            NameProduct = "Bolsa TravelMaster",
                            Photo = "https://example.com/photos/bolsa_travelmaster.jpg",
                            ProductAmount = "8",
                            ProductDescription = "Bolsa de viaje con ruedas para transportar todo el equipo de pádel de forma cómoda. Compartimento especial para palas y ropa.",
                            ProductPrice = 80.0
                        },
                        new
                        {
                            IdProduct = 9,
                            IdCategoria = 5,
                            NameProduct = "Bolsa Elite Pro",
                            Photo = "https://example.com/photos/bolsa_elite_pro.jpg",
                            ProductAmount = "5",
                            ProductDescription = "Bolsa de alta gama con capacidad para 4 palas, compartimentos termoaislados para pelotas y ropa. Diseño elegante con detalles en cuero.",
                            ProductPrice = 120.0
                        },
                        new
                        {
                            IdProduct = 10,
                            IdCategoria = 5,
                            NameProduct = "Bolsa Junior",
                            Photo = "https://example.com/photos/bolsa_junior.jpg",
                            ProductAmount = "12",
                            ProductDescription = "Bolsa diseñada para niños con espacio para 1 pala, pelotas y otros accesorios. Diseño colorido y ligero.",
                            ProductPrice = 30.0
                        },
                        new
                        {
                            IdProduct = 11,
                            IdCategoria = 1,
                            NameProduct = "Pala Pro Carbon",
                            Photo = "https://example.com/photos/pala_pro_carbon.jpg",
                            ProductAmount = "25",
                            ProductDescription = "Pala de alto rendimiento con núcleo de carbono y forma de lágrima. Perfecta para jugadores avanzados. Potencia y control excepcionales.",
                            ProductPrice = 150.0
                        },
                        new
                        {
                            IdProduct = 12,
                            IdCategoria = 1,
                            NameProduct = "Pala All-Round",
                            Photo = "https://example.com/photos/pala_all_round.jpg",
                            ProductAmount = "30",
                            ProductDescription = "Pala equilibrada para jugadores de nivel intermedio. Núcleo de goma EVA y forma redonda. Gran versatilidad en el juego.",
                            ProductPrice = 100.0
                        },
                        new
                        {
                            IdProduct = 13,
                            IdCategoria = 1,
                            NameProduct = "Pala Junior",
                            Photo = "https://example.com/photos/pala_junior.jpg",
                            ProductAmount = "15",
                            ProductDescription = "Pala diseñada específicamente para jóvenes jugadores. Ligera y fácil de manejar, con tecnología adaptada para el aprendizaje.",
                            ProductPrice = 70.0
                        },
                        new
                        {
                            IdProduct = 14,
                            IdCategoria = 1,
                            NameProduct = "Pala PowerShot",
                            Photo = "https://example.com/photos/pala_powershot.jpg",
                            ProductAmount = "20",
                            ProductDescription = "Pala de potencia con forma de diamante. Amplio punto dulce y excelente salida de bola. Ideal para jugadores que buscan golpes agresivos.",
                            ProductPrice = 120.0
                        },
                        new
                        {
                            IdProduct = 15,
                            IdCategoria = 1,
                            NameProduct = "Pala ControlMaster",
                            Photo = "https://example.com/photos/pala_controlmaster.jpg",
                            ProductAmount = "18",
                            ProductDescription = "Pala diseñada para un control preciso del juego. Forma redonda y balance neutro. Perfecta para jugadores que priorizan la precisión sobre la potencia.",
                            ProductPrice = 130.0
                        },
                        new
                        {
                            IdProduct = 16,
                            IdCategoria = 3,
                            NameProduct = "Overgrip ProFeel",
                            Photo = "https://example.com/photos/overgrip_profeel.jpg",
                            ProductAmount = "50",
                            ProductDescription = "Overgrip de alta calidad para mejorar el agarre y absorber el sudor. Material duradero y cómodo. Disponible en varios colores.",
                            ProductPrice = 5.0
                        },
                        new
                        {
                            IdProduct = 17,
                            IdCategoria = 3,
                            NameProduct = "Muñequera Profesional",
                            Photo = "https://example.com/photos/munequera_profesional.jpg",
                            ProductAmount = "40",
                            ProductDescription = "Muñequera ajustable para proteger la muñeca durante el juego. Tejido transpirable que evita la acumulación de sudor. Disponible en diferentes tamaños.",
                            ProductPrice = 8.0
                        },
                        new
                        {
                            IdProduct = 18,
                            IdCategoria = 3,
                            NameProduct = "Gorra PádelSport",
                            Photo = "https://example.com/photos/gorra_padelsport.jpg",
                            ProductAmount = "35",
                            ProductDescription = "Gorra deportiva con visera curvada para proteger del sol. Material ligero y transpirable. Diseño moderno con el logo de PádelSport.",
                            ProductPrice = 15.0
                        },
                        new
                        {
                            IdProduct = 19,
                            IdCategoria = 3,
                            NameProduct = "Protectores de Pala",
                            Photo = "https://example.com/photos/protectores_de_pala.jpg",
                            ProductAmount = "60",
                            ProductDescription = "Protectores adhesivos para proteger el borde de la pala de golpes y roces. Fácil de colocar y resistente al desgaste. Paquete con 3 unidades.",
                            ProductPrice = 10.0
                        },
                        new
                        {
                            IdProduct = 20,
                            IdCategoria = 3,
                            NameProduct = "Cinta de Agarre ProFlex",
                            Photo = "https://example.com/photos/cinta_de_agarre_proflex.jpg",
                            ProductAmount = "30",
                            ProductDescription = "Cinta adhesiva para mejorar el agarre en el mango de la pala. Material antideslizante y resistente al desgaste. Rollo de 3 metros.",
                            ProductPrice = 7.0
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.Reserva", b =>
                {
                    b.Property<int>("IdReservation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReservation"));

                    b.Property<int>("IdSesion")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReservationPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UsuarioIdUser")
                        .HasColumnType("int");

                    b.HasKey("IdReservation");

                    b.HasIndex("IdSesion");

                    b.HasIndex("IdUser");

                    b.HasIndex("UsuarioIdUser");

                    b.ToTable("Reserva");

                    b.HasData(
                        new
                        {
                            IdReservation = 1,
                            IdSesion = 1,
                            IdUser = 1,
                            ReservationDate = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(6990),
                            ReservationPrice = "10"
                        },
                        new
                        {
                            IdReservation = 2,
                            IdSesion = 2,
                            IdUser = 2,
                            ReservationDate = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(6993),
                            ReservationPrice = "10"
                        },
                        new
                        {
                            IdReservation = 3,
                            IdSesion = 3,
                            IdUser = 3,
                            ReservationDate = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(6995),
                            ReservationPrice = "10"
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.Sesion", b =>
                {
                    b.Property<int>("IdSesion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSesion"));

                    b.Property<int>("IdPista")
                        .HasColumnType("int");

                    b.Property<DateTime>("SesionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SesionTime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSesion");

                    b.HasIndex("IdPista");

                    b.ToTable("Sesion");

                    b.HasData(
                        new
                        {
                            IdSesion = 1,
                            IdPista = 1,
                            SesionDate = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(7012),
                            SesionTime = "10:00"
                        },
                        new
                        {
                            IdSesion = 2,
                            IdPista = 2,
                            SesionDate = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(7014),
                            SesionTime = "12:00"
                        },
                        new
                        {
                            IdSesion = 3,
                            IdPista = 3,
                            SesionDate = new DateTime(2024, 6, 2, 18, 4, 11, 944, DateTimeKind.Local).AddTicks(7016),
                            SesionTime = "14:00"
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.Usuario", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdUser"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdPartido")
                        .HasColumnType("int");

                    b.Property<int>("IdProducto")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rol")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            IdUser = 1,
                            Email = "hola1@gmail.com",
                            IdPartido = 0,
                            IdProducto = 0,
                            Password = "123",
                            Rol = 1,
                            UserName = "cosmar"
                        },
                        new
                        {
                            IdUser = 2,
                            Email = "hola2@gmail.com",
                            IdPartido = 0,
                            IdProducto = 0,
                            Password = "123",
                            Rol = 2,
                            UserName = "cosmari"
                        },
                        new
                        {
                            IdUser = 3,
                            Email = "hola3@gmail.com",
                            IdPartido = 0,
                            IdProducto = 0,
                            Password = "123",
                            Rol = 2,
                            UserName = "cosmaro"
                        });
                });

            modelBuilder.Entity("TFGBackend.Models.UsuarioPartido", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int>("IdPartido")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Position")
                        .HasColumnType("int");

                    b.HasKey("IdUser", "IdPartido");

                    b.HasIndex("IdPartido");

                    b.ToTable("UsuarioPartidos");
                });

            modelBuilder.Entity("TFGBackend.Models.Compra", b =>
                {
                    b.HasOne("TFGBackend.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("IdProducto")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFGBackend.Models.Usuario", "Usuario")
                        .WithMany("Compras")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TFGBackend.Models.Reserva", b =>
                {
                    b.HasOne("TFGBackend.Models.Sesion", "Sesion")
                        .WithMany()
                        .HasForeignKey("IdSesion")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("TFGBackend.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TFGBackend.Models.Usuario", null)
                        .WithMany("Reserva")
                        .HasForeignKey("UsuarioIdUser");

                    b.Navigation("Sesion");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TFGBackend.Models.Sesion", b =>
                {
                    b.HasOne("TFGBackend.Models.Pista", "Pista")
                        .WithMany("Sesiones")
                        .HasForeignKey("IdPista")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pista");
                });

            modelBuilder.Entity("TFGBackend.Models.UsuarioPartido", b =>
                {
                    b.HasOne("TFGBackend.Models.Partido", "Partido")
                        .WithMany("UsuarioPartidos")
                        .HasForeignKey("IdPartido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TFGBackend.Models.Usuario", "Usuario")
                        .WithMany("UsuarioPartidos")
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Partido");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("TFGBackend.Models.Partido", b =>
                {
                    b.Navigation("UsuarioPartidos");
                });

            modelBuilder.Entity("TFGBackend.Models.Pista", b =>
                {
                    b.Navigation("Sesiones");
                });

            modelBuilder.Entity("TFGBackend.Models.Usuario", b =>
                {
                    b.Navigation("Compras");

                    b.Navigation("Reserva");

                    b.Navigation("UsuarioPartidos");
                });
#pragma warning restore 612, 618
        }
    }
}
