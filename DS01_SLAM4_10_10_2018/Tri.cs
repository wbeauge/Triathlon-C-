using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS01_SLAM4_10_10_2018
{
    class Tri
    {
        private Epreuve natation;
        private Epreuve velo;
        private Epreuve course;
        private List<Participant> lesParticipant;
        private string nature;

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("Natation", distanceNatation);
            this.velo = new Epreuve("Velo", distanceVelo);
            this.course = new Epreuve("Course", distanceCourse);
            lesParticipant = new List<Participant>();
        }

        public void AddParticipant(Participant unParticipant)
        { this.lesParticipant.Add(unParticipant); }

        public int GetDistanceTotal()
        {
            return (this.natation.GetDistance() + this.velo.GetDistance() + this.course.GetDistance());
        }

        public Epreuve GetEpreuve(string nomEpreuve) {
            switch (nomEpreuve)
            {
                case "Natation":
                    return this.natation;
                case "Velo":
                    return this.velo;
                default:
                    return this.course;
            }
        }

        public List<Participant> GetLesTemps() {
            List<Participant> enCours = new List<Participant>();
            foreach(Participant unParticipant in lesParticipant)
            {
                if (unParticipant.HorsDelai() == false)
                {
                    enCours.Add(unParticipant);
                }
            }
            return enCours;
        }

        public string GetNature() { return this.nature; }

        public Participant GetParticipantById(int id) {
            foreach(Participant unPartitcipant in lesParticipant)
            {
                if (unPartitcipant.GetId() == id)
                {
                    return unPartitcipant;
                }
            }
            return null;
        }
                

    }
}
