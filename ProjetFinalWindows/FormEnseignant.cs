using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetFinalWindows
{
    public partial class FormEnseignant : Form
    {
        public FormEnseignant()
        {
            InitializeComponent();
        }

        adoNET ado = new adoNET();



        public void Initialiser(bool b_nom, bool b_prenom, bool b_date, bool b_cours)
        {
            if (!b_nom) textBoxIDEnseigant.Text = "";
            if (!b_prenom) textBoxNomEnseignant.Text = "";
            if (!b_date) textBoxPrenomEnseignant.Text = "";
            if (!b_cours) comboBoxCoursEnseignant.SelectedIndex = -1;
            
        }
        public bool Verifier_RegexNom(string chaine)
        {
            Regex Reg = new Regex("^[A-Z]{1}[A-Za-z]{1,25}$");
            return Reg.IsMatch(chaine);
        }
        public bool Verifier_RegexNum(string chaine)
        {
            Regex Reg = new Regex("[0-9]{5}");
            return Reg.IsMatch(chaine);
        }


        public void Afficher_messages(bool b_num,bool b_nom, bool b_prenom, bool b_cours)
        {
            string s = "";
            if(b_num == false) s += "Le ID doit contenir 5 chiffre. \n";
            if (b_nom == false) s += "Le nom doit commencer par une majuscule suivie de 1 à 25 caractères. \n";
            if (b_prenom == false) s += "Le prénom doit commencer par une majuscule suivie de 1 à 25 caractères.\n";
            if (b_cours == false) s += "Il faut choisir le cours de l'enseignant. \n";
            MessageBox.Show(s, "Message(s) d'erreur");
        }





        private void FormEnseignant_Load(object sender, EventArgs e)
        {
            string Query = "Select * from Enseignant;";
            ado.Command.CommandText = Query;
            ado.Command.Connection = ado.Connection;
            ado.Adapter.SelectCommand = ado.Command;
            ado.Adapter.Fill(ado.DsScolarite);
            ado.DtEnseignant = ado.DsScolarite.Tables[0];
            this.dataGridViewEnseignat.DataSource = ado.DtEnseignant;
        }

        private void buttonAjouterEnseignant_Click(object sender, EventArgs e)
        {
            //Initialiser les booleens
            bool b_num = false;
            bool b_nom = false;
            bool b_prenom = false;
            bool b_cours = false;
            //Vérifier les contrôles et mettre le résultat dans les booleens
            if (Verifier_RegexNum(textBoxIDEnseigant.Text)) b_num = true;
            if (Verifier_RegexNom(textBoxNomEnseignant.Text)) b_nom = true;
            if (Verifier_RegexNom(textBoxPrenomEnseignant.Text)) b_prenom = true;
            if (comboBoxCoursEnseignant.SelectedIndex != -1) b_cours = true;
            //Tester les booleens
            //Si tous sont à vrai, instancier un objet Enseignant et l'ajouter la la liste statique listEnseignant
            //Et initialiser les contrôles
            if (b_num && b_nom && b_prenom && b_cours)
            {
                Enseignant Es = new Enseignant(int.Parse(textBoxIDEnseigant.Text), textBoxNomEnseignant.Text, textBoxPrenomEnseignant.Text, comboBoxCoursEnseignant.Text);
                ScolariteStats.ListEnseignant.Add(Es);
                DataRow UnEns = ado.DtEnseignant.NewRow();
                UnEns[0] = textBoxIDEnseigant.Text.Trim();
                UnEns[1] = textBoxNomEnseignant.Text.Trim();
                UnEns[2] = textBoxPrenomEnseignant.Text.Trim();
                UnEns[3] = comboBoxCoursEnseignant.Text.Trim();
                ado.DtEnseignant.Rows.Add(UnEns);
                MessageBox.Show("Ajout réussi !");
                Initialiser(!b_num, !b_nom, !b_prenom, !b_cours);
            }// Sinon afficher les messages d'erreur selectivement dans une MessageBox
             // et réinitialiser les contrôles
            else
            {
                Afficher_messages(b_num, b_nom, b_prenom, b_cours);
                Initialiser(b_num, b_nom, b_prenom, b_cours);
            }
        }

        private void buttonSauvegarderEnseignant_Click(object sender, EventArgs e)
        {
            try
            {
                // SqlCommandBuilder est la classe qui me permet de sauvegarder
                // dans une Base de données.
                //Son constructeur prend en paramètres le data adapter Adapter.
                SqlCommandBuilder builder = new SqlCommandBuilder(ado.Adapter);
                //Appeler la méthode Update de l’adapteur.
                //Elle prend en paramètres le DataSet, et le nom de la table.
                ado.Adapter.Update(ado.DsScolarite, ado.DtEnseignant.ToString());
                MessageBox.Show("Sauvegarde réussite !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSupprimerEnseignant_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ado.DtEnseignant.Rows.Count; i++)
            {
                if (textBoxRechercheEnseignant.Text == ado.DtEnseignant.Rows[i][0].ToString())
                {
                    ado.DtEnseignant.Rows[i].Delete();
                    MessageBox.Show("Suppression réussite !");
                    break;

                }
            }
        }

        private void buttonModifierEnseigant_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes de la table Ado.DtEtudiants
            for (int i = 0; i < ado.DtEnseignant.Rows.Count; i++)
            {
                //Trouver la ligne qui correspond au numéro étudiant entré par
                //l'utilisateur
                if (ado.DtEnseignant.Rows[i][0].ToString() == textBoxIDEnseigant.Text)
                {
                    //Apporter toutes les modifications sur tous les champs de la ligne
                    ado.DtEnseignant.Rows[i][1] = textBoxNomEnseignant.Text.Trim();
                    ado.DtEnseignant.Rows[i][2] = textBoxPrenomEnseignant.Text.Trim();
                    ado.DtEnseignant.Rows[i][3] = comboBoxCoursEnseignant.Text.Trim();
                    MessageBox.Show("Modification réussite !");
                }
            }
        }

        private void buttonRechercheEnseignant_Click(object sender, EventArgs e)
        {
            //Parcourir les lignes du DataTable DtEtudiants
            foreach (DataRow row in ado.DtEnseignant.Rows)
            {
                if (row[0].ToString() == textBoxRechercheEnseignant.Text)
                {
                    MessageBox.Show("Le numéro de l'Enseignant : " + row[0] + "\n"
                     + "Le cours enseigné : " + row[3] + "\n"
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
