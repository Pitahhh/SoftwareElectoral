using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Persona {
        private int id;
        private String rut;
        private String nombre;
        private int edad;
        private int fk_genero;
        private int fk_comuna;

        public int Id { get => id; set => id = value; }
        public string Rut { get => rut; set => rut = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Fk_genero { get => fk_genero; set => fk_genero = value; }
        public int Fk_comuna { get => fk_comuna; set => fk_comuna = value; }
    }
}