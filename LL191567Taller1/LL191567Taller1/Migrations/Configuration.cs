namespace LL191567Taller1.Migrations
{
    using LL191567Taller1.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LL191567Taller1.Models.EmpleadoDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LL191567Taller1.Models.EmpleadoDBContext context)
        {
            context.Empleados.AddOrUpdate(i => i.Codigo,
                new Empleado
                {
                    Codigo = "E001",
                    Nombres = "Juan Carlos",
                    Apellidos = "Lopez Gonzalez",
                    FechaNacimiento = DateTime.Parse("1990-05-15"),
                    Direccion = "123 Calle Principal, Ciudad",
                    Telefono = "5555-1234",
                    Cargo = "Gerente de Ventas",
                    SueldoBase = 50000,
                    AñosLaborados = 5
                },
                new Empleado
                {
                    Codigo = "E002",
                    Nombres = "Maria Elena",
                    Apellidos = "Rodriguez Perez",
                    FechaNacimiento = DateTime.Parse("1985-08-20"),
                    Direccion = "456 Avenida Central, Pueblo",
                    Telefono = "5555-5678",
                    Cargo = "Analista de Marketing",
                    SueldoBase = 40000,
                    AñosLaborados = 3
                },
                new Empleado
                {
                    Codigo = "E003",
                    Nombres = "Pedro Antonio",
                    Apellidos = "García Ramirez",
                    FechaNacimiento = DateTime.Parse("1992-03-10"),
                    Direccion = "789 Calle Secundaria, Villa",
                    Telefono = "5555-9876",
                    Cargo = "Desarrollador de Software",
                    SueldoBase = 55000,
                    AñosLaborados = 4
                },
                new Empleado
                {
                    Codigo = "E004",
                    Nombres = "Ana Isabel",
                    Apellidos = "Martinez Lopez",
                    FechaNacimiento = DateTime.Parse("1988-12-05"),
                    Direccion = "101 Calle Residencial, Ciudad",
                    Telefono = "5555-4321",
                    Cargo = "Contadora",
                    SueldoBase = 48000,
                    AñosLaborados = 6
                },
                new Empleado
                {
                    Codigo = "E005",
                    Nombres = "Luis Alberto",
                    Apellidos = "Perez Gomez",
                    FechaNacimiento = DateTime.Parse("1994-07-25"),
                    Direccion = "222 Avenida Principal, Pueblo",
                    Telefono = "5555-3456",
                    Cargo = "Técnico de Soporte",
                    SueldoBase = 42000,
                    AñosLaborados = 1
                }
                );
        }
    }
}
