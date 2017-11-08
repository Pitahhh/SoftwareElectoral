using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Region {
        private int id;
        private String nombre;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}