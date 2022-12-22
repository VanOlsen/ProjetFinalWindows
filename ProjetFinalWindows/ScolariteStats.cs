using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalWindows
{
    static class ScolariteStats
    {
        //Attribut privé
        private static List<Etudiant> listEtudiants;
        private static List<Enseignant> listEnseignant;
        //Méthode d'accès
        public static List<Etudiant> ListEtudiants
        {
            get { return listEtudiants; }
            set { listEtudiants = value; }
        }
        public static List<Enseignant> ListEnseignant
        {
            get { return listEnseignant; }
            set { listEnseignant = value; }
        }
        //Constructeur 
        static ScolariteStats()
        {
            listEtudiants = new List<Etudiant>();
            listEnseignant = new List<Enseignant>();
        }
        //Méthodes

        public static int compterEtudiants()
        {
            return listEtudiants.Count;
        }

        public static int CompterEnseignantCours(string programme)
        {
            int result = 0;
            foreach (Enseignant e in listEnseignant)
                if (e.Cours == programme ) result++;
            return result;
        }
    }
}
