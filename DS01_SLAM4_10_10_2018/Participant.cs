using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS01_SLAM4_10_10_2018
{
    class Participant
    {
        private List<Resultat> lesResultats;
        private DateTime dateInscription;
        static private int lastId;
        private int id;
        private string nom;

        public Participant(string nom, DateTime dateInscription) {
            this.nom = nom;
            this.dateInscription = dateInscription;
            this.lesResultats = new List<Resultat>();
            this.id = lastId;
            lastId = lastId + 1;
        }

        public List<Resultat> LesResultats { get { return this.lesResultats; } }

        public void Add(Epreuve uneEpreuve, int tempsRealise) {
            if (ResultatPresent(uneEpreuve) == false)
            {
                Resultat unResultat = new Resultat(this, uneEpreuve, tempsRealise);
                lesResultats.Add(unResultat);
            }
        }

        public DateTime GetDateTime() { return this.dateInscription; }

        public int GetId() { return this.id; }

        public string GetNom() { return this.nom; }

        public int GetTempsTotal() {
            int totResultat = 0;
            foreach(Resultat unTesultat in lesResultats)
            {
                totResultat = totResultat + unTesultat.GetTempsRealise();
            }
            return totResultat;
        }

        public bool HorsDelai() {
            int i = 0;
            foreach (Resultat unTesultat in lesResultats)
            {
                if (i<3 && unTesultat.GetEpreuve().GetTempsEliminatoire()<unTesultat.GetTempsRealise()) {
                    return true;
                }
                i = i + 1;
            }
            return false;
        }

        public bool ResultatPresent(Epreuve uneEpreuve) {

            foreach (Resultat unTesultat in lesResultats)
            {
                if (unTesultat.GetEpreuve().GetNom() == uneEpreuve.GetNom()) { return true; }
            }
            return false;
        }


    }
}
