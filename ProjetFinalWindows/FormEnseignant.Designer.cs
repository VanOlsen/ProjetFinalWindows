namespace ProjetFinalWindows
{
    partial class FormEnseignant
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIDEnseigant = new System.Windows.Forms.TextBox();
            this.textBoxNomEnseignant = new System.Windows.Forms.TextBox();
            this.textBoxPrenomEnseignant = new System.Windows.Forms.TextBox();
            this.comboBoxCoursEnseignant = new System.Windows.Forms.ComboBox();
            this.dataGridViewEnseignat = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAjouterEnseignant = new System.Windows.Forms.Button();
            this.buttonModifierEnseigant = new System.Windows.Forms.Button();
            this.buttonSupprimerEnseignant = new System.Windows.Forms.Button();
            this.buttonSauvegarderEnseignant = new System.Windows.Forms.Button();
            this.textBoxRechercheEnseignant = new System.Windows.Forms.TextBox();
            this.buttonRechercheEnseignant = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnseignat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Enseignant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Enseignant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom Enseignant";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cours ";
            // 
            // textBoxIDEnseigant
            // 
            this.textBoxIDEnseigant.Location = new System.Drawing.Point(131, 60);
            this.textBoxIDEnseigant.Name = "textBoxIDEnseigant";
            this.textBoxIDEnseigant.Size = new System.Drawing.Size(100, 20);
            this.textBoxIDEnseigant.TabIndex = 4;
            // 
            // textBoxNomEnseignant
            // 
            this.textBoxNomEnseignant.Location = new System.Drawing.Point(131, 105);
            this.textBoxNomEnseignant.Name = "textBoxNomEnseignant";
            this.textBoxNomEnseignant.Size = new System.Drawing.Size(100, 20);
            this.textBoxNomEnseignant.TabIndex = 5;
            // 
            // textBoxPrenomEnseignant
            // 
            this.textBoxPrenomEnseignant.Location = new System.Drawing.Point(131, 152);
            this.textBoxPrenomEnseignant.Name = "textBoxPrenomEnseignant";
            this.textBoxPrenomEnseignant.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrenomEnseignant.TabIndex = 6;
            // 
            // comboBoxCoursEnseignant
            // 
            this.comboBoxCoursEnseignant.FormattingEnabled = true;
            this.comboBoxCoursEnseignant.Items.AddRange(new object[] {
            "Programmation",
            "Philosophie",
            "Anglais",
            "Français",
            "Art",
            "Éducation Physique",
            "Géographie",
            "Science"});
            this.comboBoxCoursEnseignant.Location = new System.Drawing.Point(131, 194);
            this.comboBoxCoursEnseignant.Name = "comboBoxCoursEnseignant";
            this.comboBoxCoursEnseignant.Size = new System.Drawing.Size(172, 21);
            this.comboBoxCoursEnseignant.TabIndex = 7;
            // 
            // dataGridViewEnseignat
            // 
            this.dataGridViewEnseignat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEnseignat.Location = new System.Drawing.Point(309, 60);
            this.dataGridViewEnseignat.Name = "dataGridViewEnseignat";
            this.dataGridViewEnseignat.Size = new System.Drawing.Size(479, 155);
            this.dataGridViewEnseignat.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSauvegarderEnseignant);
            this.groupBox1.Controls.Add(this.buttonSupprimerEnseignant);
            this.groupBox1.Controls.Add(this.buttonModifierEnseigant);
            this.groupBox1.Controls.Add(this.buttonAjouterEnseignant);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 259);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(771, 71);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opérations";
            // 
            // buttonAjouterEnseignant
            // 
            this.buttonAjouterEnseignant.Location = new System.Drawing.Point(25, 30);
            this.buttonAjouterEnseignant.Name = "buttonAjouterEnseignant";
            this.buttonAjouterEnseignant.Size = new System.Drawing.Size(101, 35);
            this.buttonAjouterEnseignant.TabIndex = 0;
            this.buttonAjouterEnseignant.Text = "Ajouter";
            this.buttonAjouterEnseignant.UseVisualStyleBackColor = true;
            this.buttonAjouterEnseignant.Click += new System.EventHandler(this.buttonAjouterEnseignant_Click);
            // 
            // buttonModifierEnseigant
            // 
            this.buttonModifierEnseigant.Location = new System.Drawing.Point(238, 30);
            this.buttonModifierEnseigant.Name = "buttonModifierEnseigant";
            this.buttonModifierEnseigant.Size = new System.Drawing.Size(92, 35);
            this.buttonModifierEnseigant.TabIndex = 1;
            this.buttonModifierEnseigant.Text = "Modifier";
            this.buttonModifierEnseigant.UseVisualStyleBackColor = true;
            this.buttonModifierEnseigant.Click += new System.EventHandler(this.buttonModifierEnseigant_Click);
            // 
            // buttonSupprimerEnseignant
            // 
            this.buttonSupprimerEnseignant.Location = new System.Drawing.Point(448, 30);
            this.buttonSupprimerEnseignant.Name = "buttonSupprimerEnseignant";
            this.buttonSupprimerEnseignant.Size = new System.Drawing.Size(87, 35);
            this.buttonSupprimerEnseignant.TabIndex = 2;
            this.buttonSupprimerEnseignant.Text = "Supprimer";
            this.buttonSupprimerEnseignant.UseVisualStyleBackColor = true;
            this.buttonSupprimerEnseignant.Click += new System.EventHandler(this.buttonSupprimerEnseignant_Click);
            // 
            // buttonSauvegarderEnseignant
            // 
            this.buttonSauvegarderEnseignant.Location = new System.Drawing.Point(644, 30);
            this.buttonSauvegarderEnseignant.Name = "buttonSauvegarderEnseignant";
            this.buttonSauvegarderEnseignant.Size = new System.Drawing.Size(86, 35);
            this.buttonSauvegarderEnseignant.TabIndex = 3;
            this.buttonSauvegarderEnseignant.Text = "Sauvegarder";
            this.buttonSauvegarderEnseignant.UseVisualStyleBackColor = true;
            this.buttonSauvegarderEnseignant.Click += new System.EventHandler(this.buttonSauvegarderEnseignant_Click);
            // 
            // textBoxRechercheEnseignant
            // 
            this.textBoxRechercheEnseignant.Location = new System.Drawing.Point(42, 380);
            this.textBoxRechercheEnseignant.Name = "textBoxRechercheEnseignant";
            this.textBoxRechercheEnseignant.Size = new System.Drawing.Size(100, 20);
            this.textBoxRechercheEnseignant.TabIndex = 10;
            // 
            // buttonRechercheEnseignant
            // 
            this.buttonRechercheEnseignant.Location = new System.Drawing.Point(148, 380);
            this.buttonRechercheEnseignant.Name = "buttonRechercheEnseignant";
            this.buttonRechercheEnseignant.Size = new System.Drawing.Size(117, 23);
            this.buttonRechercheEnseignant.TabIndex = 11;
            this.buttonRechercheEnseignant.Text = "Recherche";
            this.buttonRechercheEnseignant.UseVisualStyleBackColor = true;
            this.buttonRechercheEnseignant.Click += new System.EventHandler(this.buttonRechercheEnseignant_Click);
            // 
            // FormEnseignant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRechercheEnseignant);
            this.Controls.Add(this.textBoxRechercheEnseignant);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewEnseignat);
            this.Controls.Add(this.comboBoxCoursEnseignant);
            this.Controls.Add(this.textBoxPrenomEnseignant);
            this.Controls.Add(this.textBoxNomEnseignant);
            this.Controls.Add(this.textBoxIDEnseigant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEnseignant";
            this.Text = "FormEnseignant";
            this.Load += new System.EventHandler(this.FormEnseignant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEnseignat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDEnseigant;
        private System.Windows.Forms.TextBox textBoxNomEnseignant;
        private System.Windows.Forms.TextBox textBoxPrenomEnseignant;
        private System.Windows.Forms.ComboBox comboBoxCoursEnseignant;
        private System.Windows.Forms.DataGridView dataGridViewEnseignat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonSauvegarderEnseignant;
        private System.Windows.Forms.Button buttonSupprimerEnseignant;
        private System.Windows.Forms.Button buttonModifierEnseigant;
        private System.Windows.Forms.Button buttonAjouterEnseignant;
        private System.Windows.Forms.TextBox textBoxRechercheEnseignant;
        private System.Windows.Forms.Button buttonRechercheEnseignant;
    }
}