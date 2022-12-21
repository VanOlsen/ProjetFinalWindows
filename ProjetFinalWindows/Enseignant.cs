using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProjetFinalWindows
{
    internal class Enseignant : Individu
    {
        private string cours;

        public string Cours
        {
            get { return cours; }
            set { cours = value; }
        }
        public Enseignant(int i, string n, string p, string c) : base(i, n, p)
        {
            cours = c;
        }

    }
}
