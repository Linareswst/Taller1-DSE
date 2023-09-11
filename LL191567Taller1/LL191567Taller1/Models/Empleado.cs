using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LL191567Taller1.Models
{
    public class Empleado
    {
        public int ID { get; set; }

        [RegularExpression(@"^E[0-9]{3}$", ErrorMessage ="El campo Codigo debe tener el formato EXXX")]
        [Required]
        public string Codigo { get; set; }

        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*)*$", ErrorMessage ="El campo Nombres solo admite texto")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Nombres { get; set; }

        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*)*$", ErrorMessage = "El campo Apellidos solo admite texto")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Apellidos { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(150, MinimumLength = 10)]
        public string Direccion { get; set; }

        [Display(Name ="Num. Telefono")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\d{4}-\d{4}$", ErrorMessage ="El campo Telefono debe tener el formato XXXX-XXXX")]
        [Required]
        public string Telefono { get; set; }

        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*)*$", ErrorMessage = "El campo Cargo solo admite texto")]
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Cargo { get; set; }

        [DataType(DataType.Currency)]
        [Required]
        [Range(1,1000000)]
        public decimal SueldoBase { get; set; }

        [Range(0, 35)]
        [Required]
        public int? AñosLaborados { get; set; }

        [Display(Name ="Calculo de Bono")]
        public decimal Bono { get; set; }

    }
    public class EmpleadoDBContext : DbContext
    {
        public DbSet<Empleado> Empleados { get; set; }
    }
}