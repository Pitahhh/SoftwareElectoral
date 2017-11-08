using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Sector {
        private int id;
        private String descripcion;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}