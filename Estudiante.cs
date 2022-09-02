using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace front
{
    public class Estudiante
    {
        [Key]
        public int id_estudiante { get; set; }
        //  [ForeignKey("CategoriaId")]
        public string name { get; set; }
        //[Required]
        //[MaxLength(200)]
        public string apellido { get; set; }
        public string email { get; set; }
        public string fecha_nacimiento { get; set; }
        public string cargo { get; set; }
        
    }
}
