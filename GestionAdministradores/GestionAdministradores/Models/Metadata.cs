using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GestionAdministradores.Models
{
    
        public class AdministradoresMetadata
        {
            [Required(ErrorMessage = "{0} es requerido")]
            [MaxLength(50, ErrorMessage = "{0} debe tener una longitud menor o igual a 50 caracteres")]
            [Display(Name = "Apellido")]
            public string Apellido { get; set; }

            [Required(ErrorMessage = "{0} es requerido")]
            [MaxLength(50, ErrorMessage = "{0} debe tener una longitud menor o igual a 50 caracteres")]
            [Display(Name = "Nombre")]
            public string Nombre { get; set; }

            [Required(ErrorMessage = "{0} es requerido")]
            [MinLength(9, ErrorMessage = "{0} debe tener una longitud igual a 9 digitos")]
            [MaxLength(9, ErrorMessage = "{0} debe tener una longitud igual a 9 digitos")]
            [Display(Name = "Dui")]
            public string Dui { get; set; }

            [Required(ErrorMessage = "{0} es requerido")]
            [MaxLength(10, ErrorMessage = "{0} debe tener una longitud menor o igual a 10 caracteres")]
            [Display(Name = "Genero")]
            public string Genero { get; set; }

            [Required(ErrorMessage = "{0} es requerida")]
            [MaxLength(50, ErrorMessage = "{0} debe tener una longitud menor o igual a 50 caracteres")]
            [Display(Name = "Direccion")]
            public string Direccion { get; set; }

            [Required(ErrorMessage ="{0} es requerido")]
            [MaxLength(8,ErrorMessage ="{0} debe tener una longitud menor o igual a 8 digitos")]
            [Display(Name = "Telefono")]
            public string Telefono { get; set; }

            [Required(ErrorMessage = "{0} es requerido")]
            [DataType(DataType.Date)]
            [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}",ApplyFormatInEditMode =true)]
            [Display(Name ="Fecha De Nacimiento")]
            public System.DateTime FechaDeNacimiento { get; set; }
    }

        
    }
