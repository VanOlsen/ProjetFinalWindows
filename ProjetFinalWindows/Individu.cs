using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetFinalWindows
{
    public class Individu
    {
        //Attributs privés
        private int id;
        private string nom;
        private string prenom;

        // Méthodes d'Accès /  Accesseurs / propriétés

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }

        }
        //Le constructeur 
        public Individu(int i,string n, string p)
        {
            id = i;
            nom = n;
            prenom = p;
        }

    }
}
