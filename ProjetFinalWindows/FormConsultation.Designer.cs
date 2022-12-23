namespace ProjetFinalWindows
{
    partial class FormConsultation
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
            this.textBoxConsultation = new System.Windows.Forms.TextBox();
            this.labelConsultion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewConsultation = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultation)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxConsultation
            // 
            this.textBoxConsultation.Location = new System.Drawing.Point(300, 84);
            this.textBoxConsultation.Name = "textBoxConsultation";
            this.textBoxConsultation.Size = new System.Drawing.Size(100, 20);
            this.textBoxConsultation.TabIndex = 0;
            // 
            // labelConsultion
            // 
            this.labelConsultion.AutoSize = true;
            this.labelConsultion.Location = new System.Drawing.Point(300, 42);
            this.labelConsultion.Name = "labelConsultion";
            this.labelConsultion.Size = new System.Drawing.Size(100, 13);
            this.labelConsultion.TabIndex = 1;
            this.labelConsultion.Text = "Numéro Enseignant";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Afficher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewConsultation
            // 
            this.dataGridViewConsultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultation.Location = new System.Drawing.Point(239, 110);
            this.dataGridViewConsultation.Name = "dataGridViewConsultation";
            this.dataGridViewConsultation.Size = new System.Drawing.Size(240, 271);
            this.dataGridViewConsultation.TabIndex = 4;
            // 
            // FormConsultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewConsultation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelConsultion);
            this.Controls.Add(this.textBoxConsultation);
            this.Name = "FormConsultation";
            this.Text = "FormConsultation";
            this.Load += new System.EventHandler(this.FormConsultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConsultation;
        private System.Windows.Forms.Label labelConsultion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewConsultation;
    }
}