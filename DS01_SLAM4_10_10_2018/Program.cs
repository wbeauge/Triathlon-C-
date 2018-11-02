using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS01_SLAM4_10_10_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Tri ttiii = new Tri("XL", 20, 32, 45);

            DateTime date = DateTime.Parse("01/11/2018");
            Participant ppaa = new Participant("leo", date);
            ttiii.AddParticipant(ppaa);

            Epreuve eppleo = new Epreuve("natation", 220);
            ttiii.GetParticipantById(0).Add(eppleo,200);
            Epreuve eppleo1 = new Epreuve("velo", 800);
            ttiii.GetParticipantById(0).Add(eppleo1,800);
            Epreuve eppleo2 = new Epreuve("course", 400);
            ttiii.GetParticipantById(0).Add(eppleo2,400);

            DateTime datee = DateTime.Parse("01/01/2018");
            Participant ppaaa = new Participant("eol", date);

            ttiii.AddParticipant(ppaaa);
            Epreuve eppeol = new Epreuve("natation", 220);
            ttiii.GetParticipantById(1).Add(eppeol,220);
            Epreuve eppeol1 = new Epreuve("velo", 800);
            ttiii.GetParticipantById(1).Add(eppeol1,800);

            Epreuve epp = new Epreuve("natation", 220);
            Epreuve epp1 = new Epreuve("course", 400);
            Epreuve epp2 = new Epreuve("velo", 800);

            foreach(Resultat unResultat in ttiii.GetParticipantById(1).LesResultats)
            {
                if (ttiii.GetParticipantById(1).ResultatPresent(epp))
                {
                    Console.WriteLine("Le resultat est present");

                }
                else
                {


                    if (ttiii.GetParticipantById(1).ResultatPresent(epp1))
                    {
                        Console.WriteLine("Le resultat est present");

                    }
                    else
                    {
                        if (ttiii.GetParticipantById(1).ResultatPresent(epp2))
                        {
                            Console.WriteLine("Le resultat est present");

                        }
                        else
                        {
                            Console.WriteLine("Le resultat n'est present");
                        }
                    }
                }

                
            }

            if (ttiii.GetParticipantById(0).HorsDelai()) { Console.WriteLine("Vous etes hors delai"); } else { Console.WriteLine("Vous etes dans les temps"); }

            if (ttiii.GetParticipantById(1).HorsDelai()) { Console.WriteLine("Vous etes hors delai"); } else { Console.WriteLine("Vous etes dans les temps"); }

            Console.WriteLine(ttiii.GetParticipantById(1).GetId());

            Console.WriteLine(ttiii.GetParticipantById(0).GetId());

            Console.ReadLine();

        }
    }
}
