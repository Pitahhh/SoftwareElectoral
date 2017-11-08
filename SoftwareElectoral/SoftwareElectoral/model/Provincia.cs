using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Provincia {
        private int id;
        private String nombre;
        private int fk_region;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fk_region { get => fk_region; set => fk_region = value; }
    }
}