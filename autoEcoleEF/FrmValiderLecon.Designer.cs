namespace autoEcoleEF
{
    partial class FrmValiderLecon
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.Elève = new System.Windows.Forms.GroupBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.BdgSeleve = new System.Windows.Forms.BindingSource(this.components);
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numImmaVehiculeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bdSVehicule = new System.Windows.Forms.BindingSource(this.components);
            this.effectueeOuiNonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leconBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Elève.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdgSeleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leconBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.heureDataGridViewTextBoxColumn,
            this.numImmaVehiculeDataGridViewTextBoxColumn,
            this.effectueeOuiNonDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.leconBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(251, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 272);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(423, 415);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 1;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // Elève
            // 
            this.Elève.Controls.Add(this.lblPrenom);
            this.Elève.Controls.Add(this.lblNom);
            this.Elève.Location = new System.Drawing.Point(33, 25);
            this.Elève.Name = "Elève";
            this.Elève.Size = new System.Drawing.Size(200, 100);
            this.Elève.TabIndex = 2;
            this.Elève.TabStop = false;
            this.Elève.Text = "Elève";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(33, 20);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(38, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom : ";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(36, 51);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prenom";
            // 
            // BdgSeleve
            // 
            this.BdgSeleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // heureDataGridViewTextBoxColumn
            // 
            this.heureDataGridViewTextBoxColumn.DataPropertyName = "heure";
            this.heureDataGridViewTextBoxColumn.HeaderText = "heure";
            this.heureDataGridViewTextBoxColumn.Name = "heureDataGridViewTextBoxColumn";
            // 
            // numImmaVehiculeDataGridViewTextBoxColumn
            // 
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataPropertyName = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.DataSource = this.bdSVehicule;
            this.numImmaVehiculeDataGridViewTextBoxColumn.DisplayMember = "numImma";
            this.numImmaVehiculeDataGridViewTextBoxColumn.HeaderText = "numImmaVehicule";
            this.numImmaVehiculeDataGridViewTextBoxColumn.Name = "numImmaVehiculeDataGridViewTextBoxColumn";
            this.numImmaVehiculeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.numImmaVehiculeDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // bdSVehicule
            // 
            this.bdSVehicule.DataSource = typeof(autoEcoleEF.vehicule);
            // 
            // effectueeOuiNonDataGridViewTextBoxColumn
            // 
            this.effectueeOuiNonDataGridViewTextBoxColumn.DataPropertyName = "effectueeOui_Non";
            this.effectueeOuiNonDataGridViewTextBoxColumn.FalseValue = "0";
            this.effectueeOuiNonDataGridViewTextBoxColumn.HeaderText = "Effectue ";
            this.effectueeOuiNonDataGridViewTextBoxColumn.Name = "effectueeOuiNonDataGridViewTextBoxColumn";
            this.effectueeOuiNonDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.effectueeOuiNonDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.effectueeOuiNonDataGridViewTextBoxColumn.TrueValue = "1";
            // 
            // leconBindingSource
            // 
            this.leconBindingSource.DataSource = typeof(autoEcoleEF.lecon);
            // 
            // FrmValiderLecon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.Elève);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmValiderLecon";
            this.Text = "FrmValiderLecon";
            this.Load += new System.EventHandler(this.FrmValiderLecon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Elève.ResumeLayout(false);
            this.Elève.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BdgSeleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdSVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leconBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource leconBindingSource;
        private System.Windows.Forms.BindingSource bdSVehicule;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn numImmaVehiculeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn effectueeOuiNonDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox Elève;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.BindingSource BdgSeleve;
    }
}