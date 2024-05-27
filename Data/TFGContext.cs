using Microsoft.EntityFrameworkCore;
using TFGBackend.Models;
using System.Collections.Generic;

namespace TFGBackend.Data
{
    public class TFGContext : DbContext
    {
        public TFGContext(DbContextOptions<TFGContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            {
                modelBuilder.Entity<UsuarioPartido>()
                    .HasKey(up => new { up.IdUser, up.IdPartido });

                modelBuilder.Entity<UsuarioPartido>()
                    .HasOne(up => up.Usuario)
                    .WithMany(u => u.UsuarioPartidos)
                    .HasForeignKey(up => up.IdUser);

                modelBuilder.Entity<UsuarioPartido>()
                    .HasOne(up => up.Partido)
                    .WithMany(p => p.UsuarioPartidos)
                    .HasForeignKey(up => up.IdPartido);

                modelBuilder.Entity<Compra>()
                   .HasKey(c => c.IdCompra);

                modelBuilder.Entity<Compra>()
                    .HasOne(c => c.Usuario)
                    .WithMany(u => u.Compras)
                    .HasForeignKey(c => c.IdUser);

                modelBuilder.Entity<Compra>()
                    .HasOne(c => c.Producto)
                    .WithMany()
                    .HasForeignKey(c => c.IdProducto);
                modelBuilder.Entity<Reserva>()
                 .HasOne(r => r.Sesion)
                 .WithMany()
                 .HasForeignKey(r => r.IdSesion)
                 .OnDelete(DeleteBehavior.NoAction); 

                modelBuilder.Entity<Reserva>()
                    .HasOne(r => r.Usuario)
                    .WithMany()
                    .HasForeignKey(r => r.IdUser)
                    .OnDelete(DeleteBehavior.Restrict); 

            }

            modelBuilder.Entity<Producto>().HasData(
                new Producto { IdProduct = 1, Name_Product = "6 Pelotas Xtreme", Product_Price = "10", Product_Description = "Pelota capaz de durar más de 3 partidos, resistente a golpes bruscos, muy ligera", Product_Amount = "100", IdCategoria = 4 },

                new Producto { IdProduct = 2, Name_Product = "6 Pelotas ProFlight", Product_Price = "12", Product_Description = "Pelota diseñada para un vuelo estable y consistente. Construcción duradera para resistir largos rallies. Ideal para jugadores que buscan precisión en sus golpes.", Product_Amount = "100", IdCategoria = 4 },

                new Producto { IdProduct = 3, Name_Product = "6 Pelotas AirTech", Product_Price = "11", Product_Description = "Pelota con tecnología de cámara de aire para un rebote uniforme y predecible. Cubierta resistente que garantiza una larga durabilidad. Apta para todo tipo de superficies.", Product_Amount = "100", IdCategoria = 4 },

                new Producto { IdProduct = 4, Name_Product = "6 Pelotas PowerSpin", Product_Price = "13", Product_Description = "Pelota diseñada para generar mayor efecto en los golpes. Núcleo interno optimizado para aumentar el spin. Duradera y resistente a golpes.", Product_Amount = "180", IdCategoria = 4 },

                new Producto { IdProduct = 5, Name_Product = "6 Pelotas SpeedX", Product_Price = "10", Product_Description = "Pelota de alta velocidad para rallies rápidos. Superficie texturizada para un mejor agarre en la pista. Apta para jugadores de todos los niveles.", Product_Amount = "250", IdCategoria = 4 },

                // Bolsas de pádel
                new Producto { IdProduct = 6, Name_Product = "Bolsa ProTour", Product_Price = "50", Product_Description = "Bolsa de tamaño mediano con compartimentos para hasta 3 palas, pelotas y accesorios. Diseño ergonómico con correas ajustables para mayor comodidad.", Product_Amount = "20", IdCategoria = 5 },

                new Producto { IdProduct = 7, Name_Product = "Mochila PádelTech", Product_Price = "40", Product_Description = "Mochila resistente al agua con capacidad para 2 palas, pelotas, calzado y otros accesorios. Bolsillos laterales para botellas de agua.", Product_Amount = "15", IdCategoria = 5 },

                new Producto { IdProduct = 8, Name_Product = "Bolsa TravelMaster", Product_Price = "80", Product_Description = "Bolsa de viaje con ruedas para transportar todo el equipo de pádel de forma cómoda. Compartimento especial para palas y ropa.", Product_Amount = "8", IdCategoria = 5 },

                new Producto { IdProduct = 9, Name_Product = "Bolsa Elite Pro", Product_Price = "120", Product_Description = "Bolsa de alta gama con capacidad para 4 palas, compartimentos termoaislados para pelotas y ropa. Diseño elegante con detalles en cuero.", Product_Amount = "5", IdCategoria = 5 },

                new Producto { IdProduct = 10, Name_Product = "Bolsa Junior", Product_Price = "30", Product_Description = "Bolsa diseñada para niños con espacio para 1 pala, pelotas y otros accesorios. Diseño colorido y ligero.", Product_Amount = "12", IdCategoria = 5 },

                // Palas de pádel
                new Producto { IdProduct = 11, Name_Product = "Pala Pro Carbon", Product_Price = "150", Product_Description = "Pala de alto rendimiento con núcleo de carbono y forma de lágrima. Perfecta para jugadores avanzados. Potencia y control excepcionales.", Product_Amount = "25", IdCategoria = 1 },

                new Producto { IdProduct = 12, Name_Product = "Pala All-Round", Product_Price = "100", Product_Description = "Pala equilibrada para jugadores de nivel intermedio. Núcleo de goma EVA y forma redonda. Gran versatilidad en el juego.", Product_Amount = "30", IdCategoria = 1 },

                new Producto { IdProduct = 13, Name_Product = "Pala Junior", Product_Price = "70", Product_Description = "Pala diseñada específicamente para jóvenes jugadores. Ligera y fácil de manejar, con tecnología adaptada para el aprendizaje.", Product_Amount = "15", IdCategoria = 1 },

                new Producto { IdProduct = 14, Name_Product = "Pala PowerShot", Product_Price = "120", Product_Description = "Pala de potencia con forma de diamante. Amplio punto dulce y excelente salida de bola. Ideal para jugadores que buscan golpes agresivos.", Product_Amount = "20", IdCategoria = 1 },

                new Producto { IdProduct = 15, Name_Product = "Pala ControlMaster", Product_Price = "130", Product_Description = "Pala diseñada para un control preciso del juego. Forma redonda y balance neutro. Perfecta para jugadores que priorizan la precisión sobre la potencia.", Product_Amount = "18", IdCategoria = 1 },

                // Accesorios de pádel
                new Producto { IdProduct = 16, Name_Product = "Overgrip ProFeel", Product_Price = "5", Product_Description = "Overgrip de alta calidad para mejorar el agarre y absorber el sudor. Material duradero y cómodo. Disponible en varios colores.", Product_Amount = "50", IdCategoria = 3 },

                new Producto { IdProduct = 17, Name_Product = "Muñequera Profesional", Product_Price = "8", Product_Description = "Muñequera ajustable para proteger la muñeca durante el juego. Tejido transpirable que evita la acumulación de sudor. Disponible en diferentes tamaños.", Product_Amount = "40", IdCategoria = 3 },

                new Producto { IdProduct = 18, Name_Product = "Gorra PádelSport", Product_Price = "15", Product_Description = "Gorra deportiva con visera curvada para proteger del sol. Material ligero y transpirable. Diseño moderno con el logo de PádelSport.", Product_Amount = "35", IdCategoria = 3 },

                new Producto { IdProduct = 19, Name_Product = "Protectores de Pala", Product_Price = "10", Product_Description = "Protectores adhesivos para proteger el borde de la pala de golpes y roces. Fácil de colocar y resistente al desgaste. Paquete con 3 unidades.", Product_Amount = "60", IdCategoria = 3 },

                new Producto { IdProduct = 20, Name_Product = "Cinta de Agarre ProFlex", Product_Price = "7", Product_Description = "Cinta adhesiva para mejorar el agarre en el mango de la pala. Material antideslizante y resistente al desgaste. Rollo de 3 metros.", Product_Amount = "30", IdCategoria = 3 }
            );

            modelBuilder.Entity<Categoria>().HasData(
                new Categoria { IdCategoria = 1, Tipo_Categoria = "Palas de Padel" },
                new Categoria { IdCategoria = 2, Tipo_Categoria = "Ropa de Padel" },
                new Categoria { IdCategoria = 3, Tipo_Categoria = "Accesorios de Padel" },
                new Categoria { IdCategoria = 4, Tipo_Categoria = "Pelotas de Padel" },
                new Categoria { IdCategoria = 5, Tipo_Categoria = "Bolsas de Padel" }
            );
            modelBuilder.Entity<Pista>().HasData(
                new Pista { IdPista = 1, Name = "Pista 1", Description = "Pista 1", Photo = "photo1", Duration = "1 hora y 30 minutos", Price = 10, Date = System.DateTime.Now },
                new Pista { IdPista = 2, Name = "Pista 2", Description = "Pista 2", Photo = "photo2", Duration = "1 hora y 30 minutos", Price = 20, Date = System.DateTime.Now },
                new Pista { IdPista = 3, Name = "Pista 3", Description = "Pista 3", Photo = "photo3", Duration = "1 hora y 30 minutos", Price = 30, Date = System.DateTime.Now }
            );
            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { IdUser = 1, UserName = "cosmar", Password = "123", Email = "hola1@gmail.com", Rol = Usuario.UserRole.Admin },
                new Usuario { IdUser = 2, UserName = "cosmari", Password = "123", Email = "hola2@gmail.com", Rol = Usuario.UserRole.StandardUser },
                new Usuario { IdUser = 3, UserName = "cosmaro", Password = "123", Email = "hola3@gmail.com", Rol = Usuario.UserRole.StandardUser }
            );

