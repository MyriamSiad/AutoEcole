using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class FrmValiderLecon : Form
    {
        private AutoEcoleEntities mesDonneeF;
        public FrmValiderLecon(AutoEcoleEntities mesDonneeF)
        {
            InitializeComponent();
            this.mesDonneeF = mesDonneeF;
            this.bdSVehicule.DataSource = mesDonneeF.vehicules.ToList();
            this.leconBindingSource.DataSource = mesDonneeF.lecons.ToList();
            this.dataGridView1.AutoGenerateColumns = false;

            // Création de la source de données 

            var lesLecons = from l in mesDonneeF.lecons
                            where l.effectueeOui_Non == 0
                            select l;

            this.leconBindingSource.DataSource = mesDonneeF.lecons
                .Where(l => l.effectueeOui_Non == 0) // Filtrage des leçons non effectuées
                .ToList();

          

            //Création d'une colonne de type text pour la date 
            DataGridViewTextBoxColumn txtColonneDate = new DataGridViewTextBoxColumn();
            txtColonneDate.HeaderText = "date";
            txtColonneDate.Name = "date";
            txtColonneDate.DataPropertyName = "date";
            this.dataGridView1.Columns.Add(txtColonneDate);
         
            //Création d'une colonne de type text pour l'heure 
            DataGridViewTextBoxColumn txtColonneHeure = new DataGridViewTextBoxColumn();
            txtColonneHeure.HeaderText = "heure";
            txtColonneHeure.Name = "heure";
            txtColonneHeure.DataPropertyName = "heure";
            this.dataGridView1.Columns.Add(txtColonneHeure);

            //Creation de la colonne de type Combox pour le NumImma 

            DataGridViewComboBoxColumn cmbColonneVehicule = new DataGridViewComboBoxColumn();
            cmbColonneVehicule.HeaderText = "vehicule";
            cmbColonneVehicule.Name = "vehicule";
            cmbColonneVehicule.DisplayMember = "numImma";
            cmbColonneVehicule.DataPropertyName = "numImmaVehicule";
            cmbColonneVehicule.DataSource = this.bdSVehicule;
            this.dataGridView1.Columns.Add(cmbColonneVehicule);

            // Créatio d'une colonne de type Checkbox pour effectuer_OuiNon
            DataGridViewCheckBoxColumn chkColonneOk = new DataGridViewCheckBoxColumn();
            chkColonneOk.HeaderText = "effectuer";
            chkColonneOk.Name = "effectuer";
            chkColonneOk.DataPropertyName = "effectueeOui_Non";
          
            this.dataGridView1.Columns.Add(chkColonneOk);
            this.dataGridView1.DataSource = this.leconBindingSource;


            // Binding des labels des nom et prenom 
            lblNom.DataBindings.Add("Text", leconBindingSource, "eleve.nom");
            lblPrenom.DataBindings.Add("Text", leconBindingSource, "eleve.prenom");



        }

        private void FrmValiderLecon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.leconBindingSource.EndEdit();
            this.mesDonneeF.SaveChanges();
        }

        private void Elève_Enter(object sender, EventArgs e)
        {

        }

        private void lblNom_Click(object sender, EventArgs e)
        {

        }
    }
}
