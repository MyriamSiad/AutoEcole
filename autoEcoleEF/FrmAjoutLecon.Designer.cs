namespace autoEcoleEF
{
    partial class FrmAjoutLecon
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.datep = new System.Windows.Forms.Label();
            this.Heure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbxHeure = new System.Windows.Forms.ComboBox();
            this.cbxEleve = new System.Windows.Forms.ComboBox();
            this.eleveBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rdUneHeure = new System.Windows.Forms.RadioButton();
            this.rdHeure2 = new System.Windows.Forms.RadioButton();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elève";
            // 
            // datep
            // 
            this.datep.AutoSize = true;
            this.datep.Location = new System.Drawing.Point(211, 127);
            this.datep.Name = "datep";
            this.datep.Size = new System.Drawing.Size(30, 13);
            this.datep.TabIndex = 1;
            this.datep.Text = "Date";
            // 
            // Heure
            // 
            this.Heure.AutoSize = true;
            this.Heure.Location = new System.Drawing.Point(211, 158);
            this.Heure.Name = "Heure";
            this.Heure.Size = new System.Drawing.Size(36, 13);
            this.Heure.TabIndex = 2;
            this.Heure.Text = "Heure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(284, 121);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // cbxHeure
            // 
            this.cbxHeure.FormattingEnabled = true;
            this.cbxHeure.Location = new System.Drawing.Point(284, 158);
            this.cbxHeure.Name = "cbxHeure";
            this.cbxHeure.Size = new System.Drawing.Size(121, 21);
            this.cbxHeure.TabIndex = 6;
            this.cbxHeure.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbxEleve
            // 
            this.cbxEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eleveBindingSource, "nom", true));
            this.cbxEleve.DataSource = this.eleveBindingSource;
            this.cbxEleve.DisplayMember = "nom";
            this.cbxEleve.FormattingEnabled = true;
            this.cbxEleve.Location = new System.Drawing.Point(284, 73);
            this.cbxEleve.Name = "cbxEleve";
            this.cbxEleve.Size = new System.Drawing.Size(121, 21);
            this.cbxEleve.TabIndex = 7;
            this.cbxEleve.SelectedIndexChanged += new System.EventHandler(this.cbxEleve_SelectedIndexChanged);
            // 
            // eleveBindingSource
            // 
            this.eleveBindingSource.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // rdUneHeure
            // 
            this.rdUneHeure.AutoSize = true;
            this.rdUneHeure.Location = new System.Drawing.Point(284, 232);
            this.rdUneHeure.Name = "rdUneHeure";
            this.rdUneHeure.Size = new System.Drawing.Size(75, 17);
            this.rdUneHeure.TabIndex = 8;
            this.rdUneHeure.TabStop = true;
            this.rdUneHeure.Text = "Une heure";
            this.rdUneHeure.UseVisualStyleBackColor = true;
            // 
            // rdHeure2
            // 
            this.rdHeure2.AutoSize = true;
            this.rdHeure2.Location = new System.Drawing.Point(408, 230);
            this.rdHeure2.Name = "rdHeure2";
            this.rdHeure2.Size = new System.Drawing.Size(85, 17);
            this.rdHeure2.TabIndex = 9;
            this.rdHeure2.TabStop = true;
            this.rdHeure2.Text = "Deux heures";
            this.rdHeure2.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(330, 288);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // FrmAjoutLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 388);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.rdHeure2);
            this.Controls.Add(this.rdUneHeure);
            this.Controls.Add(this.cbxEleve);
            this.Controls.Add(this.cbxHeure);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Heure);
            this.Controls.Add(this.datep);
            this.Controls.Add(this.label1);
            this.Name = "FrmAjoutLecon";
            this.Text = "FrmAjoutLecon";
            this.Load += new System.EventHandler(this.FrmAjoutLecon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eleveBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datep;
        private System.Windows.Forms.Label Heure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbxHeure;
        private System.Windows.Forms.ComboBox cbxEleve;
        private System.Windows.Forms.RadioButton rdUneHeure;
        private System.Windows.Forms.RadioButton rdHeure2;
        private System.Windows.Forms.BindingSource eleveBindingSource;
        private System.Windows.Forms.Button btnEnregistrer;
    }
}