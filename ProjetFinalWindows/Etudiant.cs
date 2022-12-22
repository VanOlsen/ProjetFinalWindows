using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalWindows
{
    public class Etudiant : Individu
    {
        //Attributs privés
        private string anneenaiss;
        private int idEnseigant;

        //Méthode d'accès / accesseurs / Propriétés
        public string AnneeNais
        {
            get { return anneenaiss; }
            set { anneenaiss = value; }
        }
        public int IdEnseigant
        {
            get { return idEnseigant; }
        }

        public Etudiant(int i, string n, string p, string a, int ens): base(i, n, p)
        {
            anneenaiss = a;
            idEnseigant = ens;
        }


    }
    
}
