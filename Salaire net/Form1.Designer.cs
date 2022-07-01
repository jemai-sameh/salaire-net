namespace Salaire_net
{
    partial class FormSalaireNet
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCalcule = new System.Windows.Forms.Button();
            this.checkPrime = new System.Windows.Forms.CheckBox();
            this.comboAssurance = new System.Windows.Forms.ComboBox();
            this.comboCotisation = new System.Windows.Forms.ComboBox();
            this.comboRetraite = new System.Windows.Forms.ComboBox();
            this.labelRetraite = new System.Windows.Forms.Label();
            this.labelCotisation = new System.Windows.Forms.Label();
            this.labelAssurance = new System.Windows.Forms.Label();
            this.labelSalaireBrut = new System.Windows.Forms.Label();
            this.labelSalaireNet = new System.Windows.Forms.Label();
            this.labelResultatSalaireNet = new System.Windows.Forms.Label();
            this.textSalaireBrut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCalcule
            // 
            this.buttonCalcule.Location = new System.Drawing.Point(322, 238);
            this.buttonCalcule.Name = "buttonCalcule";
            this.buttonCalcule.Size = new System.Drawing.Size(159, 23);
            this.buttonCalcule.TabIndex = 0;
            this.buttonCalcule.Text = "Calculer salaire net";
            this.buttonCalcule.UseVisualStyleBackColor = true;
            this.buttonCalcule.Click += new System.EventHandler(this.buttonCalcule_Click);
            // 
            // checkPrime
            // 
            this.checkPrime.AutoSize = true;
            this.checkPrime.Location = new System.Drawing.Point(184, 216);
            this.checkPrime.Name = "checkPrime";
            this.checkPrime.Size = new System.Drawing.Size(120, 17);
            this.checkPrime.TabIndex = 1;
            this.checkPrime.Text = "Prime de rendement";
            this.checkPrime.UseVisualStyleBackColor = true;
            // 
            // comboAssurance
            // 
            this.comboAssurance.FormattingEnabled = true;
            this.comboAssurance.Location = new System.Drawing.Point(407, 92);
            this.comboAssurance.Name = "comboAssurance";
            this.comboAssurance.Size = new System.Drawing.Size(121, 21);
            this.comboAssurance.TabIndex = 2;
            this.comboAssurance.SelectedIndexChanged += new System.EventHandler(this.comboAssurance_SelectedIndexChanged);
            // 
            // comboCotisation
            // 
            this.comboCotisation.FormattingEnabled = true;
            this.comboCotisation.Location = new System.Drawing.Point(407, 133);
            this.comboCotisation.Name = "comboCotisation";
            this.comboCotisation.Size = new System.Drawing.Size(121, 21);
            this.comboCotisation.TabIndex = 3;
            this.comboCotisation.SelectedIndexChanged += new System.EventHandler(this.comboCotisation_SelectedIndexChanged);
            // 
            // comboRetraite
            // 
            this.comboRetraite.FormattingEnabled = true;
            this.comboRetraite.Location = new System.Drawing.Point(407, 174);
            this.comboRetraite.Name = "comboRetraite";
            this.comboRetraite.Size = new System.Drawing.Size(121, 21);
            this.comboRetraite.TabIndex = 4;
            this.comboRetraite.SelectedIndexChanged += new System.EventHandler(this.comboRetraite_SelectedIndexChanged);
            // 
            // labelRetraite
            // 
            this.labelRetraite.AutoSize = true;
            this.labelRetraite.Location = new System.Drawing.Point(241, 182);
            this.labelRetraite.Name = "labelRetraite";
            this.labelRetraite.Size = new System.Drawing.Size(66, 13);
            this.labelRetraite.TabIndex = 5;
            this.labelRetraite.Text = "Taux retraite";
            // 
            // labelCotisation
            // 
            this.labelCotisation.AutoSize = true;
            this.labelCotisation.Location = new System.Drawing.Point(241, 141);
            this.labelCotisation.Name = "labelCotisation";
            this.labelCotisation.Size = new System.Drawing.Size(124, 13);
            this.labelCotisation.TabIndex = 6;
            this.labelCotisation.Text = "Taux cotisation vieillesse";
            // 
            // labelAssurance
            // 
            this.labelAssurance.AutoSize = true;
            this.labelAssurance.Location = new System.Drawing.Point(241, 100);
            this.labelAssurance.Name = "labelAssurance";
            this.labelAssurance.Size = new System.Drawing.Size(122, 13);
            this.labelAssurance.TabIndex = 7;
            this.labelAssurance.Text = "Taux assurance maladie";
            // 
            // labelSalaireBrut
            // 
            this.labelSalaireBrut.AutoSize = true;
            this.labelSalaireBrut.Location = new System.Drawing.Point(196, 29);
            this.labelSalaireBrut.Name = "labelSalaireBrut";
            this.labelSalaireBrut.Size = new System.Drawing.Size(60, 13);
            this.labelSalaireBrut.TabIndex = 8;
            this.labelSalaireBrut.Text = "Salaire brut";
            // 
            // labelSalaireNet
            // 
            this.labelSalaireNet.AutoSize = true;
            this.labelSalaireNet.Location = new System.Drawing.Point(241, 290);
            this.labelSalaireNet.Name = "labelSalaireNet";
            this.labelSalaireNet.Size = new System.Drawing.Size(81, 13);
            this.labelSalaireNet.TabIndex = 9;
            this.labelSalaireNet.Text = "Salaire net  =    ";
            // 
            // labelResultatSalaireNet
            // 
            this.labelResultatSalaireNet.AutoSize = true;
            this.labelResultatSalaireNet.Location = new System.Drawing.Point(378, 289);
            this.labelResultatSalaireNet.Name = "labelResultatSalaireNet";
            this.labelResultatSalaireNet.Size = new System.Drawing.Size(0, 13);
            this.labelResultatSalaireNet.TabIndex = 10;
            // 
            // textSalaireBrut
            // 
            this.textSalaireBrut.Location = new System.Drawing.Point(351, 21);
            this.textSalaireBrut.Name = "textSalaireBrut";
            this.textSalaireBrut.Size = new System.Drawing.Size(100, 20);
            this.textSalaireBrut.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(551, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "%";
            // 
            // FormSalaireNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSalaireBrut);
            this.Controls.Add(this.labelResultatSalaireNet);
            this.Controls.Add(this.labelSalaireNet);
            this.Controls.Add(this.labelSalaireBrut);
            this.Controls.Add(this.labelAssurance);
            this.Controls.Add(this.labelCotisation);
            this.Controls.Add(this.labelRetraite);
            this.Controls.Add(this.comboRetraite);
            this.Controls.Add(this.comboCotisation);
            this.Controls.Add(this.comboAssurance);
            this.Controls.Add(this.checkPrime);
            this.Controls.Add(this.buttonCalcule);
            this.Name = "FormSalaireNet";
            this.Text = "Salaire net";
            this.Load += new System.EventHandler(this.FormSalaireNet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCalcule;
        private System.Windows.Forms.CheckBox checkPrime;
        private System.Windows.Forms.ComboBox comboAssurance;
        private System.Windows.Forms.ComboBox comboCotisation;
        private System.Windows.Forms.ComboBox comboRetraite;
        private System.Windows.Forms.Label labelRetraite;
        private System.Windows.Forms.Label labelCotisation;
        private System.Windows.Forms.Label labelAssurance;
        private System.Windows.Forms.Label labelSalaireBrut;
        private System.Windows.Forms.Label labelSalaireNet;
        private System.Windows.Forms.Label labelResultatSalaireNet;
        private System.Windows.Forms.TextBox textSalaireBrut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

