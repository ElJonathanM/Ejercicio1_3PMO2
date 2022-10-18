using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_3PMO2.Models
{
    public class Persona
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(100)]
        public String nombre { get; set; }

        [MaxLength(100)]
        public String apellidos { get; set; }

        public int edad { get; set; }

        public String correo { get; set; }

        public String direccion { get; set; }
    }
}
