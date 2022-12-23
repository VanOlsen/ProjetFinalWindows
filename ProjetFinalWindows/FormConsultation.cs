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
    public partial class FormConsultation : Form
    {
        public FormConsultation()
        {
            InitializeComponent();
        }
        adoNET ado = new adoNET();
        private void FormConsultation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Query = ("Select nomEtudiant, prenomEtudiant from Etudiants where idEnseignant ='" + textBoxConsultation + "'");
            ado.Command.CommandText = Query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsScolarite);
            ado.DtEtudiant = ado.DsScolarite.Tables[0];
            this.dataGridViewConsultation.DataSource = ado.DtEtudiant;


        }
    }
}
