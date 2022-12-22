namespace ProjetFinalWindows
{
    partial class FormAjouterÉtudiant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Étudiantid = new System.Windows.Forms.Label();
            this.label_prenom = new System.Windows.Forms.Label();
            this.label_nom = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.textBox_Prenom = new System.Windows.Forms.TextBox();
            this.label_DateNaisaance = new System.Windows.Forms.Label();
            this.groupBox_Opération = new System.Windows.Forms.GroupBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewEtudiant = new System.Windows.Forms.DataGridView();
            this.dateNaissancePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.buttonRecherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEnsAssign = new System.Windows.Forms.TextBox();
            this.groupBox_Opération.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Étudiantid
            // 
            this.label_Étudiantid.AutoSize = true;
            this.label_Étudiantid.Location = new System.Drawing.Point(48, 50);
            this.label_Étudiantid.Name = "label_Étudiantid";
            this.label_Étudiantid.Size = new System.Drawing.Size(60, 13);
            this.label_Étudiantid.TabIndex = 0;
            this.label_Étudiantid.Text = "ID Étudiant";
            // 
            // label_prenom
            // 
            this.label_prenom.AutoSize = true;
            this.label_prenom.Location = new System.Drawing.Point(37, 92);
            this.label_prenom.Name = "label_prenom";
            this.label_prenom.Size = new System.Drawing.Size(71, 13);
            this.label_prenom.TabIndex = 1;
            this.label_prenom.Text = "Nom Étudiant";
            // 
            // label_nom
            // 
            this.label_nom.AutoSize = true;
            this.label_nom.Location = new System.Drawing.Point(23, 136);
            this.label_nom.Name = "label_nom";
            this.label_nom.Size = new System.Drawing.Size(85, 13);
            this.label_nom.TabIndex = 2;
            this.label_nom.Text = "Prenom Étudiant";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(114, 47);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 20);
            this.textBox_ID.TabIndex = 3;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(114, 89);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 4;
            // 
            // textBox_Prenom
            // 
            this.textBox_Prenom.Location = new System.Drawing.Point(114, 133);
            this.textBox_Prenom.Name = "textBox_Prenom";
            this.textBox_Prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Prenom.TabIndex = 5;
            // 
            // label_DateNaisaance
            // 
            this.label_DateNaisaance.AutoSize = true;
            this.label_DateNaisaance.Location = new System.Drawing.Point(10, 179);
            this.label_DateNaisaance.Name = "label_DateNaisaance";
            this.label_DateNaisaance.Size = new System.Drawing.Size(98, 13);
            this.label_DateNaisaance.TabIndex = 8;
            this.label_DateNaisaance.Text = "Date de Naissance";
            // 
            // groupBox_Opération
            // 
            this.groupBox_Opération.Controls.Add(this.buttonAjouter);
            this.groupBox_Opération.Controls.Add(this.buttonModifier);
            this.groupBox_Opération.Controls.Add(this.buttonSupprimer);
            this.groupBox_Opération.Controls.Add(this.buttonSave);
            this.groupBox_Opération.Location = new System.Drawing.Point(12, 294);
            this.groupBox_Opération.Name = "groupBox_Opération";
            this.groupBox_Opération.Size = new System.Drawing.Size(726, 83);
            this.groupBox_Opération.TabIndex = 10;
            this.groupBox_Opération.TabStop = false;
            this.groupBox_Opération.Text = "Opérations";
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(39, 31);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(132, 32);
            this.buttonAjouter.TabIndex = 6;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(222, 31);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(132, 32);
            this.buttonModifier.TabIndex = 5;
            this.buttonModifier.Text = "Modifer";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(400, 31);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(132, 32);
            this.buttonSupprimer.TabIndex = 4;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(575, 31);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(132, 32);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Sauvegarder";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewEtudiant
            // 
            this.dataGridViewEtudiant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEtudiant.Location = new System.Drawing.Point(263, 47);
            this.dataGridViewEtudiant.Name = "dataGridViewEtudiant";
            this.dataGridViewEtudiant.Size = new System.Drawing.Size(443, 214);
            this.dataGridViewEtudiant.TabIndex = 11;
            // 
            // dateNaissancePicker
            // 
            this.dateNaissancePicker.Location = new System.Drawing.Point(114, 173);
            this.dateNaissancePicker.Name = "dateNaissancePicker";
            this.dateNaissancePicker.Size = new System.Drawing.Size(143, 20);
            this.dateNaissancePicker.TabIndex = 12;
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(13, 418);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(100, 20);
            this.textBoxRecherche.TabIndex = 13;
            // 
            // buttonRecherche
            // 
            this.buttonRecherche.Location = new System.Drawing.Point(120, 418);
            this.buttonRecherche.Name = "buttonRecherche";
            this.buttonRecherche.Size = new System.Drawing.Size(75, 23);
            this.buttonRecherche.TabIndex = 14;
            this.buttonRecherche.Text = "Recherche";
            this.buttonRecherche.UseVisualStyleBackColor = true;
            this.buttonRecherche.Click += new System.EventHandler(this.buttonRecherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enseignant ID";
            // 
            // textBoxEnsAssign
            // 
            this.textBoxEnsAssign.Location = new System.Drawing.Point(114, 209);
            this.textBoxEnsAssign.Name = "textBoxEnsAssign";
            this.textBoxEnsAssign.Size = new System.Drawing.Size(143, 20);
            this.textBoxEnsAssign.TabIndex = 16;
            // 
            // FormAjouterÉtudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxEnsAssign);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRecherche);
            this.Controls.Add(this.textBoxRecherche);
            this.Controls.Add(this.dateNaissancePicker);
            this.Controls.Add(this.dataGridViewEtudiant);
            this.Controls.Add(this.groupBox_Opération);
            this.Controls.Add(this.label_DateNaisaance);
            this.Controls.Add(this.textBox_Prenom);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label_nom);
            this.Controls.Add(this.label_prenom);
            this.Controls.Add(this.label_Étudiantid);
            this.Name = "FormAjouterÉtudiant";
            this.Text = "Étudiant";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormAjouterÉtudiant_Load);
            this.groupBox_Opération.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEtudiant)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Étudiantid;
        private System.Windows.Forms.Label label_prenom;
        private System.Windows.Forms.Label label_nom;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.TextBox textBox_Prenom;
        private System.Windows.Forms.Label label_DateNaisaance;
        private System.Windows.Forms.GroupBox groupBox_Opération;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewEtudiant;
        private System.Windows.Forms.DateTimePicker dateNaissancePicker;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.Button buttonRecherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEnsAssign;
    }
}

