using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Partido {
        private int id;
        private String descripcion;
        private int fk_sector;

        public int Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Fk_sector { get => fk_sector; set => fk_sector = value; }
    }
}