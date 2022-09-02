using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace front
{
    public class Notas
    {
        [Key]
        public int id_notas { get; set; }
        public int id_estudiante { get; set; }
        public int id_asignatura { get; set; }
        public string nombre_asignatura { get; set; }  
        public decimal nota1 { get; set; }
        public decimal nota2 { get; set; }
        public decimal nota3 { get; set; }
        public decimal definitiva { get; set; }
    }
}