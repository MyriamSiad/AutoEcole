namespace autoEcoleEF
{
    partial class FrmVisualiserEleve
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
            this.dtgViewEleve = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgViewlecon = new System.Windows.Forms.DataGridView();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dureeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.effectueeOuiNonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numImmaVehiculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdgSvehicule = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSlecon = new System.Windows.Forms.BindingSource(this.components);
            this.bdgSeleve = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creditHoraireDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewlecon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSvehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSlecon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSeleve)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgViewEleve
            // 
            this.dtgViewEleve.AutoGenerateColumns = false;
            this.dtgViewEleve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewEleve.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.creditHoraireDataGridViewTextBoxColumn});
            this.dtgViewEleve.DataSource = this.bdgSeleve;
            this.dtgViewEleve.Location = new System.Drawing.Point(29, 41);
            this.dtgViewEleve.Name = "dtgViewEleve";
            this.dtgViewEleve.Size = new System.Drawing.Size(448, 150);
            this.dtgViewEleve.TabIndex = 0;
            this.dtgViewEleve.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewEleve_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Liste des éléves";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Les leçons de chaque éléve";
            // 
            // dtgViewlecon
            // 
            this.dtgViewlecon.AllowUserToAddRows = false;
            this.dtgViewlecon.AllowUserToDeleteRows = false;
            this.dtgViewlecon.AutoGenerateColumns = false;
            this.dtgViewlecon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgViewlecon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.dureeDataGridViewTextBoxColumn,
            this.effectueeOuiNonDataGridViewTextBoxColumn,
            this.numImmaVehiculeDataGridViewTextBoxColumn});
            this.dtgViewlecon.DataSource = this.bdgSlecon;
            this.dtgViewlecon.Location = new System.Drawing.Point(33, 264);
            this.dtgViewlecon.Name = "dtgViewlecon";
            this.dtgViewlecon.ReadOnly = true;
            this.dtgViewlecon.Size = new System.Drawing.Size(659, 150);
            this.dtgViewlecon.TabIndex = 3;
            this.dtgViewlecon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgViewlecon_CellContentClick);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(541, 112);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            this.heureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dureeDataGridViewTextBoxColumn
            // 
            this.dureeDataGridViewTextBoxColumn.DataPropertyName = "duree";
            this.dureeDataGridViewTextBoxColumn.HeaderText = "duree";
            this.dureeDataGridViewTextBoxColumn.Name = "dureeDataGridViewTextBoxColumn";
            this.dureeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // effectueeOuiNonDataGridViewTextBoxColumn
            // 
            this.effectueeOuiNonDataGridViewTextBoxColumn.DataPropertyName = "effectueeOui_Non";
            this.effectueeOuiNonDataGridViewTextBoxColumn.HeaderText = "effectueeOui_Non";
            this.effectueeOuiNonDataGridViewTextBoxColumn.Name = "effectueeOuiNonDataGridViewTextBoxColumn";
            this.effectueeOuiNonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numImmaVehiculeDataGridViewTextBoxColumn
            // 
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataPropertyName = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataSource = this.bdgSvehicule;
            this.numImmaVehiculeDataGridViewTextBoxColumn.DisplayMember = "numImma";
            this.numImmaVehiculeDataGridViewTextBoxColumn.HeaderText = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.Name = "numImmaVehiculeDataGridViewTextBoxColumn";
            this.numImmaVehiculeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numImmaVehiculeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numImmaVehiculeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bdgSvehicule
            // 
            this.bdgSvehicule.DataSource = typeof(autoEcoleEF.vehicule);
            // 
            // bdgSlecon
            // 
            this.bdgSlecon.DataSource = typeof(autoEcoleEF.lecon);
            // 
            // bdgSeleve
            // 
            this.bdgSeleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // creditHoraireDataGridViewTextBoxColumn
            // 
            this.creditHoraireDataGridViewTextBoxColumn.DataPropertyName = "creditHoraire";
            this.creditHoraireDataGridViewTextBoxColumn.HeaderText = "creditHoraire";
            this.creditHoraireDataGridViewTextBoxColumn.Name = "creditHoraireDataGridViewTextBoxColumn";
            // 
            // FrmVisualiserEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dtgViewlecon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgViewEleve);
            this.Name = "FrmVisualiserEleve";
            this.Text = "FrmVisualiserEleve";
            this.Load += new System.EventHandler(this.FrmVisualiserEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgViewlecon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSvehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSlecon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSeleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgViewEleve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgViewlecon;
        private System.Windows.Forms.BindingSource bdgSeleve;
        private System.Windows.Forms.BindingSource bdgSvehicule;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.BindingSource bdgSlecon;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dureeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn effectueeOuiNonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn numImmaVehiculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn creditHoraireDataGridViewTextBoxColumn;
    }
}