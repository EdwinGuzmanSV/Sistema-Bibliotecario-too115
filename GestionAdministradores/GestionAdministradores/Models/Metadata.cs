using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System;
using System.ComponentModel.DataAnnotations;

namespace GestionAdministradores.Models
{
    
        public class AdministradoresMetadata
        {
            [StringLength(50)]
            [Display(Name = "Apellido")]
            public string Apellido;

            [StringLength(50)]
            [Display(Name = "Nombre")]
            public string Nombre;

            [StringLength(9)]
            [Display(Name = "Dui")]
            public string Dui;

            [StringLength(10)]
            [Display(Name = "Fecha De Nacimiento")]
            public string FechaDeNacimiento;

            [StringLength(15)]
            [Display(Name = "Genero")]
            public string Genero;

            [StringLength(50)]
            [Display(Name = "Direccion")]
            public string Direccion;

            [StringLength(8)]
            [Display(Name = "Telefono")]
            public string Telefono;
    }

        
    }
