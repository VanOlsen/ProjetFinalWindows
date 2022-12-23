using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetFinalWindows
{
    public partial class FormAjouterÉtudiant : Form
    {
        public FormAjouterÉtudiant()
        {
            InitializeComponent();

        }





        adoNET ado = new adoNET();





        public bool Age(DateTime dateNaissance)
        {
            int age = DateTime.Now.Year - dateNaissance.Year;
            //Diminuer l'age de un si la date d'anniversaire n'est pas encore arrivée
            if (DateTime.Now.Month < dateNaissance.Month || (DateTime.Now.Month == dateNaissance.Month && DateTime.Now.Day < dateNaissance.Day))
                age--;
            if (age >= 17) return true;
            else return false;
        }

        private void FormAjouterÉtudiant_Load(object sender, EventArgs e)
        {
            
            string Query = "Select * from Etudiants;";
            ado.Command.CommandText = Query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsScolarite);
            ado.DtEtudiant = ado.DsScolarite.Tables[0];
            this.dataGridViewEtudiant.DataSource = ado.DtEtudiant;
          

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
             
            DataRow UnEtudiant = ado.DtEtudiant.NewRow();
            UnEtudiant[0] = textBox_ID.Text.Trim();
            UnEtudiant[1] = textBox_Nom.Text.Trim();
            UnEtudiant[2] = textBox_Prenom.Text.Trim();
            UnEtudiant[3] = dateNaissancePicker.Value.Year.ToString().Trim();
            UnEtudiant[4] = textBoxEnsAssign.Text.Trim();
            ado.DtEtudiant.Rows.Add(UnEtudiant);
            MessageBox.Show("Ajout réussi !");


        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder
                // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter.
                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.
                ado.Adapter.Update(ado.DsScolarite, ado.DtEtudiant.ToString());
                MessageBox.Show("Sauvegarde réussite !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ado.DtEtudiant.Rows.Count; i++)
            {
                if(textBoxRecherche.Text == ado.DtEtudiant.Rows[i][0].ToString())
                {
                    ado.DtEtudiant.Rows[i].Delete();
                    MessageBox.Show("Suppression réussite !");
                    break;

                }
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes de la table Ado.DtEtudiants
            for (int i = 0; i < ado.DtEtudiant.Rows.Count; i++)
            {
                //Trouver la ligne qui correspond au numéro étudiant entré par
                //l'utilisateur
                if (ado.DtEtudiant.Rows[i][0].ToString() == textBox_ID.Text)
                {
                    //Apporter toutes les modifications sur tous les champs de la ligne
                    ado.DtEtudiant.Rows[i][1] = textBox_Nom.Text.Trim();
                    ado.DtEtudiant.Rows[i][2] = textBox_Prenom.Text.Trim();
                    ado.DtEtudiant.Rows[i][3] = dateNaissancePicker.Value.Year.ToString().Trim();
                    ado.DtEtudiant.Rows[i][4] = textBoxEnsAssign.Text.Trim();
                    MessageBox.Show("Modification réussite !");
                }
            }

        }

        private void buttonRecherche_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes du DataTable DtEtudiants
            foreach (DataRow row in ado.DtEtudiant.Rows)
            {
                if (row[0].ToString() == textBoxRecherche.Text)
                {
                    MessageBox.Show("Le numéro de l'étudiant : " + row[0] + "\n"
                     + "Le nom de l'étudiant : " + row[1] + "\n"
                     + "Le prénom de l'étudiant : " + row[2] +
                    "\n", "Résultat de la recherche", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Non trouvé");
                }

            }
        }
    }
}
