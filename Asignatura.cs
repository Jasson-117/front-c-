using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace front
{
    public class Asignatura
    {
        [Key]
        public int id_asignatura { get; set; }
        public string name { get; set; }
    }
}