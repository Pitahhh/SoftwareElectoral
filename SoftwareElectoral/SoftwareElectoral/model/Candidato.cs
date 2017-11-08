using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Candidato {
        private int id;
        private String nombre;
        private int fk_partida;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Fk_partida { get => fk_partida; set => fk_partida = value; }
    }
}