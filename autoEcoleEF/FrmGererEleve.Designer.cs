namespace autoEcoleEF
{
    partial class FrmGererEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGererEleve));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bdgSourceEleve = new System.Windows.Forms.BindingSource(this.components);
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtInscription = new System.Windows.Forms.DateTimePicker();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.cmbCredit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bdgNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.Enregistrer = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNav)).BeginInit();
            this.bdgNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "prenom", true));
            this.textBox1.Location = new System.Drawing.Point(238, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // bdgSourceEleve
            // 
            this.bdgSourceEleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "nom", true));
            this.txtNom.Location = new System.Drawing.Point(238, 88);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "id", true));
            this.txtNum.Location = new System.Drawing.Point(238, 34);
            this.txtNum.Name = "txtNum";
            this.txtNum.ReadOnly = true;
            this.txtNum.Size = new System.Drawing.Size(100, 20);
            this.txtNum.TabIndex = 3;
            this.txtNum.TextChanged += new System.EventHandler(this.txtNum_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Numéro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom";
            // 
            // txtPrenom
            // 
            this.txtPrenom.AutoSize = true;
            this.txtPrenom.Location = new System.Drawing.Point(88, 156);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(43, 13);
            this.txtPrenom.TabIndex = 6;
            this.txtPrenom.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Date d\'inscription";
            // 
            // dtInscription
            // 
            this.dtInscription.Location = new System.Drawing.Point(204, 252);
            this.dtInscription.Name = "dtInscription";
            this.dtInscription.Size = new System.Drawing.Size(200, 20);
            this.dtInscription.TabIndex = 10;
            // 
            // txtAdresse
            // 
            this.txtAdresse.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "adresse", true));
            this.txtAdresse.Location = new System.Drawing.Point(238, 204);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(100, 20);
            this.txtAdresse.TabIndex = 12;
            // 
            // cmbCredit
            // 
            this.cmbCredit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "creditHoraire", true));
            this.cmbCredit.FormattingEnabled = true;
            this.cmbCredit.Location = new System.Drawing.Point(238, 333);
            this.cmbCredit.Name = "cmbCredit";
            this.cmbCredit.Size = new System.Drawing.Size(121, 21);
            this.cmbCredit.TabIndex = 13;
            this.cmbCredit.SelectedIndexChanged += new System.EventHandler(this.cmbCredit_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Crédit horaire";
            // 
            // bdgNav
            // 
            this.bdgNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdgNav.BindingSource = this.bdgSourceEleve;
            this.bdgNav.CountItem = this.bindingNavigatorCountItem;
            this.bdgNav.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdgNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.Enregistrer});
            this.bdgNav.Location = new System.Drawing.Point(0, 0);
            this.bdgNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgNav.Name = "bdgNav";
            this.bdgNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgNav.Size = new System.Drawing.Size(483, 25);
            this.bdgNav.TabIndex = 15;
            this.bdgNav.Text = "bindingNavigator1";
            this.bdgNav.RefreshItems += new System.EventHandler(this.bdgNav_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // Enregistrer
            // 
            this.Enregistrer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Enregistrer.Image = ((System.Drawing.Image)(resources.GetObject("Enregistrer.Image")));
            this.Enregistrer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Enregistrer.Name = "Enregistrer";
            this.Enregistrer.Size = new System.Drawing.Size(23, 22);
            this.Enregistrer.Text = "Enregistrer";
            this.Enregistrer.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmGererEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 454);
            this.Controls.Add(this.bdgNav);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCredit);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.dtInscription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmGererEleve";
            this.Text = "FrmGererEleve";
            this.Load += new System.EventHandler(this.FrmGererEleve_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNav)).EndInit();
            this.bdgNav.ResumeLayout(false);
            this.bdgNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtPrenom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtInscription;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.ComboBox cmbCredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdgSourceEleve;
        private System.Windows.Forms.BindingNavigator bdgNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton Enregistrer;
    }
}