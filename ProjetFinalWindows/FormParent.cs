using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalWindows
{
    public partial class FormParent : Form
    {
        public FormParent()
        {
            InitializeComponent();
        }

        private void enseignantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnseignant form = new FormEnseignant();
            form.MdiParent = this;
            form.Show();

        }

        private void étudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAjouterÉtudiant form = new FormAjouterÉtudiant();
            form.MdiParent = this;
            form.Show();
        }

        private void consultationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConsultation form = new FormConsultation();
            form.MdiParent = this;
            form.Show();
        }
    }
}
