namespace autoEcoleEF
{
    partial class FrmListeVehicule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEnregsitrer = new System.Windows.Forms.Button();
            this.bdgVehicules = new System.Windows.Forms.BindingSource(this.components);
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numImmaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.couleurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enEtatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leconsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numImmaDataGridViewTextBoxColumn,
            this.modeleDataGridViewTextBoxColumn,
            this.couleurDataGridViewTextBoxColumn,
            this.enEtatDataGridViewTextBoxColumn,
            this.leconsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bdgVehicules;
            this.dataGridView1.Location = new System.Drawing.Point(54, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnEnregsitrer
            // 
            this.btnEnregsitrer.Location = new System.Drawing.Point(227, 275);
            this.btnEnregsitrer.Name = "btnEnregsitrer";
            this.btnEnregsitrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregsitrer.TabIndex = 1;
            this.btnEnregsitrer.Text = "Enregistrer";
            this.btnEnregsitrer.UseVisualStyleBackColor = true;
            this.btnEnregsitrer.Click += new System.EventHandler(this.btnEnregsitrer_Click);
            // 
            // bdgVehicules
            // 
            this.bdgVehicules.DataSource = typeof(autoEcoleEF.vehicule);
            this.bdgVehicules.CurrentChanged += new System.EventHandler(this.bdgVehicules_CurrentChanged);
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataSource = typeof(autoEcoleEF.vehicule);
            // 
            // numImmaDataGridViewTextBoxColumn
            // 
            this.numImmaDataGridViewTextBoxColumn.DataPropertyName = "numImma";
            this.numImmaDataGridViewTextBoxColumn.HeaderText = "numImma";
            this.numImmaDataGridViewTextBoxColumn.Name = "numImmaDataGridViewTextBoxColumn";
            this.numImmaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modeleDataGridViewTextBoxColumn
            // 
            this.modeleDataGridViewTextBoxColumn.DataPropertyName = "modele";
            this.modeleDataGridViewTextBoxColumn.HeaderText = "modele";
            this.modeleDataGridViewTextBoxColumn.Name = "modeleDataGridViewTextBoxColumn";
            this.modeleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // couleurDataGridViewTextBoxColumn
            // 
            this.couleurDataGridViewTextBoxColumn.DataPropertyName = "couleur";
            this.couleurDataGridViewTextBoxColumn.HeaderText = "couleur";
            this.couleurDataGridViewTextBoxColumn.Name = "couleurDataGridViewTextBoxColumn";
            this.couleurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // enEtatDataGridViewTextBoxColumn
            // 
            this.enEtatDataGridViewTextBoxColumn.DataPropertyName = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.HeaderText = "enEtat";
            this.enEtatDataGridViewTextBoxColumn.Name = "enEtatDataGridViewTextBoxColumn";
            // 
            // leconsDataGridViewTextBoxColumn
            // 
            this.leconsDataGridViewTextBoxColumn.DataPropertyName = "lecons";
            this.leconsDataGridViewTextBoxColumn.HeaderText = "lecons";
            this.leconsDataGridViewTextBoxColumn.Name = "leconsDataGridViewTextBoxColumn";
            // 
            // FrmListeVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 450);
            this.Controls.Add(this.btnEnregsitrer);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmListeVehicule";
            this.Text = "FrmListeVehicule";
            this.Load += new System.EventHandler(this.FrmListeVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVehicules)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bdgVehicules;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEnregsitrer;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn numImmaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn couleurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enEtatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn leconsDataGridViewTextBoxColumn;
    }
}