using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Comuna {
        private int id;
        private String nombre;
        private int fk_provincia;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fk_provincia { get => fk_provincia; set => fk_provincia = value; }
    }
}