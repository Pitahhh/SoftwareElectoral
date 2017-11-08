using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftwareElectoral.model {
    public class Votacion {
        private int id;
        private Boolean votoBlanco;
        private Boolean votoNulo;
        private Boolean votoCandidato;
        private int fk_candidato;
        private int fk_persona;

        public int Id { get => id; set => id = value; }
        public bool VotoBlanco { get => votoBlanco; set => votoBlanco = value; }
        public bool VotoNulo { get => votoNulo; set => votoNulo = value; }
        public bool VotoCandidato { get => votoCandidato; set => votoCandidato = value; }
        public int Fk_candidato { get => fk_candidato; set => fk_candidato = value; }
        public int Fk_persona { get => fk_persona; set => fk_persona = value; }
    }
}