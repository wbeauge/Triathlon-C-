using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS01_SLAM4_10_10_2018
{
    class Resultat
    {
        private Epreuve uneEpreuve;
        private Participant unParticipant;
        private int tempsRealise;

        public Resultat(Participant unParticipant, Epreuve uneEpreuve, int tempsRealise) {
            this.uneEpreuve = uneEpreuve;
            this.unParticipant = unParticipant;
            this.tempsRealise = tempsRealise;
        }

        public Epreuve GetEpreuve() { return this.uneEpreuve; }

        public int GetTempsRealise() { return this.tempsRealise; }
    }
}
