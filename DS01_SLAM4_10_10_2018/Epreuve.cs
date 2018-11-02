using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS01_SLAM4_10_10_2018
{
    class Epreuve
    {
        private int distance;
        private string nom;
        private int tempsEliminatoire;

        public Epreuve(string nom, int distance)
        {
            this.nom = nom;
            this.distance = distance;
        }

        public int GetDistance() { return this.distance; }

        public int GetTempsEliminatoire() { return this.tempsEliminatoire; }

        public string GetNom() { return this.nom; }

        public void SetTempsEliminatoire(int tempsEliminatoire) { this.tempsEliminatoire = tempsEliminatoire; }
    }
}