            modelBuilder.Entity<Reserva>().HasData(
                new Reserva { IdReservation = 1, ReservationPrice = "10", ReservationDate = System.DateTime.Now,  IdUser = 1, IdSesion = 1 },
                new Reserva { IdReservation = 2, ReservationPrice = "10", ReservationDate = System.DateTime.Now,  IdUser = 2, IdSesion = 2 },
                new Reserva { IdReservation = 3, ReservationPrice = "10", ReservationDate = System.DateTime.Now,  IdUser = 3, IdSesion = 3 }
            );
            modelBuilder.Entity<Sesion>().HasData(
                new Sesion { IdSesion = 1, SesionTime = "10:00", IdPista = 1 },
                new Sesion { IdSesion = 2, SesionTime = "12:00", IdPista = 2 },
                new Sesion { IdSesion = 3, SesionTime = "14:00", IdPista = 3 }
            );
            modelBuilder.Entity<Partido>().HasData(
                new Partido { IdPartido = 1, Name = "Partido 1", Estrellas = "5", Photo = "photo1", Duration = "2 horas", Date = DateTime.Now, IdUser = 1 },
                new Partido { IdPartido = 2, Name = "Partido 2", Estrellas = "4", Photo = "photo2", Duration = "1 hora y 30 minutos", Date = DateTime.Now, IdUser = 2 },
                new Partido { IdPartido = 3, Name = "Partido 3", Estrellas = "4.5", Photo = "photo3", Duration = "2 horas", Date = DateTime.Now, IdUser = 3 }
            );

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Pista> Pista { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Sesion> Sesion { get; set; }

        public DbSet<Compra> Compras { get; set; }

        public DbSet<Partido> Partido { get; set; }

        public DbSet<UsuarioPartido> UsuarioPartidos { get; set; }


    }
}
